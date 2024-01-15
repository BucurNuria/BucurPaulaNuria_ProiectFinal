CREATE TABLE [dbo].[Person] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (MAX) NOT NULL,
    [Age]       INT            NOT NULL,
    [HairColor] NVARCHAR (MAX) NOT NULL,
    [Height]    INT            NOT NULL,
    [JobID]     INT            NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Person_Job_JobID] FOREIGN KEY ([JobID]) REFERENCES [dbo].[Job] ([ID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Person_JobID]
    ON [dbo].[Person]([JobID] ASC);

