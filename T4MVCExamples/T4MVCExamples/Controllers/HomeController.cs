using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace T4MVCExamples.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public virtual ActionResult Action(int id)
        {
            return Content(id.ToString());
        }

        public virtual ActionResult RedirectToActionUsingString()
        {
            return RedirectToAction("Action", "Home", new { id = 10 });
        }

        public virtual ActionResult RedirectToActionUsingT4MVC()
        {
            return RedirectToAction(MVC.Home.Action(10));
        }

        public virtual ActionResult UseViewNameAsString()
        {
            ViewBag.ActionName = "UseViewNameAsString";

            return View("View");
        }

        public virtual ActionResult UseViewNameUsingT4MVC()
        {
            ViewBag.ActionName = ActionNames.UseViewNameUsingT4MVC; // MVC.Home.ActionNames.UseViewNameUsingT4MVC

            return View(Views.View);
        }
    }
}