--Create default database info
IF DATABASE_PRINCIPAL_ID('TenantRole') IS NULL
CREATE ROLE [TenantRole] AUTHORIZATION dbo;
GO
