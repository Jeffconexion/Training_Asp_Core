using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App9.Models;
using Microsoft.AspNetCore.Mvc;

namespace App9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Humano homem = new Humano()
            {
                Nome = "Naturo",
                Apelido = "Yuzumaki"
            };

            Automovel carro = new Automovel()
            {
                Marca = "Corolla",
                Cor = "azul"
            };

            box conteiner = new box()
            {
                humano = homem,
                automovel = carro
            };

            return View(conteiner);
        }
    }
}