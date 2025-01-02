using ABS;

using BEL;

using ORM;

using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class MudanzaBLL : IABMC<Mudanza>
    {
        private readonly MudanzaORM mudanzaORM;
        public MudanzaBLL() => mudanzaORM = new MudanzaORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Mudanza pObject) => mudanzaORM.Agregar(pObject);
        public void Eliminar(int pId) => mudanzaORM.Eliminar(pId);
        public void Modificar(Mudanza pObject) => mudanzaORM.Modificar(pObject);
        public List<Mudanza> Consultar() => mudanzaORM.Consultar();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LÓGICA DE NEGOCIO

        public Mudanza BuscarPorOrdenId(int pOrdenID)
        {
            List<Mudanza> mudanzas = mudanzaORM.Consultar();
            return mudanzas.FirstOrDefault(x => x.OrdenID == pOrdenID);
        }
    }
}
