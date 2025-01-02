using ABS;
using BEL;
using ORM;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class CamionBLL : IABMC<Camion>
    {
        private readonly CamionORM camionORM;
        public CamionBLL() => camionORM = new CamionORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Camion pObject) => camionORM.Agregar(pObject);
        public void Eliminar(int pId) => camionORM.Eliminar(pId);
        public void Modificar(Camion pObject) => camionORM.Modificar(pObject);
        public List<Camion> Consultar() => camionORM.Consultar();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LÓGICA DE NEGOCIO

        public List<Camion> ListarCamionesDisponibles(DateTime pFecha)
        {
            CamionORM camionORM = new CamionORM();
            List<Camion> camiones = camionORM.Consultar();

            MudanzaORM mudanzaORM = new MudanzaORM();
            List<Mudanza> mudanzas = mudanzaORM.Consultar();

            // Filtrar mudanzas para la fecha dada
            List<Mudanza> mudanzasFiltradas = mudanzas.Where(m => m.Fecha.Date == pFecha.Date).ToList();

            // Obtener los IDs de camiones ocupados en la fecha
            List<string> camionesOcupados = mudanzasFiltradas.Select(m => m.Camion.Patente).ToList();

            // Filtrar la lista de camiones disponibles
            List<Camion> camionesDisponibles = camiones.Where(c => !camionesOcupados.Contains(c.Patente)).ToList();

            return camionesDisponibles;
        }
    }
}
