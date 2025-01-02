using System;
using System.Collections.Generic;
using System.Linq;

using ABS;

namespace BEL
{
    // Clase auxiliar
    public class Mueble
    {
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }

    // Clase principal
    public class Orden : IID
    {
        public int Id { get; set; }
        /// <summary>
        /// Solicitado, Pagado, Tránsito, Completado, Cancelado.
        /// </summary>
        public string Estado { get; set; }
        public DateTime ServicioFecha { get; set; }
        public string DireccionOrigen { get; set; }
        /// <summary>
        /// Descripción de características del lugar de carga.
        /// </summary>
        public string DescripcionLugarCarga { get; set; }
        public string DireccionDestino { get; set; }
        /// <summary>
        /// Descripción de características del lugar de descarga.
        /// </summary>
        public string DescripcionLugarDescarga { get; set; }
        public List<Mueble> Muebles { get; set; }
        public string Observaciones { get; set; }
        public int KilometrosDistancia { get; set; }
        public float Monto { get; set; }

        // *** FK (Clave Foránea) ***
        public int ClienteID { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Estado: {Estado}\n" +
                   $"Fecha: {ServicioFecha:yyyy-MM-dd}\n" +
                   $"Dirección de Origen: {DireccionOrigen}\n" +
                   $"Lugar de Carga: {DescripcionLugarCarga}\n" +
                   $"Dirección de Destino: {DireccionDestino}\n" +
                   $"Lugar de Descarga: {DescripcionLugarDescarga}\n" +
                   "Muebles:\n" + string.Join("\n", Muebles.Select(m => $"  - Cantidad: {m.Cantidad}, Descripción: {m.Descripcion}")) + "\n" +
                   $"Observaciones: {Observaciones}\n" +
                   $"Kilómetros de Distancia: {KilometrosDistancia}\n" +
                   $"Monto: {Monto:C2}\n" +
                   $"ID del Cliente: {ClienteID}";
        }
    }
}
