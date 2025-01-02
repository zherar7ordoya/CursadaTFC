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
    public class TarifaORM : IABMC<Tarifa>
    {
        readonly string archivo = $"Archivos/Tarifas.xml";
        readonly XmlDAL xmlDAL;
        public TarifaORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Tarifa MapearDesdeXML(XElement pElement)
        {
            // Configuración cultural con punto como separador decimal.
            var decimales = new CultureInfo("en-US");
            return new Tarifa
            {
                Id = int.Parse(pElement.Attribute("Id").Value),
                Desde = DateTime.Parse(pElement.Element("Desde").Value),
                Hasta = DateTime.Parse(pElement.Element("Hasta").Value),
                MontoKilometro = float.Parse(pElement.Element("MontoKilometro").Value, decimales),
                Coeficientes = pElement.Element("Coeficientes").Elements("Coeficiente")
                .Select(x => new Coeficiente
                {
                    Categoria = x.Element("Categoria").Value,
                    Valor = float.Parse(x.Element("Valor").Value, decimales)
                })
                .ToList()
            };
        }

        private XElement MapearHaciaXML(Tarifa pObject)
        {
            return new XElement("Tarifa",
                new XAttribute("Id", pObject.Id),
                new XElement("Desde", pObject.Desde.ToString("yyyy-MM-dd")),
                new XElement("Hasta", pObject.Hasta.ToString("yyyy-MM-dd")),
                new XElement("MontoKilometro", pObject.MontoKilometro),
                new XElement("Coeficientes", pObject.Coeficientes
                    .Select(x => new XElement("Coeficiente",
                        new XElement("Categoria", x.Categoria),
                        new XElement("Valor", x.Valor)
                    ))
                )
            );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Tarifa pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Tarifa").Max(x => (int)x.Attribute("Id"));
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
            XElement eliminable = xml.Elements("Tarifa")
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

        public void Modificar(Tarifa pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Tarifa")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                // Actualiza los elementos del XML con los datos de la tarifa modificada.
                modificable.Element("Desde").Value = pObject.Desde.ToString("yyyy-MM-dd");
                modificable.Element("Hasta").Value = pObject.Hasta.ToString("yyyy-MM-dd");
                modificable.Element("MontoKilometro").Value = pObject.MontoKilometro.ToString();

                // Actualiza los coeficientes (primero elimina los existentes, luego agrega los nuevos)
                modificable.Element("Coeficientes").Elements("Coeficiente").Remove();
                modificable.Element("Coeficientes").Add(
                    pObject.Coeficientes.Select(x =>
                        new XElement("Coeficiente",
                            new XElement("Categoria", x.Categoria),
                            new XElement("Valor", x.Valor)
                        )
                    )
                );
                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Tarifa> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Tarifa")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
