using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App9.Models
{
    public class Humano
    {
        public string Nome { set; get; }
        public string Apelido { set; get; }
    }

    public class Automovel
    {
        public string Marca { set; get; }
        public string Cor { set; get; }
    }

    public class box
    {
        public Humano humano { set; get; }
        public Automovel automovel { set; get; }
    }
}
