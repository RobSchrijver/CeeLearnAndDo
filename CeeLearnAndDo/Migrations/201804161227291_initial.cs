namespace CeeLearnAndDo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        AnswerDescription = c.String(),
                        SiteDisplay = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleDescription = c.String(),
                        ArticleName = c.String(),
                        ArticlePhoto = c.String(),
                        ArticleVideo = c.String(),
                        ArticleText = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactAdmins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Name = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageLink = c.String(),
                        ArticleId = c.Int(nullable: false),
                        ReferenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .ForeignKey("dbo.References", t => t.ReferenceId, cascadeDelete: true)
                .Index(t => t.ArticleId)
                .Index(t => t.ReferenceId);
            
            CreateTable(
                "dbo.References",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReferenceTitle = c.String(),
                        ReferenceInfo = c.String(),
                        ReferenceImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionTitle = c.String(),
                        QuestionDescription = c.String(),
                        CustomerEmail = c.String(),
                        AppUserId = c.Int(nullable: false),
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUser_Id)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Reactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReactionTitle = c.String(),
                        ReactionDescription = c.String(),
                        ArticleId = c.Int(nullable: false),
                        AppUserId = c.Int(nullable: false),
                        AppUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AppUser_Id)
                .ForeignKey("dbo.Articles", t => t.ArticleId, cascadeDelete: true)
                .Index(t => t.ArticleId)
                .Index(t => t.AppUser_Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VideoLink = c.String(),
                        ReferenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.References", t => t.ReferenceId, cascadeDelete: true)
                .Index(t => t.ReferenceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "ReferenceId", "dbo.References");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Reactions", "ArticleId", "dbo.Articles");
            DropForeignKey("dbo.Reactions", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Questions", "AppUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Images", "ReferenceId", "dbo.References");
            DropForeignKey("dbo.Images", "ArticleId", "dbo.Articles");
            DropIndex("dbo.Videos", new[] { "ReferenceId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Reactions", new[] { "AppUser_Id" });
            DropIndex("dbo.Reactions", new[] { "ArticleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Questions", new[] { "AppUser_Id" });
            DropIndex("dbo.Images", new[] { "ReferenceId" });
            DropIndex("dbo.Images", new[] { "ArticleId" });
            DropTable("dbo.Videos");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Reactions");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Questions");
            DropTable("dbo.References");
            DropTable("dbo.Images");
            DropTable("dbo.ContactAdmins");
            DropTable("dbo.Articles");
            DropTable("dbo.Answers");
        }
    }
}
