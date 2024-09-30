namespace Muscle_App_.NetFrameworks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeclareAllEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.achivement",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        menu_id = c.Int(nullable: false),
                        assist = c.Boolean(nullable: false),
                        times = c.Int(nullable: false),
                        weight = c.Single(nullable: false),
                        memo = c.String(),
                        deleted = c.Boolean(nullable: false),
                        created_datetime = c.DateTime(nullable: false),
                        updated_datetime = c.DateTime(nullable: false),
                        deleted_datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User_Id = c.Int(nullable: false),
                        parts = c.String(nullable: false),
                        deleted = c.Boolean(nullable: false),
                        created_datetime = c.DateTime(nullable: false),
                        updated_datetime = c.DateTime(nullable: false),
                        deleted_datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "public.menu",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        category_id = c.Int(nullable: false),
                        item = c.String(nullable: false),
                        deleted = c.Boolean(nullable: false),
                        created_datetime = c.DateTime(nullable: false),
                        updated_datetime = c.DateTime(nullable: false),
                        deleted_datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("public.menu");
            DropTable("public.category");
            DropTable("public.achivement");
        }
    }
}
