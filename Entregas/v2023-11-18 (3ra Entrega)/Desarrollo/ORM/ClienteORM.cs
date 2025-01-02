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
    public class ClienteORM : IABMC<Cliente>
    {
        readonly string archivo = $"Archivos/Clientes.xml";
        readonly XmlDAL xmlDAL;
        public ClienteORM() => xmlDAL = new XmlDAL(archivo);

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEO

        private Cliente MapearDesdeXML(XElement pElement)
        {
            return new Cliente
            {
                Id = int.Parse(pElement.Attribute("Id").Value),
                DNI_o_CUIT = pElement.Element("DNI_o_CUIT").Value,
                Categoria = pElement.Element("Categoria").Value,
                NombreApellido_o_RazonSocial = pElement.Element("NombreApellido_o_RazonSocial").Value,
                Direccion = pElement.Element("Direccion").Value,
                Telefono = pElement.Element("Telefono").Value,
                Email = pElement.Element("Email").Value
            };
        }

        private XElement MapearHaciaXML(Cliente pObject)
        {
            return new XElement("Cliente",
                new XAttribute("Id", pObject.Id),
                new XElement("DNI_o_CUIT", pObject.DNI_o_CUIT),
                new XElement("Categoria", pObject.Categoria),
                new XElement("NombreApellido_o_RazonSocial", pObject.NombreApellido_o_RazonSocial),
                new XElement("Direccion", pObject.Direccion),
                new XElement("Telefono", pObject.Telefono),
                new XElement("Email", pObject.Email)
            );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Cliente pObject)
        {
            try
            {
                XElement xml = xmlDAL.LeerArchivoXML();
                int maxId = xml.Descendants("Cliente").Max(x => (int)x.Attribute("Id"));
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
            XElement eliminable = xml.Elements("Cliente")
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

        public void Modificar(Cliente pObject)
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            XElement modificable = xml.Elements("Cliente")
                .FirstOrDefault(x => (int)x.Attribute("Id") == pObject.Id);

            if (modificable != null)
            {
                modificable.Element("DNI_o_CUIT").Value = pObject.DNI_o_CUIT;
                modificable.Element("Categoria").Value = pObject.Categoria;
                modificable.Element("NombreApellido_o_RazonSocial").Value = pObject.NombreApellido_o_RazonSocial;
                modificable.Element("Direccion").Value = pObject.Direccion;
                modificable.Element("Telefono").Value = pObject.Telefono;
                modificable.Element("Email").Value = pObject.Email;

                xmlDAL.EscribirArchivoXML(xml);
            }
            else
            {
                throw new ArgumentException("No se encontró el elemento a modificar.");
            }
        }

        public List<Cliente> Consultar()
        {
            XElement xml = xmlDAL.LeerArchivoXML();
            return xml.Elements("Cliente")
              .Select(x => MapearDesdeXML(x))
              .ToList();
        }
    }
}
