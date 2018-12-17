CREATE TABLE [dbo].[TB_pessoa] (
    [id]         UNIQUEIDENTIFIER NOT NULL,
    [id_login]   UNIQUEIDENTIFIER NOT NULL,
    [id_papel]   UNIQUEIDENTIFIER NOT NULL,
    [nome]       VARCHAR (50)     NOT NULL,
    [email]      VARCHAR (50)     NOT NULL,
    [ativo]      BIT              NOT NULL,
    [id_squads]  UNIQUEIDENTIFIER NULL,
    [id_unidade] UNIQUEIDENTIFIER NULL,
    [permissao]  INT              NOT NULL,
    CONSTRAINT [PK_TB_pessoa] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_TB_pessoa_TB_login] FOREIGN KEY ([id_login]) REFERENCES [dbo].[TB_login] ([id]),
    CONSTRAINT [FK_TB_pessoa_TB_papel] FOREIGN KEY ([id_papel]) REFERENCES [dbo].[TB_papel] ([id]),
    CONSTRAINT [FK_TB_pessoa_TB_squad] FOREIGN KEY ([id_squads]) REFERENCES [dbo].[TB_squad] ([id]),
    CONSTRAINT [FK_TB_pessoa_TB_unidade] FOREIGN KEY ([id_unidade]) REFERENCES [dbo].[TB_unidade] ([id])
);

