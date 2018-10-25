namespace CanjeLibros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exchanges",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        idUser1 = c.Int(nullable: false),
                        idUser2 = c.Int(nullable: false),
                        idBook1 = c.Int(nullable: false),
                        idBook2 = c.Int(nullable: false),
                        done = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exchanges");
        }
    }
}
