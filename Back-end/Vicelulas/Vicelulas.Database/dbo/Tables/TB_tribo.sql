CREATE TABLE [dbo].[TB_tribo] (
    [id]    INT IDENTITY NOT NULL,
    [nome]  VARCHAR (50)     NOT NULL,
    [ativo] BIT              NOT NULL,
    CONSTRAINT [PK_TB_tribo] PRIMARY KEY CLUSTERED ([id] ASC)
);

