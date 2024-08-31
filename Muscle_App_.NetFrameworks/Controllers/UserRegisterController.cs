using Muscle_App_.NetFrameworks.Models;
using Muscle_App_.NetFrameworks.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Muscle_App_.NetFrameworks.Utils.HashService;

namespace Muscle_App_.NetFrameworks.Controllers
{
    public class UserRegisterController : Controller
    {
        private MuscleDbContext db = new MuscleDbContext();
        // GET: UserRegister
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserInserterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var hashedPassword = GetHashForPassword(model.Password);
                if (!db.Users.Any(u => u.EmailAddress == model.Email && u.Password == hashedPassword))
                {
                    var user = new User
                    {
                        EmailAddress = model.Email,
                        Password = hashedPassword,
                        Name = model.Name,
                        Username = model.DisplayName,
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                    return RedirectToAction("Login","Login");
                }
                else return View();
            }
            else return View();
        }
    }
}