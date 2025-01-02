using DAL;

using System.Xml.Linq;

namespace ORM
{
    public class RolORM
    {
        readonly string archivo = $"Archivos/Roles.xml";
        readonly XmlDAL xmlDAL;
        public RolORM() => xmlDAL = new XmlDAL(archivo);


        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS


        public XElement Consultar()
        {
            return xmlDAL.LeerArchivoXML();
        }

        public void Modificar(XElement pObject)
        {
            xmlDAL.EscribirArchivoXML(pObject);
        }
    }
}
