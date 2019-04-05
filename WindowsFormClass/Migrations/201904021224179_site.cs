namespace WindowsFormClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class site : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sites",
                c => new
                    {
                        SiteId = c.Int(nullable: false, identity: true),
                        SiteName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.SiteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sites");
        }
    }
}
