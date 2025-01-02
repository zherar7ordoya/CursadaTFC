using ABS;

using BEL;

using ORM;

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace BLL
{
    public class ClienteBLL : IABMC<Cliente>
    {
        private readonly ClienteORM clienteORM;
        public ClienteBLL() => clienteORM = new ClienteORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABMC

        public void Agregar(Cliente pObject) => clienteORM.Agregar(pObject);
        public void Eliminar(int pId) => clienteORM.Eliminar(pId);
        public void Modificar(Cliente pObject) => clienteORM.Modificar(pObject);
        public List<Cliente> Consultar() => clienteORM.Consultar();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||| LÓGICA DE NEGOCIO


        public Cliente BuscarPorId(int pId)
        {
            List<Cliente> clientes = clienteORM.Consultar();
            return clientes.FirstOrDefault(x => x.Id == pId);
        }

        public Cliente BuscarPorDNI_o_CUIT(string pDNI_o_CUIT)
        {
            List<Cliente> clientes = clienteORM.Consultar();
            return clientes.FirstOrDefault(x => x.DNI_o_CUIT == pDNI_o_CUIT);
        }

        public bool EsValidoDNI_o_CUIT(string pDNI_o_CUIT)
        {
            // Elimina puntos y guiones para facilitar la validación
            string dni_cuit = Regex.Replace(pDNI_o_CUIT, @"[.-]", "");

            if (Regex.IsMatch(dni_cuit, @"^\d{8}$"))
            {
                return true; // Es un DNI válido (exactamente 8 dígitos numéricos)
            }
            else if (Regex.IsMatch(dni_cuit, @"^\d{11}$"))
            {
                return true; // Es un CUIT válido (exactamente 11 dígitos numéricos)
            }
            else
            {
                return false; // Si no cumple con ninguno de los formatos anteriores, no es válido
            }
        }

        public bool YaExisteDNI_o_CUIT(string pDNI_o_CUIT)
        {
            List<Cliente> clientes = clienteORM.Consultar();
            int conteo = clientes.Count(x => x.DNI_o_CUIT == pDNI_o_CUIT);
            return conteo == 1;
        }
    }
}
