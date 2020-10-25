using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Site.Data.Interfaces;
using Site.Data.Models;
using Site.Data.ViewModels;

namespace Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICV cv;
        public HomeController(ICV iCv)
        {
            cv = iCv;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.first = "active";
            CVView data = new CVView();
            data.cv = cv.GetCV;
            data.Contacts = cv.Contacts(data.cv.id);
            data.Educations = cv.Educations(data.cv.id);
            data.Experiences = cv.Experiences(data.cv.id);
            data.Skills = cv.Skills(data.cv.id);
            return View(data);
        }
    }
}
