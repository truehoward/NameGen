using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NameGen.Models;

using NameGen.Models;

namespace NameGen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NameGeneratorViewModel nameGeneratorViewModel = new Models.NameGeneratorViewModel();

            nameGeneratorViewModel.InputText = "";
            nameGeneratorViewModel.Name = "";

            return View(nameGeneratorViewModel);
        }

        [HttpPost]
        public ActionResult Index(NameGeneratorViewModel nameGeneratorViewModel)
        {
            string[] inputWords = nameGeneratorViewModel.InputText.Split(' ');
            nameGeneratorViewModel.Name = "test name " + inputWords[0] + " " + (new Random().Next()).ToString();

            return View(nameGeneratorViewModel);
        }

    }
}