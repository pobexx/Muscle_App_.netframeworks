using System.Data.Entity;

namespace Muscle_App_.NetFrameworks.Models
{
    public class MuscleDbContext: DbContext
    {
        public MuscleDbContext() : base("name=MuscleDbContext") { }

        public DbSet<User> Users { get; set; }

        //public System.Data.Entity.DbSet<Achivement> Achivements { get; set; }
    }
}