CREATE TABLE [dbo].[Baralho]
(
	[CodBaralho] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NomeBaralho] NVARCHAR(50) NOT NULL, 
    [CodUsuario] INT NOT NULL, 
    CONSTRAINT [FK_Table_Usuario] FOREIGN KEY ([CodUsuario]) REFERENCES [Usuario]([CodUsuario]) 
)
