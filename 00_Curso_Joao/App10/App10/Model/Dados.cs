using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App10.Model
{
    public class Humano
    {
        public string Nome { set; get; }
    }

    public class Automóvel
    {
        public string TipoCarro { set; get; }
    }

    public class Dados
    {
        public Humano humano { set; get; }
        public Automóvel automovel { set; get; }
    }
}
