CREATE TABLE [dbo].[Feedback] (
    [feedback_id] INT            IDENTITY (1, 1) NOT NULL,
    [user_id]     INT            NOT NULL,
    [subject]     NVARCHAR (100) NULL,
    [feedback]    NVARCHAR (MAX) NULL,
    [created_at]  DATETIME       DEFAULT (getdate()) NULL,
    [updated_at]  DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([feedback_id] ASC),
    CONSTRAINT [FK_Feedback_Users] FOREIGN KEY ([user_id]) REFERENCES [dbo].[Users] ([user_id])
);