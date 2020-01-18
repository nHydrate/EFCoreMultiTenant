using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using Acme.MultiTenant.EFDAL;
using Acme.MultiTenant.EFDAL.Entity;

namespace Acme.MultiTenant.API
{
    public static class DatabaseHelper
    {
        //Cache tenant information and connection strings
        private static ConcurrentDictionary<int, string> _csMap = new ConcurrentDictionary<int, string>();

        public static string GetTenantConnectionString(int tenantId)
        {
            try
            {
                return _csMap.GetOrAdd(tenantId, (id) =>
                {
                    EFDAL.Entity.TenantMaster item = null;
                    using (var context = new MultiTenantEntities(DatabaseHelper.MasterConnectionString))
                    {
                        item = context.TenantMaster.FirstOrDefault(x => x.TenantId == id);
                        if (item == null)
                            throw new Exception("Tenant not found");
                    }

                    var builder = new SqlConnectionStringBuilder(MasterConnectionString);
                    builder.UserID = item.DbUserName;
                    builder.Password = SecurityDomain.Decrypt(item.DbPassword);
                    builder.IntegratedSecurity = false;
                    return builder.ToString();
                });
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                return null;
            }
        }

        public static string MasterConnectionString
        {
            get
            {
                //The connection string is in the App.Config file in the console app
                var connectionString = ConfigurationManager.ConnectionStrings["MultiTenantEntities"]?.ConnectionString;
                return connectionString;
            }
        }

        /// <summary>
        /// Directly execute a SQL statement
        /// </summary>
        internal static void ExecuteSql(string sql, List<SqlParameter> parameters = null)
        {
            try
            {
                using (var connection = new SqlConnection(MasterConnectionString))
                {
                    var command = new SqlCommand(sql, connection);
                    if (parameters != null && parameters.Any())
                        command.Parameters.AddRange(parameters.ToArray());
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
                //throw;
            }
        }

    }
}