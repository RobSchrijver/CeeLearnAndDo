namespace CeeLearnAndDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contacts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "ArticlePhoto", c => c.String());
            AddColumn("dbo.Articles", "ArticleVideo", c => c.String());
            AddColumn("dbo.Articles", "ArticleText", c => c.String());
            DropColumn("dbo.Articles", "ArticleImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "ArticleImage", c => c.String());
            DropColumn("dbo.Articles", "ArticleText");
            DropColumn("dbo.Articles", "ArticleVideo");
            DropColumn("dbo.Articles", "ArticlePhoto");
        }
    }
}
