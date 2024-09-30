using System.Data.Entity;

namespace Muscle_App_.NetFrameworks.Models
{
    public class MuscleDbContext: DbContext
    {
        public MuscleDbContext() : base("name=MuscleDbContext") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Achivement> Achivements { get; set; }


    }
}