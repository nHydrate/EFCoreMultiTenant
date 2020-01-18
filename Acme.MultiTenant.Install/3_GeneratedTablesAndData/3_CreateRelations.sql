--DO NOT MODIFY THIS FILE. IT IS ALWAYS OVERWRITTEN ON GENERATION.
--Relations

--##SECTION BEGIN [RELATIONS]

--FOREIGN KEY RELATIONSHIP [ProjectType] -> [Project] ([ProjectType].[ProjectTypeId] -> [Project].[ProjectTypeId])
if not exists(select * from sys.objects where name = 'FK__PROJECT_PROJECTTYPE' and type = 'F')
ALTER TABLE [dbo].[Project] ADD 
CONSTRAINT [FK__PROJECT_PROJECTTYPE] FOREIGN KEY 
(
	[ProjectTypeId]
) REFERENCES [dbo].[ProjectType] (
	[ProjectTypeId]
)
GO

--FOREIGN KEY RELATIONSHIP [Project] -> [ProjectFile] ([Project].[ProjectId] -> [ProjectFile].[ProjectId])
if not exists(select * from sys.objects where name = 'FK__PROJECTFILE_PROJECT' and type = 'F')
ALTER TABLE [dbo].[ProjectFile] ADD 
CONSTRAINT [FK__PROJECTFILE_PROJECT] FOREIGN KEY 
(
	[ProjectId]
) REFERENCES [dbo].[Project] (
	[ProjectId]
)
GO

--FOREIGN KEY RELATIONSHIP [TenantMaster] -> [UserAccount] ([TenantMaster].[TenantId] -> [UserAccount].[TenantId])
if not exists(select * from sys.objects where name = 'FK__USERACCOUNT_TENANTMASTER' and type = 'F')
ALTER TABLE [dbo].[UserAccount] ADD 
CONSTRAINT [FK__USERACCOUNT_TENANTMASTER] FOREIGN KEY 
(
	[TenantId]
) REFERENCES [dbo].[TenantMaster] (
	[TenantId]
)
GO

--##SECTION END [RELATIONS]

