using DAL;
using BEL;
using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;

namespace ORM
{
    public class CamionORM : IABMC<Camion>
    {
        readonly string archivo = $"Archivos/Camiones.xml";
        readonly XmlDAL xmlDAL;
        public CamionORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Camion MapearDesdeXML(XElement pElement)
        {
            return new Camion
            {
                Id = int.Parse(pElement.Attribute("Id").Value),
                Patente = pElement.Element("Patente").Value,
                Marca = pElement.Element("Marca").Value,
            };
        }

        private XElement MapearHaciaXML(Camion pObject)
        {
            return new XElement("Camion",
                new XAttribute("Id", pObject.Id),
                new XElement("Patente", pObject.Patente),
                new XElement("Marca", pObject.Marca)


            );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Camion pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Camion").Max(x => (int)x.Attribute("Id"));
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
            XElement eliminable = xml.Elements("Camion")
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

        public void Modificar(Camion pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Camion")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                // Actualiza datos escalares
                modificable.Element("Patente").Value = pObject.Patente;
                modificable.Element("Marca").Value = pObject.Marca;

                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Camion> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Camion")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
