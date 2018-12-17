CREATE TABLE [dbo].[TB_endereco] (
    [id]            INT IDENTITY NOT NULL,
    [pais]          VARCHAR (15)     NOT NULL,
    [estado]        VARCHAR (30)     NOT NULL,
    [cidade]        VARCHAR (40)     NOT NULL,
    [bairro]        VARCHAR (25)     NOT NULL,
    [logradouro]    VARCHAR (50)     NOT NULL,
    [complemento]   VARCHAR (50)     NULL,
    [numero]        INT              NOT NULL,
    [codigo_postal] VARCHAR (15)     NOT NULL,
    CONSTRAINT [PK_TB_endereco] PRIMARY KEY CLUSTERED ([id] ASC)
);

