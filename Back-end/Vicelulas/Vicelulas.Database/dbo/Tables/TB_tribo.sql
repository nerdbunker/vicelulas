CREATE TABLE [dbo].[TB_tribo] (
    [id]    INT IDENTITY NOT NULL,
	[id_mentor] INT NULL,
    [nome]  VARCHAR (50)     NOT NULL,
    [ativo] BIT              NOT NULL,
    CONSTRAINT [PK_TB_tribo] PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [FK_TB_tribo_TB_mentor] FOREIGN KEY ([id_mentor]) REFERENCES [dbo].[TB_mentor] ([id])
);

