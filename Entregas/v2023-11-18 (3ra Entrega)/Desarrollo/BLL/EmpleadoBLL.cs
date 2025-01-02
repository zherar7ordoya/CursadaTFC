using ABS;

using BEL;

using ORM;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class EmpleadoBLL : IABMC<Empleado>
    {
        private readonly EmpleadoORM empleadoORM;
        public EmpleadoBLL() => empleadoORM = new EmpleadoORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Empleado pObject) => empleadoORM.Agregar(pObject);
        public void Eliminar(int pId) => empleadoORM.Eliminar(pId);
        public void Modificar(Empleado pObject) => empleadoORM.Modificar(pObject);
        public List<Empleado> Consultar() => empleadoORM.Consultar();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LÓGICA DE NEGOCIO

        public List<Empleado> ListarChoferesDisponibles(DateTime pFecha)
        {
            EmpleadoORM empleadoORM = new EmpleadoORM();
            List<Empleado> choferes = empleadoORM.Consultar();
            MudanzaORM mudanzaORM = new MudanzaORM();
            List<Mudanza> mudanzas = mudanzaORM.Consultar();

            // Filtrar mudanzas para la fecha dada
            List<Mudanza> mudanzasFiltradas = mudanzas.Where(m => m.Fecha.Date == pFecha.Date).ToList();

            // Obtener los DNIs de los choferes ocupados en la fecha
            List<int> choferesOcupados = mudanzasFiltradas.Select(m => m.Chofer.DNI).ToList();

            // Filtrar la lista de choferes disponibles
            List<Empleado> choferesDisponibles =
                choferes.Where(c => c.Puesto == "Chofer" && !choferesOcupados.Contains(c.DNI)).ToList();

            return choferesDisponibles;
        }

        public List<Empleado> ListarEstibadoresDisponibles(DateTime pFecha)
        {
            EmpleadoORM empleadoORM = new EmpleadoORM();
            List<Empleado> estibadores = empleadoORM.Consultar();
            MudanzaORM mudanzaORM = new MudanzaORM();
            List<Mudanza> mudanzas = mudanzaORM.Consultar();

            // Filtrar mudanzas para la fecha dada
            List<Mudanza> mudanzasFiltradas =
                mudanzas.Where(m => m.Fecha.Date == pFecha.Date).ToList();

            // Obtener los DNIs de los estibadores ocupados en la fecha
            List<int> estibadoresOcupados =
                mudanzasFiltradas.SelectMany(m => m.Estibadores.Select(e => e.DNI)).ToList();

            // Filtrar la lista de estibadores disponibles
            List<Empleado> estibadoresDisponibles =
                estibadores.Where(c => c.Puesto == "Estibador" && !estibadoresOcupados.Contains(c.DNI)).ToList();

            return estibadoresDisponibles;
        }

        public Empleado GetByUsername(string pUsername)
        {
            EmpleadoORM empleadoORM = new EmpleadoORM();
            List<Empleado> empleados = empleadoORM.Consultar();
            return empleados.FirstOrDefault(x => x.Username == pUsername);
        }

        public bool YaExisteDNI(int pDNI)
        {
            List<Empleado> empleados = empleadoORM.Consultar();
            int conteo = empleados.Count(x => x.DNI == pDNI);
            return conteo == 1;
        }

        public bool YaExisteUsername(string pUsername)
        {
            List<Empleado> empleados = empleadoORM.Consultar();
            int conteo = empleados.Count(x => x.Username == pUsername);
            return conteo == 1;
        }

    }
}
