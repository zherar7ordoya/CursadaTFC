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
    public class MudanzaORM : IABMC<Mudanza>
    {
        readonly string archivo = $"Archivos/Mudanzas.xml";
        readonly XmlDAL xmlDAL;
        public MudanzaORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Mudanza MapearDesdeXML(XElement pElement)
        {
            return new Mudanza
            {
                Id = int.Parse(pElement.Attribute("Id").Value),
                Fecha = DateTime.Parse(pElement.Element("Fecha").Value),
                Camion = new Camion
                {
                    Patente = pElement.Element("Camion")?.Element("Patente")?.Value,
                    Marca = pElement.Element("Camion")?.Element("Marca")?.Value
                },
                Chofer = new Empleado
                {
                    DNI = int.Parse(pElement.Element("Chofer")?.Element("DNI")?.Value),
                    NombreApellido = pElement.Element("Chofer")?.Element("NombreApellido")?.Value
                },
                Estibadores = pElement.Element("Estibadores")?.Elements("Estibador")
                    .Select(x => new Empleado
                    {
                        DNI = int.Parse(x.Element("DNI")?.Value),
                        NombreApellido = x.Element("NombreApellido")?.Value
                    })
                    .ToList(),
                Insumos = pElement.Element("Insumos")?.Elements("Insumo")
                    .Select(x => new Insumo
                    {
                        Cantidad = int.Parse(x.Element("Cantidad")?.Value),
                        Descripcion = x.Element("Descripcion")?.Value
                    })
                    .ToList(),
                OrdenID = int.Parse(pElement.Element("OrdenID")?.Value)
            };
        }

        private XElement MapearHaciaXML(Mudanza pObject)
        {
            return new XElement("Mudanza",
                new XAttribute("Id", pObject.Id),
                new XElement("Fecha", pObject.Fecha.ToString("yyyy-MM-dd")),
                new XElement("Camion",
                    new XElement("Patente", pObject.Camion.Patente),
                    new XElement("Marca", pObject.Camion.Marca)
                ),
                new XElement("Chofer",
                    new XElement("DNI", pObject.Chofer.DNI),
                    new XElement("NombreApellido", pObject.Chofer.NombreApellido)
                ),
                new XElement("Estibadores",
                    pObject.Estibadores.Select(estibador =>
                        new XElement("Estibador",
                            new XElement("DNI", estibador.DNI),
                            new XElement("NombreApellido", estibador.NombreApellido)
                        )
                    )
                ),
                new XElement("Insumos",
                    pObject.Insumos.Select(insumo =>
                        new XElement("Insumo",
                            new XElement("Cantidad", insumo.Cantidad),
                            new XElement("Descripcion", insumo.Descripcion)
                        )
                    )
                ),
                new XElement("OrdenID", pObject.OrdenID)
            );
        }


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Mudanza pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Mudanza").Max(x => (int)x.Attribute("Id"));
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
            XElement eliminable = xml.Elements("Mudanza")
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

        public void Modificar(Mudanza pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Mudanza")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                // Actualiza datos escalares
                modificable.Element("Fecha").Value = pObject.Fecha.ToString("yyyy-MM-dd");

                // Actualiza datos de entidades
                modificable.Element("Chofer").Element("DNI").Value = pObject.Chofer.DNI.ToString();
                modificable.Element("Chofer").Element("NombreApellido").Value = pObject.Chofer.NombreApellido;

                // Actualiza datos de entidades
                modificable.Element("Camion").Element("Patente").Value = pObject.Camion.Patente;
                modificable.Element("Camion").Element("Marca").Value = pObject.Camion.Marca;

                // Actualiza colección de datos
                modificable.Element("Estibadores").Elements("Estibador").Remove();
                modificable.Element("Estibadores").Add(
                    pObject.Estibadores.Select(x =>
                        new XElement("Estibador",
                            new XElement("DNI", x.DNI),
                            new XElement("NombreApellido", x.NombreApellido)
                        )
                    )
                );

                // Actualiza colección de datos
                modificable.Element("Insumos").Elements("Insumo").Remove();
                modificable.Element("Insumos").Add(
                    pObject.Insumos.Select(x =>
                        new XElement("Insumo",
                            new XElement("Cantidad", x.Cantidad),
                            new XElement("Descripcion", x.Descripcion)
                        )
                    )
                );
                modificable.Element("OrdenID").Value = pObject.OrdenID.ToString();

                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Mudanza> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Mudanza")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
