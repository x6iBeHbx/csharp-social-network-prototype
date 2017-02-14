namespace SocialNetWorkDBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refactoring_db : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.UserDatas", "UniqueName");
            AddColumn("dbo.UserDatas", "UserMail", c => c.String());
            AlterColumn("dbo.Professions", "ProfessionName", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.UserDatas", "Login", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.UserDatas", "Password", c => c.String(nullable: false, maxLength: 12));
            CreateIndex("dbo.Professions", "ProfessionName", unique: true, name: "UniqueProfession");
            CreateIndex("dbo.UserDatas", "Login", unique: true, name: "UniqueName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserDatas", "UniqueName");
            DropIndex("dbo.Professions", "UniqueProfession");
            AlterColumn("dbo.UserDatas", "Password", c => c.String());
            AlterColumn("dbo.UserDatas", "Login", c => c.String(maxLength: 100));
            AlterColumn("dbo.Professions", "ProfessionName", c => c.String(nullable: false));
            DropColumn("dbo.UserDatas", "UserMail");
            CreateIndex("dbo.UserDatas", "Login", unique: true, name: "UniqueName");
        }
    }
}
