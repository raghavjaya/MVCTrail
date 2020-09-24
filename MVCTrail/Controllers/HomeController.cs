using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTrail.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewData["Countries"] = new List<string>() {
                "Canada",
                "Dubai",
                "India",
                "USA"
            };

            return View();
        }

        
    }
}