using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App5.Models;
using Microsoft.AspNetCore.Mvc;

namespace App5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = "teste";
            novoCliente.apelido = "vamos nessa";
            novoCliente.telefone = "333-333";


            return View(novoCliente);
        }
    }
}