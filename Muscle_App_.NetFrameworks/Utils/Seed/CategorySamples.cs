using Muscle_App_.NetFrameworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muscle_App_.NetFrameworks.Utils
{
    public static class CategorySamples
    {
        public static void Upsert(MuscleDbContext context)
        {
            var categories = NewCategories();

            foreach (var category in categories)
            {
                var old = context.Categories.FirstOrDefault(c => c.Id == category.Id);
                if (old == null)context.Categories.Add(category);
                else Update(old, category);
            }
            context.SaveChanges();
        }
        public static IEnumerable<Category> NewCategories()
        {
            var now = DateTime.Now;
            return new List<Category>
            {
                new Category {Id = 1, UserId = 1, Parts = "脚", Common = true, CreatedDatetime = now, Deleted = false},
                new Category {Id = 2, UserId = 1, Parts = "肩", Common = true, CreatedDatetime = now, Deleted = false},
                new Category {Id = 3, UserId = 1, Parts = "腕", Common = true, CreatedDatetime = now, Deleted = false},
                new Category {Id = 4, UserId = 1, Parts = "胸", Common = true, CreatedDatetime = now, Deleted = false},
                new Category {Id = 5, UserId = 1, Parts = "背中", Common = true, CreatedDatetime = now, Deleted = false},
                new Category {Id = 6, UserId = 1, Parts = "腹", Common = true, CreatedDatetime = now, Deleted = false},

            };
        }

        public static void Update(Category target, Category source)
        {
            target.UserId = source.UserId;
            target.Parts = source.Parts;
            target.Common = source.Common;
            target.CreatedDatetime = source.CreatedDatetime;
            target.Deleted = source.Deleted;
        }
    }
}