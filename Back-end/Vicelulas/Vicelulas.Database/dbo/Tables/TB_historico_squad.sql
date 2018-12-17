CREATE TABLE [dbo].[TB_historico_squad] (
    [id]        UNIQUEIDENTIFIER NOT NULL,
    [descricao] VARCHAR (100)    NOT NULL,
    [data_hora] DATETIME         NOT NULL,
    [id_squad]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_TB_historico_squad_1] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TB_historico_squad_TB_squad1] FOREIGN KEY ([id_squad]) REFERENCES [dbo].[TB_squad] ([id])
);

