# Entity Framework Core Mult-Tenant Example

This sample project uses the nHydrate modeler to define a multi-tenant entity model. 
Tenant access is controlled using connection strings. Each tenant has a unique database user.
The code shows how to create a SQL Server user and use it to manage database entities with no data bleed.
A tenant's data cannot "bleed" to other tenants. A Where statement is not necessary to limit tenant data.
The framework handles all permissions to tenant data to ensure that bleed does not occur.
In fact, it is not possible to query data across tenants.


<p align="center" style="padding-top:20px;">
<img src="http://nhydrate.org/images/nhydrate-medium.png" title="nHydrate for Entity Framework" >
</p>
