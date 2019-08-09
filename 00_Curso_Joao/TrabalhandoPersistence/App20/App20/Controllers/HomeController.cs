using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App20.Models;

namespace App20.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Clientes cliente_novo = new Clientes();
            cliente_novo.nome = "Yuri";
            cliente_novo.apelido = "Silva";

            return View(cliente_novo);
        }
    }
}