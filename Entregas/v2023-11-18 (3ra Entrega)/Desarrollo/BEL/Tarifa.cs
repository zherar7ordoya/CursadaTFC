using System;
using System.Collections.Generic;

using ABS;

namespace BEL
{
    // Clase auxiliar
    public class Coeficiente
    {
        public string Categoria { get; set; }
        public float Valor { get; set; }
    }

    // Clase principal
    public class Tarifa : IID
    {
        public int Id { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public float MontoKilometro { get; set; }
        public List<Coeficiente> Coeficientes { get; set; }
    }
}
