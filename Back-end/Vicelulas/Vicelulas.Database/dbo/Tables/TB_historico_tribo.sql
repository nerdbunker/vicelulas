CREATE TABLE [dbo].[TB_historico_tribo] (
    [id]        INT IDENTITY NOT NULL,
    [descricao] VARCHAR (100)    NOT NULL,
    [data_hora] DATETIME         NOT NULL,
    [id_tribo]  INT NOT NULL,
    CONSTRAINT [PK_TB_historico_tribo] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TB_historico_tribo_TB_tribo] FOREIGN KEY ([id_tribo]) REFERENCES [dbo].[TB_tribo] ([id])
);

