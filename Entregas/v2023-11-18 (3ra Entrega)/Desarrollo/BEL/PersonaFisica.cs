using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class PersonaFisica : Cliente
    {
        public string DNI { get; set; }
        public string NombreApellido { get; set; }
    }
}
