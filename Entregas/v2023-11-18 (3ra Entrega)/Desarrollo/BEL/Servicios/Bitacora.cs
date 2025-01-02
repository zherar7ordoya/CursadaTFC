using ABS;



using System;

namespace BEL
{
    public partial class Bitacora : IID
    {
        public int Id { get; set; }
        public DateTime FechaHora { get; set; }
        public string Usuario { get; set; }

        /// <summary>
        /// Respaldo o Restauración
        /// </summary>
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        // Para pruebas de consola
        public override string ToString()
        {
            return $"\nId: {Id}, FechaHora: {FechaHora}, Usuario: {Usuario}, Tipo: {Tipo}, Descripcion: {Descripcion}";
        }
    }
}
