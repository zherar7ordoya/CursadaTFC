using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class PersonaJuridica : Cliente
    {
        public string CUIT { get; set; }
        public string RazonSocial { get; set; }
    }
}
