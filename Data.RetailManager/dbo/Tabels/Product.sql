﻿CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ProductName] NVARCHAR(300) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [RetailPrice] MONEY NOT NULL,
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LastModified] DATETIME2 NOT NULL DEFAULT getutcdate()
)
