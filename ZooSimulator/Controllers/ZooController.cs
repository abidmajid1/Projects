using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZooSimulator.Models;
using ZooSimulator.ViewModel;

namespace ZooSimulator.Controllers
{
    public class ZooController : Controller
    {
        private List<Animal> animals;

        // GET: Zoo/AnimalView
        public ActionResult AnimalView()
        {
             animals = new List<Animal>
            {
                new Monkey(),
                new Monkey(),
                new Monkey(),
                new Monkey(),
                new Monkey(),
                new Giraffe(),
                new Giraffe(),
                new Giraffe(),
                new Giraffe(),
                new Giraffe(),
                new Elephant(),
                new Elephant(),
                new Elephant(),
                new Elephant(),
                new Elephant()
            };

            var viewModel = new AnimalViewModel
            {
                Animal = animals
                
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}