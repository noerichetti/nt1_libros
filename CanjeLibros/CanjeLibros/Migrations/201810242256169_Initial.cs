namespace CanjeLibros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        userName = c.String(),
                        name = c.String(),
                        lastName = c.String(),
                        email = c.String(),
                        password = c.String(),
                        location = c.String(),
                        phone = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
        }
    }
}
