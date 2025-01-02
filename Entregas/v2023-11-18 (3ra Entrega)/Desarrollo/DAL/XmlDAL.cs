using System;
using System.Xml.Linq;




namespace DAL
{
    public class XmlDAL
    {
        private readonly string archivo;
        public XmlDAL(string pArchivo) => archivo = pArchivo;

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LECTURA/ESCRITURA

        public XElement LeerArchivoXML()
        {
            try
            {
                return XElement.Load(archivo);
            }
            catch
            {
                throw new Exception("Error al leer el archivo.");
            }
        }

        public bool EscribirArchivoXML(XElement pXElement)
        {
            try
            {
                pXElement.Save(archivo);
                return true;
            }
            catch
            {
                throw new Exception("Error al escribir el archivo.");
            }
        }
    }
}
