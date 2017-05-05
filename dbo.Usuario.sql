CREATE TABLE [dbo].[Usuario]
(
	[CodUsuario] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NomeUsuario] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Senha] NVARCHAR(20) NOT NULL
)
