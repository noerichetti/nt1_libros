namespace CanjeLibros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Libroes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        author = c.String(),
                        editorial = c.String(),
                        publishingDate = c.Time(nullable: false, precision: 7),
                        genre = c.Int(nullable: false),
                        synopsis = c.String(),
                        language = c.Int(nullable: false),
                        photo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Libroes");
        }
    }
}
