using ORM;

using System.Xml.Linq;

namespace BLL
{
    public class RolBLL
    {
        RolORM rolORM;

        public RolBLL()
        {
            rolORM = new RolORM();
        }

        public XElement Consultar()
        {
            return rolORM.Consultar();
        }

        public void Modificar(XElement pObject)
        {
            rolORM.Modificar(pObject);
        }
    }
}
