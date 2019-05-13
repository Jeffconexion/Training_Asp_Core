using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["valor"] = 100;

            return View();
        }
    }
}