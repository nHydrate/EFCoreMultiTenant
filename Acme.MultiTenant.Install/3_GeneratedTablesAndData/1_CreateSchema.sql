--DO NOT MODIFY THIS FILE. IT IS ALWAYS OVERWRITTEN ON GENERATION.
--Data Schema

--CREATE TABLE [Project]
if not exists(select * from sys.tables t inner join sys.schemas s on t.schema_id = s.schema_id where t.name = 'Project' and s.name = 'dbo')
CREATE TABLE [dbo].[Project] (
	[ProjectId] [Int] IDENTITY (1, 1) NOT NULL ,
	[Name] [VarChar] (50) NOT NULL ,
	[ProjectTypeId] [Int] NOT NULL ,
	[ModifiedBy] [NVarchar] (50) NULL,
	[ModifiedDate] [DateTime2] CONSTRAINT [DF__PROJECT_MODIFIEDDATE] DEFAULT sysdatetime() NULL,
	[CreatedBy] [NVarchar] (50) NULL,
	[CreatedDate] [DateTime2] CONSTRAINT [DF__PROJECT_CREATEDDATE] DEFAULT sysdatetime() NULL,
	[Timestamp] [ROWVERSION] NOT NULL,
	[__tenant_user] [nvarchar] (128) NOT NULL CONSTRAINT [DF__PROJECT___TENANT_USER] DEFAULT (suser_sname()),
	CONSTRAINT [PK_PROJECT] PRIMARY KEY CLUSTERED
	(
		[ProjectId]
	)
)

GO

--CREATE TABLE [ProjectFile]
if not exists(select * from sys.tables t inner join sys.schemas s on t.schema_id = s.schema_id where t.name = 'ProjectFile' and s.name = 'dbo')
CREATE TABLE [dbo].[ProjectFile] (
	[ProjectFileId] [Int] IDENTITY (1, 1) NOT NULL ,
	[ProjectId] [Int] NOT NULL ,
	[FileName] [VarChar] (450) NOT NULL ,
	[ModifiedBy] [NVarchar] (50) NULL,
	[ModifiedDate] [DateTime2] CONSTRAINT [DF__PROJECTFILE_MODIFIEDDATE] DEFAULT sysdatetime() NULL,
	[CreatedBy] [NVarchar] (50) NULL,
	[CreatedDate] [DateTime2] CONSTRAINT [DF__PROJECTFILE_CREATEDDATE] DEFAULT sysdatetime() NULL,
	[Timestamp] [ROWVERSION] NOT NULL,
	[__tenant_user] [nvarchar] (128) NOT NULL CONSTRAINT [DF__PROJECTFILE___TENANT_USER] DEFAULT (suser_sname()),
	CONSTRAINT [PK_PROJECTFILE] PRIMARY KEY CLUSTERED
	(
		[ProjectFileId]
	)
)

GO

--CREATE TABLE [ProjectType]
if not exists(select * from sys.tables t inner join sys.schemas s on t.schema_id = s.schema_id where t.name = 'ProjectType' and s.name = 'dbo')
CREATE TABLE [dbo].[ProjectType] (
	[ProjectTypeId] [Int] IDENTITY (1, 1) NOT NULL ,
	[Name] [VarChar] (50) NOT NULL ,
	[ModifiedBy] [NVarchar] (50) NULL,
	[ModifiedDate] [DateTime2] CONSTRAINT [DF__PROJECTTYPE_MODIFIEDDATE] DEFAULT sysdatetime() NULL,
	[CreatedBy] [NVarchar] (50) NULL,
	[CreatedDate] [DateTime2] CONSTRAINT [DF__PROJECTTYPE_CREATEDDATE] DEFAULT sysdatetime() NULL,
	[Timestamp] [ROWVERSION] NOT NULL,
	CONSTRAINT [PK_PROJECTTYPE] PRIMARY KEY CLUSTERED
	(
		[ProjectTypeId]
	)
)

