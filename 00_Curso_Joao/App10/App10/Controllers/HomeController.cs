using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App10.Model;

namespace App10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Humano pessoa = new Humano()
            {
                Nome = "Yuri"
            };

            Automóvel carro = new Automóvel()
            {
                TipoCarro = "Corola"
            };

            Dados registrarDados = new Dados()
            {
                humano = pessoa,
                automovel = carro
            };

            return View(registrarDados);
        }
    }
}