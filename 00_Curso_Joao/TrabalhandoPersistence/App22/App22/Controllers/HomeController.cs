using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App22.Models;

namespace App22.Controllers
{
    public class HomeController : Controller
    {
        List<Cliente> lista_cliente;

        public HomeController()
        {
            lista_cliente = new List<Cliente>()
            {
                new Cliente(){ Matricula = 0, Nome = "Joao", Cargo = "Desenvolvedor" },
                new Cliente(){ Matricula = 1, Nome = "Ana", Cargo = "Analista" },
                new Cliente(){ Matricula = 2, Nome = "Carlos", Cargo = "Supervisor" }


            };
        }
        public IActionResult Index()
        {
            return View(lista_cliente);
        }

        public ViewResult Detalhes(int matricula)
        {
            return View(lista_cliente[matricula]);
        }
    }
}