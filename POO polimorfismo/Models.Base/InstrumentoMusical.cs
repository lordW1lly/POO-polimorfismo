using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_polimorfismo.Models.Base
{
    public abstract class InstrumentoMusical
    {
        public string Nombre { get; set; }
        public abstract string Afinar(string Nombre);
        
    }
}
