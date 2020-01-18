--DO NOT MODIFY THIS FILE. IT IS ALWAYS OVERWRITTEN ON GENERATION.
--Audit Triggers

--##SECTION BEGIN [AUDIT TRIGGERS]

--DROP ANY AUDIT TRIGGERS FOR [dbo].[Project]
if exists(select * from sys.objects where name = '__TR_Project__INSERT' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_Project__INSERT]
GO
if exists(select * from sys.objects where name = '__TR_Project__UPDATE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_Project__UPDATE]
GO
if exists(select * from sys.objects where name = '__TR_Project__DELETE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_Project__DELETE]
GO

--DROP ANY AUDIT TRIGGERS FOR [dbo].[ProjectFile]
if exists(select * from sys.objects where name = '__TR_ProjectFile__INSERT' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_ProjectFile__INSERT]
GO
if exists(select * from sys.objects where name = '__TR_ProjectFile__UPDATE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_ProjectFile__UPDATE]
GO
if exists(select * from sys.objects where name = '__TR_ProjectFile__DELETE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_ProjectFile__DELETE]
GO

--DROP ANY AUDIT TRIGGERS FOR [dbo].[ProjectType]
if exists(select * from sys.objects where name = '__TR_ProjectType__INSERT' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_ProjectType__INSERT]
GO
if exists(select * from sys.objects where name = '__TR_ProjectType__UPDATE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_ProjectType__UPDATE]
GO
if exists(select * from sys.objects where name = '__TR_ProjectType__DELETE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_ProjectType__DELETE]
GO

--DROP ANY AUDIT TRIGGERS FOR [dbo].[TenantMaster]
if exists(select * from sys.objects where name = '__TR_TenantMaster__INSERT' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_TenantMaster__INSERT]
GO
if exists(select * from sys.objects where name = '__TR_TenantMaster__UPDATE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_TenantMaster__UPDATE]
GO
if exists(select * from sys.objects where name = '__TR_TenantMaster__DELETE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_TenantMaster__DELETE]
GO

--DROP ANY AUDIT TRIGGERS FOR [dbo].[UserAccount]
if exists(select * from sys.objects where name = '__TR_UserAccount__INSERT' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_UserAccount__INSERT]
GO
if exists(select * from sys.objects where name = '__TR_UserAccount__UPDATE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_UserAccount__UPDATE]
GO
if exists(select * from sys.objects where name = '__TR_UserAccount__DELETE' AND type = 'TR')
DROP TRIGGER [dbo].[__TR_UserAccount__DELETE]
GO

--##SECTION END [AUDIT TRIGGERS]

