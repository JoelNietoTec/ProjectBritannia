CREATE TABLE [dbo].[Lawyers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[CompanyId] INT NOT NULL,
    [Name] NVARCHAR(100) NOT NULL, 
    [LawyerTypeId] INT NOT NULL, 
    [StartDate] DATE NULL, 
    [Status] CHAR NULL, 
    CONSTRAINT [FK_Lawyers_ToCompanies] FOREIGN KEY ([CompanyId]) REFERENCES [Companies]([Id]), 
    CONSTRAINT [FK_Lawyers_ToLawyerTypes] FOREIGN KEY ([LawyerTypeId]) REFERENCES [LawyerTypes]([Id])
)
