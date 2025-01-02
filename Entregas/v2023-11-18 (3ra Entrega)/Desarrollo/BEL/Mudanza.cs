using System;
using System.Collections.Generic;

using ABS;

namespace BEL
{
    // Clase auxiliar
    public class Insumo
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }

    // Clase principal
    public class Mudanza : IID
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Camion Camion { get; set; }
        public Empleado Chofer { get; set; }
        public List<Empleado> Estibadores { get; set; }
        public List<Insumo> Insumos { get; set; }

        // *** FK (Clave Foránea) ***
        public int OrdenID { get; set; }
    }
}
