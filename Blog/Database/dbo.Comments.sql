CREATE TABLE [dbo].[Comments]
(
	[ID] INT NOT NULL , 
    [PostID] INT NOT NULL, 
    [DateTime] DATETIME NOT NULL, 
    [Author] NVARCHAR(128) NOT NULL, 
    [Body] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_Comments_Posts] FOREIGN KEY ([PostID]) REFERENCES [Posts]([ID]), 
)
