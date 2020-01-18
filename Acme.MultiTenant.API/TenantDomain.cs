using System;
using System.Linq;
using Acme.MultiTenant.EFDAL;
using Acme.MultiTenant.EFDAL.Entity;
using System.Collections.Generic;
using System.Text;

namespace Acme.MultiTenant.API
{
    public static class TenantDomain
    {
        public static bool CreateTenant(string tenantName)
        {
            //Create a new tenant if the name does not exist
            using (var context = new MultiTenantEntities(DatabaseHelper.MasterConnectionString))
            {
                //Check for tenant existence
                if (context.TenantMaster.Any(x => x.TenantName == tenantName))
                {
                    throw new Exception("The tenant already exists.");
                }

                //Create a SQL database user and store the creds for this tenant
                var newUser = Utilities.GetRandomString();
                var password = Utilities.GetRandomString();
                var passwordCipher = SecurityDomain.Crypt(password);
                var newItem = new TenantMaster
                {
                    TenantName = tenantName,
                    DbUserName = newUser,
                    DbPassword = passwordCipher,
                };
                context.Add(newItem);
                context.SaveChanges();

                //Create database permissions
                //Note: cannot use parameters as these are not data queries. They are DDL
                var sb = new StringBuilder();
                sb.AppendLine($"CREATE LOGIN [{newItem.DbUserName}] WITH PASSWORD=N'{password}'");
                sb.AppendLine($"if not exists(select * from sys.sysusers where name = '{newItem.DbUserName}')");
                sb.AppendLine($"CREATE USER [{newItem.DbUserName}] FOR LOGIN [{newItem.DbUserName}];");
                //The "TenantRole" was created in a custom script in the SQL installer in the "6_UserDefinedFinalize\Always" folder
                sb.AppendLine("GRANT DELETE TO [TenantRole];");
                sb.AppendLine("GRANT INSERT TO [TenantRole];");
                sb.AppendLine("GRANT SELECT TO [TenantRole];");
                sb.AppendLine("GRANT UPDATE TO [TenantRole];");
                sb.AppendLine($"ALTER ROLE [TenantRole] ADD MEMBER [{newItem.DbUserName}];");
                DatabaseHelper.ExecuteSql(sb.ToString());
            }

            return true;
        }
    }
}
