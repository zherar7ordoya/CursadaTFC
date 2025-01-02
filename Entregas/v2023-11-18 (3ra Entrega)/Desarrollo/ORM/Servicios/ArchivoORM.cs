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
    public class ArchivoORM : IABMC<Archivo>
    {
        readonly string archivo = $"Archivador/Archivos.xml";
        readonly XmlDAL xmlDAL;
        public ArchivoORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Archivo MapearDesdeXML(XElement pElement)
        {
            return new Archivo
            {
                Id = int.Parse(pElement.Attribute("Id").Value),
                Nombre = pElement.Element("Nombre").Value
            };
        }

        private XElement MapearHaciaXML(Archivo pObject)
        {
            return new XElement("Archivo",
                new XAttribute("Id", pObject.Id),
                new XElement("Nombre", pObject.Nombre)
            );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Archivo pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Archivo").Max(x => (int)x.Attribute("Id"));
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
            XElement eliminable = xml.Elements("Archivo")
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

        public void Modificar(Archivo pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Archivo")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                modificable.Element("Nombre").Value = pObject.Nombre;
                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Archivo> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Archivo")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
