CREATE TABLE [dbo].[TB_squad] (
    [id]       UNIQUEIDENTIFIER NOT NULL,
    [id_tribo] UNIQUEIDENTIFIER NULL,
    [nome]     VARCHAR (50)     NOT NULL,
    [ativo]    BIT              NOT NULL,
    CONSTRAINT [PK_TB_squad] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TB_squad_TB_tribo] FOREIGN KEY ([id_tribo]) REFERENCES [dbo].[TB_tribo] ([id])
);

