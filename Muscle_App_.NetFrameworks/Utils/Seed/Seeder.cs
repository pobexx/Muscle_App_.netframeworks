using Muscle_App_.NetFrameworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muscle_App_.NetFrameworks.Utils
{
    public static class Seeder
    {
        public static void BeginSeeding(MuscleDbContext context)
        {
            UserSamples.Upsert(context);
            MenuSamples.Upsert(context);
            CategorySamples.Upsert(context);
            AchivementSamples.Upsert(context);
        }
    }
}