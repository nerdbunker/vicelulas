CREATE TABLE [dbo].[TB_unidade] (
    [id]          INT IDENTITY NOT NULL,
    [id_endereco] INT NOT NULL,
    [nome]        VARCHAR (50)     NOT NULL,
    CONSTRAINT [PK_TB_unidade] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TB_unidade_TB_endereco] FOREIGN KEY ([id_endereco]) REFERENCES [dbo].[TB_endereco] ([id])
);

