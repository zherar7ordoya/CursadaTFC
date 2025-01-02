using ABS;

using BEL;

using ORM;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace BLL
{
    public class TarifaBLL : IABMC<Tarifa>
    {
        private readonly TarifaORM tarifaORM;
        public TarifaBLL() => tarifaORM = new TarifaORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Tarifa pObject) => tarifaORM.Agregar(pObject);
        public void Eliminar(int pId) => tarifaORM.Eliminar(pId);
        public void Modificar(Tarifa pObject) => tarifaORM.Modificar(pObject);
        public List<Tarifa> Consultar() => tarifaORM.Consultar();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LÓGICA DE NEGOCIO

        public float CalcularKilometroPrecio(Cliente pCliente, DateTime pFecha)
        {
            List<Tarifa> tarifas = tarifaORM.Consultar();

            Tarifa tarifaEncontrada = tarifas.FirstOrDefault(t => pFecha >= t.Desde && pFecha <= t.Hasta);
            if (tarifaEncontrada != null)
            {
                Coeficiente coeficienteCliente = tarifaEncontrada.Coeficientes.FirstOrDefault(c => c.Categoria == pCliente.Categoria);
                if (coeficienteCliente != null)
                {
                    return tarifaEncontrada.MontoKilometro * coeficienteCliente.Valor;
                }
            }
            throw new ArgumentException("No se encontró una tarifa válida para el cliente y la fecha especificada.");
        }

        public DateTime DefinirProximaFecha()
        {
            try
            {
                List<Tarifa> tarifas = tarifaORM.Consultar();
                if (tarifas.Any())
                {
                    return tarifas.Max(tarifa => tarifa.Hasta).AddDays(1);
                }
                else
                {
                    return DateTime.Now; // Devuelve la fecha actual como valor predeterminado.
                }
            }
            catch
            {
                throw new IOException("Error al leer datos.");
            }
        }

        public int ContarTarifasExistentes()
        {
            try
            {
                List<Tarifa> tarifas = tarifaORM.Consultar();
                return tarifas.Count();
            }
            catch
            {
                throw new IOException("Error al leer datos.");
            }
        }
    }
}
