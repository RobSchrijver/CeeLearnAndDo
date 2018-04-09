CREATE TABLE [dbo].[Articles] (
    [Id]                 INT            IDENTITY (1, 1) NOT NULL,
    [ArticleDescription] NVARCHAR (MAX) NULL,
    [ArticleName]        NVARCHAR (MAX) NULL,
    [ArticlePhoto]       NVARCHAR (MAX) NULL,
    [ArticleVideo] NVARCHAR(MAX) NULL, 
    [ArticleText] NVARCHAR(MAX) NULL, 
    CONSTRAINT [PK_dbo.Articles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

