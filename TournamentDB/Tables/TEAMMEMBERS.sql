CREATE TABLE [dbo].[TeamMembers]
(
	[Team_Mem_Id] INT NOT NULL PRIMARY KEY, 
    [Team_Id] INT NOT NULL, 
    [Person_Id] INT NOT NULL, 
    CONSTRAINT [FK_TeamMembers_Teams] FOREIGN KEY ([Team_Id]) REFERENCES [TEAMS]([Team_Id]),
	CONSTRAINT [FK_TeamMembers_People] FOREIGN KEY ([Person_Id]) REFERENCES [People]([Person_Id])
)
