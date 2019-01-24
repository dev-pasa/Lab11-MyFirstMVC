using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers 
{
    public class HomeController : Controller
    {

        [HttpGet]
        public ViewResult Index()
        {   
            return View();
        }

        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            return RedirectToAction("Result", new { startYear, endYear });
        }

        [HttpGet]
        public ViewResult Result(int startYear, int endYear)
        {
            List<TimePerson> persons = TimePerson.Search(startYear, endYear);
            return View(persons);
        }
    }
}
