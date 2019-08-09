using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App19.Models;


namespace App19.Controlleres
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Cliente> lista_clientes = new List<Cliente>();
            lista_clientes.Add(new Cliente() { nome = "Marcos", apelido = "Souza" });
            lista_clientes.Add(new Cliente() { nome = "Ana", apelido = "Oliveira" });
            lista_clientes.Add(new Cliente() { nome = "Carlos", apelido = "Morgan" });

             
            return View(lista_clientes);
        }
    }
}