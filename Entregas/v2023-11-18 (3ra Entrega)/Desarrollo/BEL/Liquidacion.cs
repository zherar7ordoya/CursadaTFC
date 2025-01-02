using System;
using System.Collections.Generic;

using ABS;

namespace BEL
{
    // Clase auxiliar
    public class Comprobante
    {
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }
        public float Monto { get; set; }
    }

    // Clase principal
    public class Liquidacion : IID
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<Comprobante> Comprobantes { get; set; }
        public float MontoOrden { get; set; }
        /// <summary>
        /// Total de comprobantes.
        /// </summary>
        public float MontoReembolso { get; set; }
        public float Total { get; set; }

        // *** FK (Clave Foránea) ***
        public int OrdenID { get; set; }
    }
}
