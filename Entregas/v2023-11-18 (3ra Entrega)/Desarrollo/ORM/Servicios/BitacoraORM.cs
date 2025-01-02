using ABS;

using BEL;

using DAL;



using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ORM
{
    // Función de esta clase: consultar Archivos.xml y/o Registros.xml
    public class BitacoraORM : IABMC<Bitacora>
    {
        readonly string archivo = $"Archivador/Bitacoras.xml";
        readonly XmlDAL xmlDAL;
        public BitacoraORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Bitacora MapearDesdeXML(XElement pElement)
        {
            return new Bitacora
            {
                Id = int.Parse(pElement.Attribute("Id").Value),
                FechaHora = DateTime.Parse(pElement.Element("FechaHora").Value),
                Usuario = pElement.Element("Usuario").Value,
                Tipo = pElement.Element("Tipo").Value,
                Descripcion = pElement.Element("Descripcion").Value
            };
        }

        private XElement MapearHaciaXML(Bitacora pObject)
        {
            return new XElement("Bitacora",
                new XAttribute("Id", pObject.Id),
                new XElement("FechaHora", pObject.FechaHora.ToString()),
                new XElement("Usuario", pObject.Usuario),
                new XElement("Tipo", pObject.Tipo),
                new XElement("Descripcion", pObject.Descripcion)
            );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Bitacora pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Bitacora").Max(x => (int)x.Attribute("Id"));
                int newId = maxId + 1;
                pObject.Id = newId;
                XElement agregable = MapearHaciaXML(pObject);
                xml.Add(agregable);
                xmlDAL.EscribirArchivoXML(xml);
            }
            catch (IOException)
            {
                throw new IOException("Problema de lectura o escritura.");
            }
        }

        public void Eliminar(int pId)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement eliminable = xml.Elements("Bitacora")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pId);

            if (eliminable != null)
            {
                eliminable.Remove();
                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a eliminar.");
            }
        }

        public void Modificar(Bitacora pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Bitacora")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                modificable.Element("FechaHora").Value = pObject.FechaHora.ToString();
                modificable.Element("Usuario").Value = pObject.Usuario;
                modificable.Element("Tipo").Value = pObject.Tipo;
                modificable.Element("Descripcion").Value = pObject.Descripcion;

                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Bitacora> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Bitacora")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
