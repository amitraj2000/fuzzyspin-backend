CREATE TABLE [dbo].[Users]
(
	[Id] BIGINT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(150) NULL, 
    [LastName] NVARCHAR(150) NULL, 
    [ProfilePicture] NVARCHAR(200) NULL,
	[PasswordHash]   NVARCHAR (150)     NULL,
	[Salt]      NVARCHAR (MAX)     NULL,
    [CreatedOn] DATETIMEOFFSET (7) NULL,
	[UpdatedOn] DATETIMEOFFSET (7) NULL
)
