using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharedCode.PagSeguro
{
    //Classe específica para definir ambiente do PagSeguro.
    public static class AmbientePagSeguro
    {
        /// <summary>
        /// Ambiente do pagseguro.
        /// </summary>
        public static bool AmbienteProducaoPagSeguro
        {
            get { return true; }
        }
    }
}
