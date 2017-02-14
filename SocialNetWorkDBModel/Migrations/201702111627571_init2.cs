namespace SocialNetWorkDBModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserDatas", "ProfessionId", "dbo.Professions");
            DropIndex("dbo.UserDatas", new[] { "ProfessionId" });
            RenameColumn(table: "dbo.UserDatas", name: "ProfessionId", newName: "Profession_ProfessionId");
            AlterColumn("dbo.UserDatas", "Profession_ProfessionId", c => c.Int());
            CreateIndex("dbo.UserDatas", "Profession_ProfessionId");
            AddForeignKey("dbo.UserDatas", "Profession_ProfessionId", "dbo.Professions", "ProfessionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserDatas", "Profession_ProfessionId", "dbo.Professions");
            DropIndex("dbo.UserDatas", new[] { "Profession_ProfessionId" });
            AlterColumn("dbo.UserDatas", "Profession_ProfessionId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.UserDatas", name: "Profession_ProfessionId", newName: "ProfessionId");
            CreateIndex("dbo.UserDatas", "ProfessionId");
            AddForeignKey("dbo.UserDatas", "ProfessionId", "dbo.Professions", "ProfessionId", cascadeDelete: true);
        }
    }
}
