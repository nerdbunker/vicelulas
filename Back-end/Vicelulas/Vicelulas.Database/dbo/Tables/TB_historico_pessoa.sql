CREATE TABLE [dbo].[TB_historico_pessoa] (
    [id]        INT IDENTITY NOT NULL,
    [descricao] VARCHAR (100)    NOT NULL,
    [data_hora] DATETIME         NOT NULL,
    [id_pessoa] INT NOT NULL,
    CONSTRAINT [PK_TB_historico_pessoa] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TB_historico_pessoa_TB_pessoa] FOREIGN KEY ([id_pessoa]) REFERENCES [dbo].[TB_pessoa] ([id])
);

