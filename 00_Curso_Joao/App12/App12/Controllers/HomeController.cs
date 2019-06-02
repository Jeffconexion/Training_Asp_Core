using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App12.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home/Index")]
        [Route("Home/aaa")]
        public string Index()
        {
            return "Estou no INDEX";
        }

        [Route("Home/ppp/{id}")]
        public string acao1(int id)
        {
            return "Estou na acao 1 = "+id;
        }

        [Route("home/post")]
        public string acao2()
        {
            return "estou na acao 2";
        }
        [Route("home/valor/{nome?}/{sobrenome?}")]
        public string valor(string nome, string sobrenome)
        {
            return " Valor:"+nome+" "+ sobrenome;
        }
    }
}