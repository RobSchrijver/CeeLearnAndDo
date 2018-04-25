namespace CeeLearnAndDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactAdmins", "AnswerDescription", c => c.String());
            AddColumn("dbo.ContactAdmins", "SiteDisplay", c => c.Boolean(nullable: false));
            DropTable("dbo.Questions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionTitle = c.String(),
                        QuestionDescription = c.String(),
                        CustomerEmail = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.ContactAdmins", "SiteDisplay");
            DropColumn("dbo.ContactAdmins", "AnswerDescription");
        }
    }
}
