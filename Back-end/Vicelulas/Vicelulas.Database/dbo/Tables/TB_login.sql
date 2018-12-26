CREATE TABLE [dbo].[TB_login] (
    [id]       INT IDENTITY NOT NULL,
    [username] VARCHAR (15)     NOT NULL,
    [password] VARCHAR (8)      NOT NULL,
    CONSTRAINT [PK_TB_login] PRIMARY KEY CLUSTERED ([id] ASC)
);

