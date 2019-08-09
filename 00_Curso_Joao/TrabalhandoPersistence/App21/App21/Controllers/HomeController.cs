using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App21.Model;

namespace App21.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno(){  nome="Tiago"},
                new Aluno(){  nome="Marcos"},
                new Aluno(){  nome="Pato"}


            };




            return View(alunos);
        }
    }
}