GO

--CREATE TABLE [TenantMaster]
if not exists(select * from sys.tables t inner join sys.schemas s on t.schema_id = s.schema_id where t.name = 'TenantMaster' and s.name = 'dbo')
CREATE TABLE [dbo].[TenantMaster] (
	[TenantId] [Int] IDENTITY (1, 1) NOT NULL ,
	[TenantName] [VarChar] (50) NOT NULL ,
	[DbUserName] [VarChar] (50) NOT NULL ,
	[DbPassword] [VarChar] (200) NOT NULL ,
	[ModifiedBy] [NVarchar] (50) NULL,
	[ModifiedDate] [DateTime2] CONSTRAINT [DF__TENANTMASTER_MODIFIEDDATE] DEFAULT sysdatetime() NULL,
	[CreatedBy] [NVarchar] (50) NULL,
	[CreatedDate] [DateTime2] CONSTRAINT [DF__TENANTMASTER_CREATEDDATE] DEFAULT sysdatetime() NULL,
	[Timestamp] [ROWVERSION] NOT NULL,
	CONSTRAINT [PK_TENANTMASTER] PRIMARY KEY CLUSTERED
	(
		[TenantId]
	)
)

GO

--CREATE TABLE [UserAccount]
if not exists(select * from sys.tables t inner join sys.schemas s on t.schema_id = s.schema_id where t.name = 'UserAccount' and s.name = 'dbo')
CREATE TABLE [dbo].[UserAccount] (
	[UserId] [Int] IDENTITY (1, 1) NOT NULL ,
	[UserName] [VarChar] (50) NOT NULL ,
	[PasswordHash] [VarChar] (50) NOT NULL ,
	[TenantId] [Int] NOT NULL ,
	[ModifiedBy] [NVarchar] (50) NULL,
	[ModifiedDate] [DateTime2] CONSTRAINT [DF__USERACCOUNT_MODIFIEDDATE] DEFAULT sysdatetime() NULL,
	[CreatedBy] [NVarchar] (50) NULL,
	[CreatedDate] [DateTime2] CONSTRAINT [DF__USERACCOUNT_CREATEDDATE] DEFAULT sysdatetime() NULL,
	[Timestamp] [ROWVERSION] NOT NULL,
	CONSTRAINT [PK_USERACCOUNT] PRIMARY KEY CLUSTERED
	(
		[UserId]
	)
)

GO

