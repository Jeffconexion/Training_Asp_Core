using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app2.Models
{
    public class RespostaConvidados
    {
        public string Nome { set; get; }
        public string Email { set; get; }
        public string Telefone { set; get; }
        public bool? Presente { set; get; }
    }
}
