CREATE TABLE [dbo].[TB_login] (
    [id]       INT IDENTITY NOT NULL,
    [username] VARCHAR (50)     NOT NULL,
    [password] VARCHAR (60)      NOT NULL,
    CONSTRAINT [PK_TB_login] PRIMARY KEY CLUSTERED ([id] ASC)
);

