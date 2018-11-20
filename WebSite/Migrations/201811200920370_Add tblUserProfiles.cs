namespace WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtblUserProfiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblUserProfiles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Image = c.String(nullable: false, maxLength: 255),
                        DateBirth = c.DateTime(),
                        Description = c.String(nullable: false, maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUserProfiles", "Id", "dbo.AspNetUsers");
            DropIndex("dbo.tblUserProfiles", new[] { "Id" });
            DropTable("dbo.tblUserProfiles");
        }
    }
}
