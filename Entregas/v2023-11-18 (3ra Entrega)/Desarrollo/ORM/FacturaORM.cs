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
    public class FacturaORM : IABMC<Factura>
    {
        readonly string archivo = $"Archivos/Facturas.xml";
        readonly XmlDAL xmlDAL;
        public FacturaORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Factura MapearDesdeXML(XElement pElement)
        {
            try
            {
                return new Factura
                {
                    Id = int.Parse(pElement.Attribute("Id").Value),
                    Fecha = DateTime.Parse(pElement.Element("Fecha").Value),
                    MontoOrden = float.Parse(pElement.Element("MontoOrden").Value),
                    Impuesto = float.Parse(pElement.Element("Impuesto").Value),
                    Total = float.Parse(pElement.Element("Total").Value),
                    OrdenID = int.Parse(pElement.Element("OrdenID").Value)
                };
            }
            catch
            {

                throw new Exception("El elemento mapeado está vacío");
            }
        }

        private XElement MapearHaciaXML(Factura pObject)
        {
            return new XElement("Factura",
                new XAttribute("Id", pObject.Id),
                new XElement("Fecha", pObject.Fecha.ToString("yyyy-MM-dd")),
                new XElement("MontoOrden", pObject.MontoOrden.ToString()),
                new XElement("Impuesto", pObject.Impuesto.ToString()),
                new XElement("Total", pObject.Total.ToString()),
                new XElement("OrdenID", pObject.OrdenID)
            );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Factura pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Factura").Max(x => (int)x.Attribute("Id"));
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
            XElement eliminable = xml.Elements("Factura")
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

        public void Modificar(Factura pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Factura")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                // Actualiza datos escalares
                modificable.Element("Fecha").Value = pObject.Fecha.ToString("yyyy-MM-dd");
                modificable.Element("MontoOrden").Value = pObject.MontoOrden.ToString();
                modificable.Element("Impuesto").Value = pObject.Impuesto.ToString();
                modificable.Element("Total").Value = pObject.Total.ToString();
                modificable.Element("OrdenID").Value = pObject.OrdenID.ToString();

                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Factura> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Factura")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
