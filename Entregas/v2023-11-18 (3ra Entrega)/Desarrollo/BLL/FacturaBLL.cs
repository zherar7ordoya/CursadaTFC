using ABS;

using BEL;

using ORM;

using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class FacturaBLL : IABMC<Factura>
    {
        private readonly FacturaORM facturaORM;
        public FacturaBLL() => facturaORM = new FacturaORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Factura pObject) => facturaORM.Agregar(pObject);
        public void Eliminar(int pId) => facturaORM.Eliminar(pId);
        public void Modificar(Factura pObject) => facturaORM.Modificar(pObject);
        public List<Factura> Consultar() => facturaORM.Consultar();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LÓGICA DE NEGOCIO

        public float CalcularTotal(float pMontoOrden, float pImpuesto)
        {
            return pMontoOrden + pImpuesto;
        }

        public Factura BuscarPorOrdenId(int pOrdenID)
        {
            List<Factura> facturas = facturaORM.Consultar();
            return facturas.FirstOrDefault(x => x.OrdenID == pOrdenID);
        }

    }
}
