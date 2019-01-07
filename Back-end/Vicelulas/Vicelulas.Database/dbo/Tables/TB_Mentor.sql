CREATE TABLE [dbo].[TB_mentor] (
    [id]		INT IDENTITY NOT NULL,
    [id_pessoa] INT    NOT NULL,
    CONSTRAINT [PK_TB_Mentor] PRIMARY KEY CLUSTERED ([id] ASC),
	CONSTRAINT [FK_TB_mentor_TB_pessoa] FOREIGN KEY ([id_pessoa]) REFERENCES [dbo].[TB_pessoa] ([id])
);

