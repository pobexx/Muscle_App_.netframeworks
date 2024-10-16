using Muscle_App_.NetFrameworks.Models;
using Muscle_App_.NetFrameworks.Utils.WebConfigAppSettings;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace Muscle_App_.NetFrameworks.Utils
{
    public static class Seeder
    {
        public static void BeginSeeding(MuscleDbContext context)
        {
            if (SettingValues.IsActivateSeedMethod)
            {
                try
                {
                    UserSamples.Upsert(context);
                    MenuSamples.Upsert(context);
                    CategorySamples.Upsert(context);
                    //AchivementSamples.Upsert(context);
                } 
                catch (DbEntityValidationException ex)
                {
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            Console.WriteLine($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                    throw; // 必要に応じて再スローする
                }
            }
            return;
        }
    }
}