using DAL;
using BEL;
using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Globalization;

namespace ORM
{
    public class OrdenORM : IABMC<Orden>
    {
        readonly string archivo = $"Archivos/Ordenes.xml";
        readonly XmlDAL xmlDAL;
        public OrdenORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Orden MapearDesdeXML(XElement pElement)
        {
            // Configuración cultural con punto como separador decimal.
            var decimales = new CultureInfo("en-US");
            return new Orden
            {
                Id = int.Parse(pElement.Attribute("Id").Value),
                Estado = pElement.Element("Estado").Value,
                ServicioFecha = DateTime.Parse(pElement.Element("ServicioFecha").Value),
                DireccionOrigen = pElement.Element("DireccionOrigen").Value,
                DescripcionLugarCarga = pElement.Element("DescripcionLugarCarga").Value,
                DireccionDestino = pElement.Element("DireccionDestino").Value,
                DescripcionLugarDescarga = pElement.Element("DescripcionLugarDescarga").Value,
                Muebles = pElement.Element("Muebles").Elements("Mueble")
                .Select(x => new Mueble
                {
                    Cantidad = int.Parse(x.Element("Cantidad").Value),
                    Descripcion = x.Element("Descripcion").Value
                })
                .ToList(),
                Observaciones = pElement.Element("Observaciones").Value,
                KilometrosDistancia = int.Parse(pElement.Element("KilometrosDistancia").Value),
                Monto = float.Parse(pElement.Element("Monto").Value, decimales),
                ClienteID = int.Parse(pElement.Element("ClienteID").Value)
            };
        }

        private XElement MapearHaciaXML(Orden pObject)
        {
            return new XElement("Orden",
                new XAttribute("Id", pObject.Id),
                new XElement("Estado", pObject.Estado),
                new XElement("ServicioFecha", pObject.ServicioFecha.ToString("yyyy-MM-dd")),
                new XElement("DireccionOrigen", pObject.DireccionOrigen),
                new XElement("DescripcionLugarCarga", pObject.DescripcionLugarCarga),
                new XElement("DireccionDestino", pObject.DireccionDestino),
                new XElement("DescripcionLugarDescarga", pObject.DescripcionLugarDescarga),
                new XElement("Muebles", pObject.Muebles
                    .Select(x => new XElement("Mueble",
                        new XElement("Cantidad", x.Cantidad),
                        new XElement("Descripcion", x.Descripcion)
                    ))
                ),
                new XElement("Observaciones", pObject.Observaciones),
                new XElement("KilometrosDistancia", pObject.KilometrosDistancia),
                new XElement("Monto", pObject.Monto),
                new XElement("ClienteID", pObject.ClienteID)
            );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Orden pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Orden").Max(x => (int)x.Attribute("Id"));
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
            XElement eliminable = xml.Elements("Orden")
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

        public void Modificar(Orden pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Orden")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                modificable.Element("ServicioFecha").Value = pObject.ServicioFecha.ToString("yyyy-MM-dd");
                modificable.Element("Estado").Value = pObject.Estado;
                modificable.Element("DireccionOrigen").Value = pObject.DireccionOrigen;
                modificable.Element("DescripcionLugarCarga").Value = pObject.DescripcionLugarCarga;
                modificable.Element("DireccionDestino").Value = pObject.DireccionDestino;
                modificable.Element("DescripcionLugarDescarga").Value = pObject.DescripcionLugarDescarga;
                modificable.Element("Muebles").Elements("Mueble").Remove();
                modificable.Element("Muebles").Add(
                    pObject.Muebles.Select(x =>
                        new XElement("Mueble",
                            new XElement("Cantidad", x.Cantidad),
                            new XElement("Descripcion", x.Descripcion)
                        )
                    )
                );
                modificable.Element("Observaciones").Value = pObject.Observaciones;
                modificable.Element("KilometrosDistancia").Value = pObject.KilometrosDistancia.ToString();
                modificable.Element("Monto").Value = pObject.Monto.ToString();
                modificable.Element("ClienteID").Value = pObject.ClienteID.ToString();

                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Orden> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Orden")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