--##SECTION BEGIN [FIELD CREATE]
--TABLE [Project] ADD FIELDS
if exists(select * from sys.objects where name = 'Project' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'ProjectId' and o.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [ProjectId] [Int] IDENTITY (1, 1) NOT NULL 
if exists(select * from sys.objects where name = 'Project' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'Name' and o.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [Name] [VarChar] (50) NOT NULL 
if exists(select * from sys.objects where name = 'Project' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'ProjectTypeId' and o.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [ProjectTypeId] [Int] NOT NULL 
GO
--TABLE [ProjectFile] ADD FIELDS
if exists(select * from sys.objects where name = 'ProjectFile' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'ProjectFileId' and o.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [ProjectFileId] [Int] IDENTITY (1, 1) NOT NULL 
if exists(select * from sys.objects where name = 'ProjectFile' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'ProjectId' and o.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [ProjectId] [Int] NOT NULL 
if exists(select * from sys.objects where name = 'ProjectFile' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'FileName' and o.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [FileName] [VarChar] (450) NOT NULL 
GO
--TABLE [ProjectType] ADD FIELDS
if exists(select * from sys.objects where name = 'ProjectType' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'ProjectTypeId' and o.name = 'ProjectType')
ALTER TABLE [dbo].[ProjectType] ADD [ProjectTypeId] [Int] IDENTITY (1, 1) NOT NULL 
if exists(select * from sys.objects where name = 'ProjectType' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'Name' and o.name = 'ProjectType')
ALTER TABLE [dbo].[ProjectType] ADD [Name] [VarChar] (50) NOT NULL 
GO
--TABLE [TenantMaster] ADD FIELDS
if exists(select * from sys.objects where name = 'TenantMaster' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'TenantId' and o.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [TenantId] [Int] IDENTITY (1, 1) NOT NULL 
if exists(select * from sys.objects where name = 'TenantMaster' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'TenantName' and o.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [TenantName] [VarChar] (50) NOT NULL 
if exists(select * from sys.objects where name = 'TenantMaster' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'DbUserName' and o.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [DbUserName] [VarChar] (50) NOT NULL 
if exists(select * from sys.objects where name = 'TenantMaster' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'DbPassword' and o.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [DbPassword] [VarChar] (200) NOT NULL 
GO
--TABLE [UserAccount] ADD FIELDS
if exists(select * from sys.objects where name = 'UserAccount' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'UserId' and o.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [UserId] [Int] IDENTITY (1, 1) NOT NULL 
if exists(select * from sys.objects where name = 'UserAccount' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'UserName' and o.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [UserName] [VarChar] (50) NOT NULL 
if exists(select * from sys.objects where name = 'UserAccount' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'PasswordHash' and o.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [PasswordHash] [VarChar] (50) NOT NULL 
if exists(select * from sys.objects where name = 'UserAccount' and type = 'U') AND not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'TenantId' and o.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [TenantId] [Int] NOT NULL 
GO
--##SECTION END [FIELD CREATE]

--DROP TENANT VIEW FOR TABLE [Project]
if exists (select * from sys.objects where name = '__vw_tenant_Project' and [type] in ('V'))
DROP VIEW [__vw_tenant_Project]
GO

--CREATE TENANT VIEW FOR TABLE [Project]
CREATE VIEW [dbo].[__vw_tenant_Project] 
AS
select * from [Project]
WHERE ([__tenant_user] = SYSTEM_USER)
GO
--DROP TENANT VIEW FOR TABLE [ProjectFile]
if exists (select * from sys.objects where name = '__vw_tenant_ProjectFile' and [type] in ('V'))
DROP VIEW [__vw_tenant_ProjectFile]
GO

--CREATE TENANT VIEW FOR TABLE [ProjectFile]
CREATE VIEW [dbo].[__vw_tenant_ProjectFile] 
AS
select * from [ProjectFile]
WHERE ([__tenant_user] = SYSTEM_USER)
GO
--##SECTION BEGIN [AUDIT TRAIL CREATE]

--APPEND AUDIT TRAIL CREATE FOR TABLE [Project]
if exists(select * from sys.tables where name = 'Project') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedBy' and t.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [CreatedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'Project') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedDate' and t.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [CreatedDate] [DateTime2] CONSTRAINT [DF__PROJECT_CREATEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL MODIFY FOR TABLE [Project]
if exists(select * from sys.tables where name = 'Project') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedBy' and t.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [ModifiedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'Project') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedDate' and t.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [ModifiedDate] [DateTime2] CONSTRAINT [DF__PROJECT_MODIFIEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL TIMESTAMP FOR TABLE [Project]
if exists(select * from sys.tables where name = 'Project') and not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'Timestamp' and o.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [Timestamp] [ROWVERSION] NOT NULL
GO

--APPEND TENANT FIELD FOR TABLE [Project]
if exists(select * from sys.tables t inner join sys.schemas s on t.schema_id = s.schema_id where t.name = 'Project' and s.name = 'dbo') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = '__tenant_user' and t.name = 'Project')
ALTER TABLE [dbo].[Project] ADD [__tenant_user] [nvarchar] (128) NOT NULL CONSTRAINT [DF__PROJECT___TENANT_USER] DEFAULT (suser_sname())

GO

--APPEND AUDIT TRAIL CREATE FOR TABLE [ProjectFile]
if exists(select * from sys.tables where name = 'ProjectFile') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedBy' and t.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [CreatedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'ProjectFile') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedDate' and t.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [CreatedDate] [DateTime2] CONSTRAINT [DF__PROJECTFILE_CREATEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL MODIFY FOR TABLE [ProjectFile]
if exists(select * from sys.tables where name = 'ProjectFile') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedBy' and t.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [ModifiedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'ProjectFile') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedDate' and t.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [ModifiedDate] [DateTime2] CONSTRAINT [DF__PROJECTFILE_MODIFIEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL TIMESTAMP FOR TABLE [ProjectFile]
if exists(select * from sys.tables where name = 'ProjectFile') and not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'Timestamp' and o.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [Timestamp] [ROWVERSION] NOT NULL
GO

--APPEND TENANT FIELD FOR TABLE [ProjectFile]
if exists(select * from sys.tables t inner join sys.schemas s on t.schema_id = s.schema_id where t.name = 'ProjectFile' and s.name = 'dbo') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = '__tenant_user' and t.name = 'ProjectFile')
ALTER TABLE [dbo].[ProjectFile] ADD [__tenant_user] [nvarchar] (128) NOT NULL CONSTRAINT [DF__PROJECTFILE___TENANT_USER] DEFAULT (suser_sname())

GO

--APPEND AUDIT TRAIL CREATE FOR TABLE [ProjectType]
if exists(select * from sys.tables where name = 'ProjectType') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedBy' and t.name = 'ProjectType')
ALTER TABLE [dbo].[ProjectType] ADD [CreatedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'ProjectType') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedDate' and t.name = 'ProjectType')
ALTER TABLE [dbo].[ProjectType] ADD [CreatedDate] [DateTime2] CONSTRAINT [DF__PROJECTTYPE_CREATEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL MODIFY FOR TABLE [ProjectType]
if exists(select * from sys.tables where name = 'ProjectType') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedBy' and t.name = 'ProjectType')
ALTER TABLE [dbo].[ProjectType] ADD [ModifiedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'ProjectType') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedDate' and t.name = 'ProjectType')
ALTER TABLE [dbo].[ProjectType] ADD [ModifiedDate] [DateTime2] CONSTRAINT [DF__PROJECTTYPE_MODIFIEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL TIMESTAMP FOR TABLE [ProjectType]
if exists(select * from sys.tables where name = 'ProjectType') and not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'Timestamp' and o.name = 'ProjectType')
ALTER TABLE [dbo].[ProjectType] ADD [Timestamp] [ROWVERSION] NOT NULL
GO

GO

--APPEND AUDIT TRAIL CREATE FOR TABLE [TenantMaster]
if exists(select * from sys.tables where name = 'TenantMaster') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedBy' and t.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [CreatedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'TenantMaster') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedDate' and t.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [CreatedDate] [DateTime2] CONSTRAINT [DF__TENANTMASTER_CREATEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL MODIFY FOR TABLE [TenantMaster]
if exists(select * from sys.tables where name = 'TenantMaster') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedBy' and t.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [ModifiedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'TenantMaster') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedDate' and t.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [ModifiedDate] [DateTime2] CONSTRAINT [DF__TENANTMASTER_MODIFIEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL TIMESTAMP FOR TABLE [TenantMaster]
if exists(select * from sys.tables where name = 'TenantMaster') and not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'Timestamp' and o.name = 'TenantMaster')
ALTER TABLE [dbo].[TenantMaster] ADD [Timestamp] [ROWVERSION] NOT NULL
GO

GO

--APPEND AUDIT TRAIL CREATE FOR TABLE [UserAccount]
if exists(select * from sys.tables where name = 'UserAccount') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedBy' and t.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [CreatedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'UserAccount') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'CreatedDate' and t.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [CreatedDate] [DateTime2] CONSTRAINT [DF__USERACCOUNT_CREATEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL MODIFY FOR TABLE [UserAccount]
if exists(select * from sys.tables where name = 'UserAccount') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedBy' and t.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [ModifiedBy] [NVarchar] (50) NULL
if exists(select * from sys.tables where name = 'UserAccount') and not exists (select * from sys.columns c inner join sys.tables t on c.object_id = t.object_id where c.name = 'ModifiedDate' and t.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [ModifiedDate] [DateTime2] CONSTRAINT [DF__USERACCOUNT_MODIFIEDDATE] DEFAULT sysdatetime() NULL
GO

--APPEND AUDIT TRAIL TIMESTAMP FOR TABLE [UserAccount]
if exists(select * from sys.tables where name = 'UserAccount') and not exists (select * from sys.columns c inner join sys.objects o on c.object_id = o.object_id where c.name = 'Timestamp' and o.name = 'UserAccount')
ALTER TABLE [dbo].[UserAccount] ADD [Timestamp] [ROWVERSION] NOT NULL
GO

GO

--##SECTION END [AUDIT TRAIL CREATE]

--##SECTION BEGIN [AUDIT TRAIL REMOVE]

--##SECTION END [AUDIT TRAIL REMOVE]

--##SECTION BEGIN [RENAME PK]

--RENAME EXISTING PRIMARY KEYS IF NECESSARY
DECLARE @pkfixProject varchar(500)
SET @pkfixProject = (SELECT top 1 i.name AS IndexName FROM sys.indexes AS i WHERE i.is_primary_key = 1 AND OBJECT_NAME(i.OBJECT_ID) = 'Project')
if @pkfixProject <> '' and (BINARY_CHECKSUM(@pkfixProject) <> BINARY_CHECKSUM('PK_PROJECT')) exec('sp_rename '''+@pkfixProject+''', ''PK_PROJECT''')
DECLARE @pkfixProjectFile varchar(500)
SET @pkfixProjectFile = (SELECT top 1 i.name AS IndexName FROM sys.indexes AS i WHERE i.is_primary_key = 1 AND OBJECT_NAME(i.OBJECT_ID) = 'ProjectFile')
if @pkfixProjectFile <> '' and (BINARY_CHECKSUM(@pkfixProjectFile) <> BINARY_CHECKSUM('PK_PROJECTFILE')) exec('sp_rename '''+@pkfixProjectFile+''', ''PK_PROJECTFILE''')
DECLARE @pkfixProjectType varchar(500)
SET @pkfixProjectType = (SELECT top 1 i.name AS IndexName FROM sys.indexes AS i WHERE i.is_primary_key = 1 AND OBJECT_NAME(i.OBJECT_ID) = 'ProjectType')
if @pkfixProjectType <> '' and (BINARY_CHECKSUM(@pkfixProjectType) <> BINARY_CHECKSUM('PK_PROJECTTYPE')) exec('sp_rename '''+@pkfixProjectType+''', ''PK_PROJECTTYPE''')
DECLARE @pkfixTenantMaster varchar(500)
SET @pkfixTenantMaster = (SELECT top 1 i.name AS IndexName FROM sys.indexes AS i WHERE i.is_primary_key = 1 AND OBJECT_NAME(i.OBJECT_ID) = 'TenantMaster')
if @pkfixTenantMaster <> '' and (BINARY_CHECKSUM(@pkfixTenantMaster) <> BINARY_CHECKSUM('PK_TENANTMASTER')) exec('sp_rename '''+@pkfixTenantMaster+''', ''PK_TENANTMASTER''')
DECLARE @pkfixUserAccount varchar(500)
SET @pkfixUserAccount = (SELECT top 1 i.name AS IndexName FROM sys.indexes AS i WHERE i.is_primary_key = 1 AND OBJECT_NAME(i.OBJECT_ID) = 'UserAccount')
if @pkfixUserAccount <> '' and (BINARY_CHECKSUM(@pkfixUserAccount) <> BINARY_CHECKSUM('PK_USERACCOUNT')) exec('sp_rename '''+@pkfixUserAccount+''', ''PK_USERACCOUNT''')
GO

--##SECTION END [RENAME PK]

--##SECTION BEGIN [DROP PK]

--##SECTION END [DROP PK]

--##SECTION BEGIN [CREATE PK]

--PRIMARY KEY FOR TABLE [Project]
if not exists(select * from sys.objects where name = 'PK_PROJECT' and type = 'PK')
ALTER TABLE [dbo].[Project] WITH NOCHECK ADD 
CONSTRAINT [PK_PROJECT] PRIMARY KEY CLUSTERED
(
	[ProjectId]
)
GO
--PRIMARY KEY FOR TABLE [ProjectFile]
if not exists(select * from sys.objects where name = 'PK_PROJECTFILE' and type = 'PK')
ALTER TABLE [dbo].[ProjectFile] WITH NOCHECK ADD 
CONSTRAINT [PK_PROJECTFILE] PRIMARY KEY CLUSTERED
(
	[ProjectFileId]
)
GO
--PRIMARY KEY FOR TABLE [ProjectType]
if not exists(select * from sys.objects where name = 'PK_PROJECTTYPE' and type = 'PK')
ALTER TABLE [dbo].[ProjectType] WITH NOCHECK ADD 
CONSTRAINT [PK_PROJECTTYPE] PRIMARY KEY CLUSTERED
(
	[ProjectTypeId]
)
GO
--PRIMARY KEY FOR TABLE [TenantMaster]
if not exists(select * from sys.objects where name = 'PK_TENANTMASTER' and type = 'PK')
ALTER TABLE [dbo].[TenantMaster] WITH NOCHECK ADD 
CONSTRAINT [PK_TENANTMASTER] PRIMARY KEY CLUSTERED
(
	[TenantId]
)
GO
--PRIMARY KEY FOR TABLE [UserAccount]
if not exists(select * from sys.objects where name = 'PK_USERACCOUNT' and type = 'PK')
ALTER TABLE [dbo].[UserAccount] WITH NOCHECK ADD 
CONSTRAINT [PK_USERACCOUNT] PRIMARY KEY CLUSTERED
(
	[UserId]
)
GO
--##SECTION END [CREATE PK]

--##SECTION BEGIN [AUDIT TABLES PK]

--DROP PRIMARY KEY FOR TABLE [__AUDIT__PROJECT]
if exists(select * from sys.objects where name = 'PK___AUDIT__PROJECT' and type = 'PK' and type_desc = 'PRIMARY_KEY_CONSTRAINT')
ALTER TABLE [dbo].[__AUDIT__PROJECT] DROP CONSTRAINT [PK___AUDIT__PROJECT]
GO

--DROP PRIMARY KEY FOR TABLE [__AUDIT__PROJECTFILE]
if exists(select * from sys.objects where name = 'PK___AUDIT__PROJECTFILE' and type = 'PK' and type_desc = 'PRIMARY_KEY_CONSTRAINT')
ALTER TABLE [dbo].[__AUDIT__PROJECTFILE] DROP CONSTRAINT [PK___AUDIT__PROJECTFILE]
GO

--DROP PRIMARY KEY FOR TABLE [__AUDIT__PROJECTTYPE]
if exists(select * from sys.objects where name = 'PK___AUDIT__PROJECTTYPE' and type = 'PK' and type_desc = 'PRIMARY_KEY_CONSTRAINT')
ALTER TABLE [dbo].[__AUDIT__PROJECTTYPE] DROP CONSTRAINT [PK___AUDIT__PROJECTTYPE]
GO

--DROP PRIMARY KEY FOR TABLE [__AUDIT__TENANTMASTER]
if exists(select * from sys.objects where name = 'PK___AUDIT__TENANTMASTER' and type = 'PK' and type_desc = 'PRIMARY_KEY_CONSTRAINT')
ALTER TABLE [dbo].[__AUDIT__TENANTMASTER] DROP CONSTRAINT [PK___AUDIT__TENANTMASTER]
GO

--DROP PRIMARY KEY FOR TABLE [__AUDIT__USERACCOUNT]
if exists(select * from sys.objects where name = 'PK___AUDIT__USERACCOUNT' and type = 'PK' and type_desc = 'PRIMARY_KEY_CONSTRAINT')
ALTER TABLE [dbo].[__AUDIT__USERACCOUNT] DROP CONSTRAINT [PK___AUDIT__USERACCOUNT]
GO

--##SECTION END [AUDIT TABLES PK]

--##SECTION BEGIN [CREATE INDEXES]

--##SECTION END [CREATE INDEXES]

--##SECTION BEGIN [TENANT INDEXES]

--INDEX FOR TABLE [Project] TENANT COLUMN: [__tenant_user]
if not exists(select * from sys.indexes where name = 'IDX_PROJECT___TENANT_USER')
CREATE NONCLUSTERED INDEX [IDX_PROJECT___TENANT_USER] ON [dbo].[Project] ([__tenant_user])
GO

--INDEX FOR TABLE [ProjectFile] TENANT COLUMN: [__tenant_user]
if not exists(select * from sys.indexes where name = 'IDX_PROJECTFILE___TENANT_USER')
CREATE NONCLUSTERED INDEX [IDX_PROJECTFILE___TENANT_USER] ON [dbo].[ProjectFile] ([__tenant_user])
GO

--##SECTION END [TENANT INDEXES]

--##SECTION BEGIN [REMOVE DEFAULTS]

--BEGIN DEFAULTS FOR TABLE [Project]
DECLARE @defaultName varchar(max)
--DROP CONSTRAINT FOR '[Project].[Name]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'Project' and c.name = 'Name')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[Project] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[Project].[ProjectId]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'Project' and c.name = 'ProjectId')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[Project] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[Project].[ProjectTypeId]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'Project' and c.name = 'ProjectTypeId')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[Project] DROP CONSTRAINT ' + @defaultName)
--END DEFAULTS FOR TABLE [Project]
GO

--BEGIN DEFAULTS FOR TABLE [ProjectFile]
DECLARE @defaultName varchar(max)
--DROP CONSTRAINT FOR '[ProjectFile].[FileName]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'ProjectFile' and c.name = 'FileName')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[ProjectFile] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[ProjectFile].[ProjectFileId]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'ProjectFile' and c.name = 'ProjectFileId')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[ProjectFile] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[ProjectFile].[ProjectId]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'ProjectFile' and c.name = 'ProjectId')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[ProjectFile] DROP CONSTRAINT ' + @defaultName)
--END DEFAULTS FOR TABLE [ProjectFile]
GO

--BEGIN DEFAULTS FOR TABLE [ProjectType]
DECLARE @defaultName varchar(max)
--DROP CONSTRAINT FOR '[ProjectType].[Name]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'ProjectType' and c.name = 'Name')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[ProjectType] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[ProjectType].[ProjectTypeId]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'ProjectType' and c.name = 'ProjectTypeId')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[ProjectType] DROP CONSTRAINT ' + @defaultName)
--END DEFAULTS FOR TABLE [ProjectType]
GO

--BEGIN DEFAULTS FOR TABLE [TenantMaster]
DECLARE @defaultName varchar(max)
--DROP CONSTRAINT FOR '[TenantMaster].[DbPassword]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'TenantMaster' and c.name = 'DbPassword')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[TenantMaster] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[TenantMaster].[DbUserName]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'TenantMaster' and c.name = 'DbUserName')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[TenantMaster] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[TenantMaster].[TenantId]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'TenantMaster' and c.name = 'TenantId')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[TenantMaster] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[TenantMaster].[TenantName]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'TenantMaster' and c.name = 'TenantName')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[TenantMaster] DROP CONSTRAINT ' + @defaultName)
--END DEFAULTS FOR TABLE [TenantMaster]
GO

--BEGIN DEFAULTS FOR TABLE [UserAccount]
DECLARE @defaultName varchar(max)
--DROP CONSTRAINT FOR '[UserAccount].[PasswordHash]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'UserAccount' and c.name = 'PasswordHash')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[UserAccount].[TenantId]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'UserAccount' and c.name = 'TenantId')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[UserAccount].[UserId]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'UserAccount' and c.name = 'UserId')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT ' + @defaultName)
--DROP CONSTRAINT FOR '[UserAccount].[UserName]'
SET @defaultName = (SELECT d.name FROM sys.columns c inner join sys.default_constraints d on c.column_id = d.parent_column_id and c.object_id = d.parent_object_id inner join sys.objects o on d.parent_object_id = o.object_id where o.name = 'UserAccount' and c.name = 'UserName')
if @defaultName IS NOT NULL
exec('ALTER TABLE [dbo].[UserAccount] DROP CONSTRAINT ' + @defaultName)
--END DEFAULTS FOR TABLE [UserAccount]
GO

--##SECTION END [REMOVE DEFAULTS]

--##SECTION BEGIN [CREATE DEFAULTS]

--##SECTION END [CREATE DEFAULTS]

if not exists(select * from sys.tables where [name] = '__nhydrateschema')
BEGIN
CREATE TABLE [__nhydrateschema] (
[dbVersion] [varchar] (50) NOT NULL,
[LastUpdate] [datetime] NOT NULL,
[ModelKey] [uniqueidentifier] NOT NULL,
[History] [nvarchar](max) NOT NULL
)
if not exists(select * from sys.objects where [name] = '__pk__nhydrateschema' and [type] = 'PK')
ALTER TABLE [__nhydrateschema] WITH NOCHECK ADD CONSTRAINT [__pk__nhydrateschema] PRIMARY KEY CLUSTERED ([ModelKey])
END
GO

if not exists(select * from sys.tables where name = '__nhydrateobjects')
CREATE TABLE [dbo].[__nhydrateobjects]
(
	[rowid] [bigint] IDENTITY(1,1) NOT NULL,
	[id] [uniqueidentifier] NULL,
	[name] [nvarchar](450) NOT NULL,
	[type] [varchar](10) NOT NULL,
	[schema] [nvarchar](450) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[Hash] [varchar](32) NULL,
	[ModelKey] [uniqueidentifier] NOT NULL,
)

if not exists(select * from sys.indexes where name = '__ix__nhydrateobjects_name')
CREATE NONCLUSTERED INDEX [__ix__nhydrateobjects_name] ON [dbo].[__nhydrateobjects]
(
	[name] ASC
)

if not exists(select * from sys.indexes where name = '__ix__nhydrateobjects_schema')
CREATE NONCLUSTERED INDEX [__ix__nhydrateobjects_schema] ON [dbo].[__nhydrateobjects] 
(
	[schema] ASC
)

if not exists(select * from sys.indexes where name = '__ix__nhydrateobjects_type')
CREATE NONCLUSTERED INDEX [__ix__nhydrateobjects_type] ON [dbo].[__nhydrateobjects] 
(
	[type] ASC
)

if not exists(select * from sys.indexes where name = '__ix__nhydrateobjects_modelkey')
CREATE NONCLUSTERED INDEX [__ix__nhydrateobjects_modelkey] ON [dbo].[__nhydrateobjects] 
(
	[ModelKey] ASC
)

if not exists(select * from sys.indexes where name = '__pk__nhydrateobjects')
ALTER TABLE [dbo].[__nhydrateobjects] ADD CONSTRAINT [__pk__nhydrateobjects] PRIMARY KEY CLUSTERED 
(
	[rowid] ASC
)
GO

