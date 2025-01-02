using ABS;

using BEL;

using ORM;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class OrdenBLL : IABMC<Orden>
    {
        private readonly OrdenORM ordenORM;
        public OrdenBLL() => ordenORM = new OrdenORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Orden pObject) => ordenORM.Agregar(pObject);
        public void Eliminar(int pId) => ordenORM.Eliminar(pId);
        public void Modificar(Orden pObject) => ordenORM.Modificar(pObject);
        public List<Orden> Consultar() => ordenORM.Consultar();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LÓGICA DE NEGOCIO

        public bool EsFechaDisponible(DateTime pFecha)
        {
            // Obtener las mudanzas para la fecha dada
            MudanzaORM mudanzaORM = new MudanzaORM();
            List<Mudanza> mudanzas = mudanzaORM.Consultar().Where(m => m.Fecha.Date == pFecha.Date).ToList();

            // Obtener la lista de camiones asignados en las mudanzas para esa fecha
            List<string> camionesAsignados = mudanzas.Select(m => m.Camion.Patente).ToList();

            // Obtener la lista completa de camiones
            CamionORM camionORM = new CamionORM();
            List<Camion> camiones = camionORM.Consultar();

            // Verificar si todos los camiones están asignados para esa fecha
            bool fechaDisponible = camiones.All(camion => camionesAsignados.Contains(camion.Patente));

            return !fechaDisponible;
        }

        public bool EsDistanciaPermitida(int pKilometros)
        {
            return pKilometros < 101;
        }

        public float CotizarServicio(DateTime pFecha, string pCategoria, int pKilometros)
        {
            TarifaORM tarifaORM = new TarifaORM();
            List<Tarifa> tarifas = tarifaORM.Consultar();

            // Busca la tarifa que corresponda a la fecha pFecha y la categoría pCategoria
            Tarifa tarifa = tarifas.FirstOrDefault(t =>
                pFecha >= t.Desde && pFecha <= t.Hasta && t.Coeficientes.Any(c => c.Categoria == pCategoria));

            if (tarifa != null)
            {
                // Coeficiente para la categoría dada
                Coeficiente coeficiente = tarifa.Coeficientes.First(c => c.Categoria == pCategoria);
                return tarifa.MontoKilometro * pKilometros * coeficiente.Valor;
            }
            else
            {
                throw new Exception("No se encontró una tarifa válida para la fecha y categoría proporcionadas.");
            }
        }

        public List<Orden> ListarEstadoSolicitado()
        {
            OrdenORM ordenORM = new OrdenORM();
            List<Orden> ordenes = ordenORM.Consultar();
            return ordenes.Where(x => x.Estado == "Solicitado").ToList();
        }

        public List<Orden> ListarEstadoPagado()
        {
            OrdenORM ordenORM = new OrdenORM();
            List<Orden> ordenes = ordenORM.Consultar();
            return ordenes.Where(x => x.Estado == "Pagado").ToList();
        }

        // A implementar: listado solo sobre la fecha actual
        public List<Orden> ListarServiciosPendientes()
        {
            OrdenORM ordenORM = new OrdenORM();
            List<Orden> ordenes = ordenORM.Consultar();
            DateTime fecha = DateTime.Now;
            // DateTime fecha = new DateTime(2024, 8, 26); // Para pruebas
            return ordenes.Where(x => x.Estado == "Pagado" && x.ServicioFecha == fecha).ToList();
        }

        public List<Orden> ListarEstadoTransito()
        {
            OrdenORM ordenORM = new OrdenORM();
            List<Orden> ordenes = ordenORM.Consultar();
            return ordenes.Where(x => x.Estado == "Tránsito").ToList();
        }

        public Orden BuscarPorId(int pId)
        {
            List<Orden> ordenes = ordenORM.Consultar();
            return ordenes.FirstOrDefault(x => x.Id == pId);
        }
    }
}
