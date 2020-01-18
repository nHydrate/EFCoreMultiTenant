using Acme.MultiTenant.API;
using Acme.MultiTenant.EFDAL;
using Acme.MultiTenant.EFDAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //****************************************
            //The EFDAL project is generated
            //The Installer project is generated
            //Teh API project is hand written containing a few utilities to create tenants
            //The Console app 

            //For now this will store the tenant ID in a variable.
            //In production you would use a session variable or some other login management technique.
            var tenant1Id = 0;
            var tenant2Id = 0;

            //Connect to the database with the master connection string
            //There is no tenant information in this connection string
            using (var context = new MultiTenantEntities(DatabaseHelper.MasterConnectionString))
            {
                var tenant1Name = "Tenant1";
                var tenant2Name = "Tenant2";

                #region Create Tenants IF EMPTY
                if (!context.TenantMaster.Any())
                {
                    //Create Tenant 1
                    TenantDomain.CreateTenant(tenant1Name);
                    Console.WriteLine($"Created {tenant1Name}");

                    //Create Tenant 2
                    TenantDomain.CreateTenant(tenant2Name);
                    Console.WriteLine($"Created {tenant2Name}");
                }
                #endregion

                //Pull each Tenant ID from the database for testing
                tenant1Id = context.TenantMaster.FirstOrDefault(x => x.TenantName == tenant1Name).TenantId;
                tenant2Id = context.TenantMaster.FirstOrDefault(x => x.TenantName == tenant2Name).TenantId;
            }

            //Now connect with the connection string for Tenant1
            using (var context = new MultiTenantEntities(DatabaseHelper.GetTenantConnectionString(tenant1Id)))
            {
                //Add "Project 1" through "Project 10"
                for (var ii = 1; ii <= 10; ii++)
                {
                    var newProject = new Project
                    {
                        Name = $"Project {ii}",
                        ProjectTypeValue = ProjectTypeConstants.CSharp
                    };
                    context.AddItem(newProject);
                }
                context.SaveChanges();
            }

            //Now connect with the connection string for Tenant2
            using (var context = new MultiTenantEntities(DatabaseHelper.GetTenantConnectionString(tenant2Id)))
            {
                //Add "Project 11" through "Project 20"
                for (var ii = 11; ii <= 20; ii++)
                {
                    var newProject = new Project
                    {
                        Name = $"Project {ii}",
                        ProjectTypeValue = ProjectTypeConstants.Java
                    };
                    context.AddItem(newProject);
                }
                context.SaveChanges();
            }

            //Now select ALL Projects using the Tenant1 connection string
            using (var context = new MultiTenantEntities(DatabaseHelper.GetTenantConnectionString(tenant1Id)))
            {
                var list = context.Project.ToList();
                Console.WriteLine($"Tenant 1 Project Count={list.Count}");
                foreach(var item in list)
                    Console.WriteLine($"Tenant 1, Project ={item.Name}");

                //Notice that there are only 10 items even with no Where clause
                //The framework limits the selection to only items for Tenant 1.
                //There is never any data leak between tenants
            }

            //Now select ALL Projects using the Tenant2 connection string
            using (var context = new MultiTenantEntities(DatabaseHelper.GetTenantConnectionString(tenant2Id)))
            {
                var list = context.Project.ToList();
                Console.WriteLine($"Tenant 2 Project Count={list.Count}");
                foreach (var item in list)
                    Console.WriteLine($"Tenant 2, Project ={item.Name}");

                //Notice that there are only 10 items even with no Where clause
                //The framework limits the selection to only items for Tenant 2.
                //There is never any data leak between tenants
            }

        }
    }
}
