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
    public class LiquidacionORM : IABMC<Liquidacion>
    {
        readonly string archivo = $"Archivos/Liquidaciones.xml";
        readonly XmlDAL xmlDAL;
        public LiquidacionORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Liquidacion MapearDesdeXML(XElement pElement)
        {
            return new Liquidacion
            {
                Id = int.Parse(pElement.Attribute("Id").Value),
                Fecha = DateTime.Parse(pElement.Element("Fecha").Value),
                Comprobantes = pElement.Element("Comprobantes").Elements("Comprobante")
                    .Select(x => new Comprobante
                    {
                        Fecha = DateTime.Parse(x.Element("Fecha").Value),
                        Detalle = x.Element("Detalle").Value,
                        Monto = float.Parse(x.Element("Monto").Value)
                    })
                    .ToList(),
                MontoOrden = float.Parse(pElement.Element("MontoOrden").Value),
                MontoReembolso = float.Parse(pElement.Element("MontoReembolso").Value),
                Total = float.Parse(pElement.Element("Total").Value),
                OrdenID = int.Parse(pElement.Element("OrdenID").Value)
            };
        }

        private XElement MapearHaciaXML(Liquidacion pObject)
        {
            return new XElement("Liquidacion",
                new XAttribute("Id", pObject.Id),
                new XElement("Fecha", pObject.Fecha.ToString("yyyy-MM-dd")),
                new XElement("Comprobantes", pObject.Comprobantes
                    .Select(x => new XElement("Comprobante",
                        new XElement("Fecha", x.Fecha.ToString("yyyy-MM-dd")),
                        new XElement("Detalle", x.Detalle),
                        new XElement("Monto", x.Monto)
                    ))
                ),
                new XElement("MontoOrden", pObject.MontoOrden.ToString()),
                new XElement("MontoReembolso", pObject.MontoReembolso.ToString()),
                new XElement("Total", pObject.Total.ToString()),
                new XElement("OrdenID", pObject.OrdenID.ToString())
            );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Liquidacion pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Liquidacion").Max(x => (int)x.Attribute("Id"));
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
            XElement eliminable = xml.Elements("Liquidacion")
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

        public void Modificar(Liquidacion pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Liquidacion")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                modificable.Element("Fecha").Value = pObject.Fecha.ToString("yyyy-MM-dd");
                modificable.Element("Comprobantes").Elements("Comprobante").Remove();
                modificable.Element("Comprobantes").Add(
                    pObject.Comprobantes.Select(x =>
                        new XElement("Comprobante",
                            new XElement("Fecha", x.Fecha),
                            new XElement("Detalle", x.Detalle),
                            new XElement("Monto", x.Monto)
                        )
                    )
                );
                modificable.Element("MontoOrden").Value = pObject.MontoOrden.ToString();
                modificable.Element("MontoReembolso").Value = pObject.MontoReembolso.ToString();
                modificable.Element("Total").Value = pObject.Total.ToString();
                modificable.Element("OrdenID").Value = pObject.OrdenID.ToString();

                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Liquidacion> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Liquidacion")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
