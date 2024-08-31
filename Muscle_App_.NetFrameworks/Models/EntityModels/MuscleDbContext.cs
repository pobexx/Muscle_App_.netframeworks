using System.Data.Entity;

namespace Muscle_App_.NetFrameworks.Models
{
    internal class MuscleDbContext: DbContext
    {
        public MuscleDbContext() : base("name=MuscleDbContext") { }

        public DbSet<User> Users { get; set; }
    }
}