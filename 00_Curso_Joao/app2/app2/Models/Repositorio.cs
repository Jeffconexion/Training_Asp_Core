using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app2.Models
{
    public static class Repositorio
    {
        private static List<RespostaConvidados> Lista = new List<RespostaConvidados>();

        public static void AdicionarResposta(RespostaConvidados resposta)
        {
            Lista.Add(resposta);
        }

        public static IEnumerable<RespostaConvidados> ListaFinal
        {
            get
            {
                return Lista;
            }
        }
    }
}
