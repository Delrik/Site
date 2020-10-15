using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
    public class FirstProjectController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "First project";
            ViewBag.second = "active";
            return View();
        }
    }
}
