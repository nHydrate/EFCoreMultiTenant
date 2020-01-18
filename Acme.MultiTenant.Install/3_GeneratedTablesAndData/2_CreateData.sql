--DO NOT MODIFY THIS FILE. IT IS ALWAYS OVERWRITTEN ON GENERATION.
--Static Data

--INSERT STATIC DATA FOR TABLE [ProjectType]
SET identity_insert [dbo].[ProjectType] on
if not exists(select * from [dbo].[ProjectType] where ([ProjectTypeId] = 1)) 
INSERT INTO [dbo].[ProjectType] ([Name],[ProjectTypeId]) values ('CSharp',1);
if not exists(select * from [dbo].[ProjectType] where ([ProjectTypeId] = 2)) 
INSERT INTO [dbo].[ProjectType] ([Name],[ProjectTypeId]) values ('Java',2);
if not exists(select * from [dbo].[ProjectType] where ([ProjectTypeId] = 3)) 
INSERT INTO [dbo].[ProjectType] ([Name],[ProjectTypeId]) values ('Python',3);
SET identity_insert [dbo].[ProjectType] off

GO

