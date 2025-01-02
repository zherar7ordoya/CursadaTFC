using System;

using ABS;

namespace BEL
{
    public class Factura : IID
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public float MontoOrden { get; set; }
        public float Impuesto { get; set; }
        public float Total { get; set; }

        // *** FK (Clave Foránea) ***
        public int OrdenID { get; set; }
    }
}
