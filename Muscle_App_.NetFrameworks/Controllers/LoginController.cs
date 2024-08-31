using Muscle_App_.NetFrameworks.Models;
using Muscle_App_.NetFrameworks.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using static Muscle_App_.NetFrameworks.Utils.WebConfigAppSettings.SettingValues;
using static Muscle_App_.NetFrameworks.Utils.HashService;

namespace Muscle_App_.NetFrameworks.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            var model = new LoginViewModel();
            if (IsDevelopmentMode)
            {
                model.IsDevelopmentMode = true;
                var db = new MuscleDbContext();
                model.Users = db.Users.ToList();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (UserAuthentication(model.Email, model.Password))
                {
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    Session["LoggedInUser"] = model.Email;

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session["LoggedInUser"] = null;
            return RedirectToAction("Login", "Login");
        }

        public bool UserAuthentication(string email,string rawPassword)
        {
            var hasPassword = GetHashForPassword(rawPassword);
            using (var db = new MuscleDbContext())
            {
                return db.Users.Any(u => u.EmailAddress == email && u.Password == hasPassword);
            }
        }
    }
}