using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Muscle_App_.NetFrameworks.Models;
using System.Web.Mvc;

namespace Muscle_App_.NetFrameworks.Controllers
{
    public class BaseController : Controller
    {
        private User _loginUser;
        private string _userId;
        protected MuscleDbContext db = new MuscleDbContext();

        protected string UserId
        {
            get
            {
                if(_userId == null)
                {
                    _userId = User.Identity.Name;
                }
                return _userId;
            }
        }
        protected User LoginUser
        {
            get
            {
                if (_loginUser == null && !String.IsNullOrEmpty(UserId))
                {
                    _loginUser = db.Users.FirstOrDefault(u => u.EmailAddress == UserId);
                }
                return _loginUser;
            }
        }

        protected bool userIsExisted()
        {
            return LoginUser != null;
        }
        protected bool isLogin()
        {
            return userIsExisted()
                && User.Identity.IsAuthenticated;
        }
      

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!isLogin())
            {
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary
                    {
                        { "controller", "Login" },
                        {"action", "Index" }
                    }
                    );
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}