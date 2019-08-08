using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AulaRotas.Models;
using AulaRotas.Models;

namespace AulaRotas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [ActionName("Index2")]
        public IActionResult Index(int id)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Telefone(int id)
        {
            ViewData["Telefone"] = id;
            return View();
        }

        public string Horas()
        {
            return "Horas =" + DateTime.Now;
        }

        public IActionResult DadosUsuario(int id, string nome)
        {
            UsuarioModel cliente = new UsuarioModel();

            ViewData["valor"] = id;
            ViewData["nome"] = nome;
            return View(cliente);
        }

        public IActionResult DadosUsuario2(int id, string nome)
        {

            ViewBag.data = DateTime.Now.ToString();
            ViewBag.valor = id;
            ViewBag.nome = nome;
            return View();
        }

        public IActionResult DadosUsuario3(UsuarioModel usuario)
        {

            ViewBag.data = DateTime.Now.ToString();
            ViewBag.valor = usuario.Id;
            ViewBag.nome = usuario.Nome;
            return View(usuario);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
