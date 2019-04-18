using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App4.Controllers
{
    public class HomeController : Controller
    {
        [ViewData]
        public String Texto { set; get; }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pg1()
        {
            //Utilizando ViewBag
            ViewBag.frase = "O rato roeu a roupa do rei de roma.";
            return View();
        }

        public IActionResult Pg2()
        {
            //utilizando ViewData
            ViewData["nome"] = "teste1";
            ViewData["sobreNome"] = "teste2";

            return View();
        }

        public IActionResult Pg3()
        {
            //utilizando decorete para criar uma viewData

            Texto = "o rato rueu a roupa do rei de roma";
            return View();
        }
    }
}