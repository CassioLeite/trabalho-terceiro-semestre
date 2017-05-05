CREATE TABLE [dbo].[Carta]
(
	[CodCarta] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Frente] NVARCHAR(MAX) NOT NULL, 
    [Verso] NVARCHAR(MAX) NOT NULL, 
    [CodBaralho] INT NOT NULL, 
    CONSTRAINT [FK_Table_Baralho] FOREIGN KEY ([CodBaralho]) REFERENCES [Baralho]([CodBaralho])
)
