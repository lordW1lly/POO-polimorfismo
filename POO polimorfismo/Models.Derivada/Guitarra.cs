using POO_polimorfismo.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models.Derivada
{
    public class Guitarra : InstrumentoMusical
    {
        public override string Afinar(string Nombre)
        {
            return "Afinar Guitarra";
        }
    }
}
