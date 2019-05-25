using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult WelcomeMat(string UserName, string Email, string Password, string PersonalWeb, string digitz)
        {
            Models.User user = new Models.User();
            user.UserName = UserName;
            user.Email = Email;
            user.Password = Password;
            user.PersonalWeb = PersonalWeb;
            user.Digitz = digitz;
            return View(user);

        }

        //public ActionResult SummaryPage(string UserName, string Email, string Password, string PersonalWeb, string digitz)
        //{

        //    Models.User user = new Models.User();
        //    user.UserName = UserName;
        //    user.Email = Email;
        //    user.Password = Password;
        //    user.PersonalWeb = PersonalWeb;
        //    user.Digitz = digitz;
        //    return View(user);
        //}
    }
}