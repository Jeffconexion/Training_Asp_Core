using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app2.Models;

namespace app2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("inicio");
        }
        [HttpGet]
        public ViewResult Formulario()
        {
            return View("formulario");
        }
        [HttpPost]
        public ViewResult Formulario(RespostaConvidados resposta)
        {
            Repositorio.AdicionarResposta(resposta);
            return View("Obrigado", resposta);
        }

        public ViewResult ListaConvidados()
        {
            return View("ListaFinal", Repositorio.ListaFinal.Where(c => c.Presente == true));
        }
    } 
}
