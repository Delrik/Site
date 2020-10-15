using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site.Data.Interfaces;
using Site.Data.Models;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICV cv;
        private CV data;
        public HomeController(ICV iCv)
        {
            cv = iCv;
            data = cv.GetCV;
            data.Contacts = cv.Contacts(data.id);
            data.Educations = cv.Educations(data.id);
            data.Experiences = cv.Experiences(data.id);
            data.Skills = cv.Skills(data.id);
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.first = "active";
            return View(data);
        }
    }
}
