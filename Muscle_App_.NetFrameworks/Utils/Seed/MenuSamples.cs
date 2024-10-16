using Muscle_App_.NetFrameworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Muscle_App_.NetFrameworks.Utils
{
    public static class MenuSamples
    {
        public static void Upsert(MuscleDbContext context)
        {
            var newMenus = NewMenus();
            foreach (var Menu in newMenus)
            {
                var anyone = context.Menus.FirstOrDefault(u => u.Id == Menu.Id);
                if (anyone == null) context.Menus.Add(Menu);
                else Update(anyone, Menu);
            }
            context.SaveChanges();
        }

        public static IEnumerable<Menu> NewMenus()
        {
            var now = DateTime.Now;
            return new List<Menu>
            {
                new Menu { Id = 1, UserId = 1,CategoryId = 1,Item = "スクワット", Common = true, CreatedDatetime = now, Deleted = false},
                new Menu { Id = 1, UserId = 1,CategoryId = 2,Item = "ショルダープレス", Common = true, CreatedDatetime = now, Deleted = false},
                new Menu { Id = 1, UserId = 1,CategoryId = 1,Item = "アームカール", Common = true, CreatedDatetime = now, Deleted = false},
                new Menu { Id = 1, UserId = 1,CategoryId = 3,Item = "ベンチプレス", Common = true, CreatedDatetime = now, Deleted = false},
                new Menu { Id = 1, UserId = 1,CategoryId = 1,Item = "懸垂", Common = true, CreatedDatetime = now, Deleted = false},
                new Menu { Id = 1, UserId = 1,CategoryId = 1,Item = "ドラゴンフライ", Common = true, CreatedDatetime = now, Deleted = false},
            };
        }

        public static void Update(Menu target, Menu source)
        {
            target.UserId = source.UserId;
            target.CategoryId = source.CategoryId;
            target.Item = source.Item;
            target.Common = source.Common;
            target.CreatedDatetime = source.CreatedDatetime;
            target.Deleted = source.Deleted;
        }
    }
}