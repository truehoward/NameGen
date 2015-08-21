using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NameGen.Models;
using NameGen.Repositories;
using NameGen.Utilities;

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
            if (!string.IsNullOrEmpty(nameGeneratorViewModel.InputText))
            {
                string[] inputWords = nameGeneratorViewModel.InputText.Split(' ');
            }

            if (Request.Form["girl-button"] != null)
            {
                nameGeneratorViewModel.Name = Util.UppercaseFirst(NameRepository.AllFirstNames[(new Random().Next(NameRepository.FemaleFirstNames.Length))].Trim());
            }

            if (Request.Form["boy-button"] != null)
            {
                nameGeneratorViewModel.Name = Util.UppercaseFirst(NameRepository.AllFirstNames[(new Random().Next(NameRepository.MaleFirstNames.Length))].Trim());
            }
            return View(nameGeneratorViewModel);
        }

    }
}