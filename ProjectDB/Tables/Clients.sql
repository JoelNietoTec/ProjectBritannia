CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FullName] NVARCHAR(200) NOT NULL, 
    [FirstName] NVARCHAR(100) NULL, 
    [LastName] NVARCHAR(100) NULL, 
    [ClientTypeId] INT NOT NULL,
	[Email] NVARCHAR(150) NULL,
	[PhoneNumber] NVARCHAR(20) NULL,
	[MobileNumber] NVARCHAR(20) NULL,
    [BirthDate] DATE NULL, 
    [LawyerId] INT NOT NULL, 
    [CreatedDate] DATETIME NOT NULL, 
    [ModifyDate] DATETIME NULL, 
    CONSTRAINT [FK_Clients_ToClientTypes] FOREIGN KEY ([ClientTypeId]) REFERENCES [ClientTypes]([Id]), 
    CONSTRAINT [FK_Clients_ToLawyers] FOREIGN KEY ([LawyerId]) REFERENCES [Lawyers]([Id])
)
