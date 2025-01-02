using ABS;

using BEL;

using ORM;

using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class LiquidacionBLL : IABMC<Liquidacion>
    {
        private readonly LiquidacionORM liquidacionORM;
        public LiquidacionBLL() => liquidacionORM = new LiquidacionORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Liquidacion pObject) => liquidacionORM.Agregar(pObject);
        public void Eliminar(int pId) => liquidacionORM.Eliminar(pId);
        public void Modificar(Liquidacion pObject) => liquidacionORM.Modificar(pObject);
        public List<Liquidacion> Consultar() => liquidacionORM.Consultar();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LÓGICA DE NEGOCIO

        public float CalcularLiquidacion(float pMontoOrden, List<Comprobante> pComprobantes)
        {
            // Calcula la suma de montos de los comprobantes
            float totalComprobantes = pComprobantes.Sum(comprobante => comprobante.Monto);

            // Calcula el total de la liquidación sumando el monto de la orden y el monto de reembolso
            return (pMontoOrden * 0.10f) + totalComprobantes;
        }

        public Liquidacion BuscarPorOrdenId(int pOrdenID)
        {
            List<Liquidacion> liquidaciones = liquidacionORM.Consultar();
            return liquidaciones.FirstOrDefault(x => x.OrdenID == pOrdenID);
        }
    }
}
