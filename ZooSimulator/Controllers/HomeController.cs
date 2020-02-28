using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooSimulator.Models;
using ZooSimulator.ViewModel;

namespace ZooSimulator.Controllers
{
    public class HomeController : Controller
    {
         
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

        
    }
}