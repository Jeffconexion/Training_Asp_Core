using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App23.Models;

namespace App23.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Dados.LISTA_CLIENTE);
            
        }

        public IActionResult novoCliente()
        {
            //Apresenta o formulário para adicionar novo cliente
            return View();
        }

        [HttpPost]
        public IActionResult novoCliente(Cliente item)
        {
            //Adicionar um novo cliene a coleção
            Dados.LISTA_CLIENTE.Add(item);

            return RedirectToAction("Index");
        }
    }
}