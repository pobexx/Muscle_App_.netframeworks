namespace Muscle_App_.NetFrameworks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCommonColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.category", "common", c => c.Boolean(nullable: false));
            AddColumn("public.menu", "common", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("public.menu", "common");
            DropColumn("public.category", "common");
        }
    }
}
