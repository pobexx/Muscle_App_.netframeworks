using Muscle_App_.NetFrameworks.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Mime;
using System.Web;

namespace Muscle_App_.NetFrameworks.Utils
{
    public  static class UserSamples
    {
        public const string RawPass = "Sample1234";
        public static void Upsert(MuscleDbContext context)
        {
            var newUsers =NewUsers();
            foreach (var user in newUsers)
            {
                var old = context.Users.FirstOrDefault(u => u.Id == user.Id);
                if (old == null) context.Users.Add(user);
                else Update(old, user);
            }
            context.SaveChanges();
        }

        public static IEnumerable<User> NewUsers()
        {
            var now = DateTime.Now;
            var password = HashService.GetHashForPassword(RawPass);
            return new List<User>
            {
                new User { Id = 1,Name = "Master", Username = "Master", EmailAddress = "master.example.com", Password = password, CreatedDatetime = now, Deleted = false},
                new User { Id = 2,Name = "Begginer", Username = "Begginer", EmailAddress = "begginer@example.com", Password = password, CreatedDatetime = now, Deleted = false },
                new User { Id = 3,Name = "Yuki", Username = "Pobe", EmailAddress = "y@example.com", Password = password, CreatedDatetime = now, Deleted = false }
            };
        }

        public static void Update(User target, User source)
        {
            target.Name = source.Name;
            target.EmailAddress = source.EmailAddress;
            target.Password = source.Password;
            target.CreatedDatetime = source.CreatedDatetime;
            target.Deleted = source.Deleted;
        }
    }
}