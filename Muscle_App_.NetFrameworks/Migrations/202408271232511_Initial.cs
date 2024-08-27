namespace Muscle_App_.NetFrameworks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.user",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        username = c.String(nullable: false),
                        loginId = c.String(nullable: false),
                        password = c.String(nullable: false),
                        deleted = c.Boolean(nullable: false),
                        created_datetime = c.DateTime(nullable: false),
                        updated_datetime = c.DateTime(nullable: false),
                        deleted_datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("public.user");
        }
    }
}
