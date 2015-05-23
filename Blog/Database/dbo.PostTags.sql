CREATE TABLE [dbo].[PostTags]
(
	[PostID] INT NOT NULL , 
    [TagID] INT NOT NULL, 
    CONSTRAINT [FK_PostTags_Posts] FOREIGN KEY ([PostID]) REFERENCES [Posts]([ID]), 
    CONSTRAINT [FK_PostTags_Tags] FOREIGN KEY ([TagID]) REFERENCES [Tags]([ID]), 
    PRIMARY KEY ([PostID])
)
