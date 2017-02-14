namespace SocialNetWorkDBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Professions",
                c => new
                    {
                        ProfessionId = c.Int(nullable: false, identity: true),
                        ProfessionName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ProfessionId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 300),
                        SecondName = c.String(nullable: false, maxLength: 300),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserDatas", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        UserDataId = c.Int(nullable: false, identity: true),
                        Login = c.String(maxLength: 100),
                        Password = c.String(),
                        UserAvatarUrl = c.String(),
                        ProfessionId = c.Int(nullable: false),
                        Sex = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserDataId)
                .ForeignKey("dbo.Professions", t => t.ProfessionId, cascadeDelete: true)
                .Index(t => t.Login, unique: true, name: "UniqueName")
                .Index(t => t.ProfessionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserId", "dbo.UserDatas");
            DropForeignKey("dbo.UserDatas", "ProfessionId", "dbo.Professions");
            DropIndex("dbo.UserDatas", new[] { "ProfessionId" });
            DropIndex("dbo.UserDatas", "UniqueName");
            DropIndex("dbo.Users", new[] { "UserId" });
            DropTable("dbo.UserDatas");
            DropTable("dbo.Users");
            DropTable("dbo.Professions");
        }
    }
}
