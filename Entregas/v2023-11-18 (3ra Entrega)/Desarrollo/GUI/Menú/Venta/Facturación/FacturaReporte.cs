using BEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class FacturaReporte
    {
        public int ClienteDNI_o_CUIT {  get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteDireccion { get; set; }
        public int OrdenID { get; set; }
        public DateTime OrdenFechaServicio { get; set; }
        public string OrdenOrigen {  get; set; }
        public string OrdenDestino { get; set; }
        public int OrdenDistancia { get; set; }
        public List<Mueble> OrdenMuebles { get; set; }
        public float OrdenMonto { get; set; }
        public int FacturaID { get; set; }
        public DateTime FacturaFecha {  get; set; }
        public float FacturaImpuesto { get; set; }
        public float FacturaTotal { get; set; }
    }
}
