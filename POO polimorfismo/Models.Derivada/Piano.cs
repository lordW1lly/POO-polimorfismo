using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using POO_polimorfismo.Models.Base;

namespace POO_polimorfismo.Models.Derivada
{
    public class Piano : InstrumentoMusical
    {
        public override string Afinar(string Nombre)
        {
            return "Afinando Piano";
        }
    }
}
