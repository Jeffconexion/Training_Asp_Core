using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App13_1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("menu_inicial");
        }

        //vai trazer meu formulário
        [HttpGet("home/novo_cliente")]
        public ViewResult novo_cliente_frm()
        {
            return View();

        }
        //vai ser executado quando submeter os dados
        [HttpPost("home/novo_cliente")]
        public string novo_cliente_gravar()
        {
            //todo mecanismo de gravação no banco de dados.
            return "Novo cliente gravado com sucesso.";
        }
    }
}