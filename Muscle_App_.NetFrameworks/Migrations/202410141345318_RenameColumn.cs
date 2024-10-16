namespace Muscle_App_.NetFrameworks.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameColumn : DbMigration
    {
        public override void Up()
        {
            RenameColumn("public.category", "Id", "id");
            RenameColumn("public.category", "User_Id", "user_id");
            RenameColumn("public.user", "Id", "id");
        }
        
        public override void Down()
        {
            RenameColumn("public.category", "Id", "id");
            RenameColumn("public.category", "User_Id", "user_id");
            RenameColumn("public.user", "Id", "id");
        }
    }
}
