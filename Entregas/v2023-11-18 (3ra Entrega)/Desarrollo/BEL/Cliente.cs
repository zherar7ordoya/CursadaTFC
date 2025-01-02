using ABS;

namespace BEL
{
    public class Cliente : IID
    {
        public int Id { get; set; }
        /// <summary>
        /// Corporativo, Empresarial, Gubernamental, Particular
        /// </summary>
        public string Categoria { get; set; }

        /// <summary>
        /// DNI para los particulares.
        /// CUIT para las empresas.
        /// </summary>
        public string DNI_o_CUIT { get; set; }

        /// <summary>
        /// Nombre/Apellido para particulares.
        /// Razón Social para empresas.
        /// </summary>
        public string NombreApellido_o_RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        // Define el formato para mostrar el cliente.
        public override string ToString()
        {
            return $"Cliente #{Id}\n" +
                   $"Categoría: {Categoria}\n" +
                   $"DNI/CUIT: {DNI_o_CUIT}\n" +
                   $"Nombre y Apellido/Razón Social: {NombreApellido_o_RazonSocial}\n" +
                   $"Dirección: {Direccion}\n" +
                   $"Teléfono: {Telefono}\n" +
                   $"Email: {Email}";
        }
    }
}
