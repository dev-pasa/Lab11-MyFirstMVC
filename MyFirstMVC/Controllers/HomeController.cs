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
        /// <summary>
        /// View the front page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult Index()
        {   
            return View();
        }

        /// <summary>
        /// Post the result in the Results page
        /// </summary>
        /// <param name="startYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(int startYear, int endYear)
        {
            return RedirectToAction("Result", new { startYear, endYear });
        }

        [HttpGet]
        public IActionResult Result(int startYear, int endYear)
        {
            //TimePerson persons = new TimePerson();
            return View(TimePerson.Search(startYear, endYear));
        }
    }
}
