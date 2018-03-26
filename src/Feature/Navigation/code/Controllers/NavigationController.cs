using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelLogicx.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult TopMenu()
        {
            return View();
        }
    }
}