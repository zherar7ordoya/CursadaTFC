using BEL;

using BLL;

using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClienteABM : BaseForm
    {
        Empleado empleado;
        readonly ClienteBLL clienteBLL;
        public ClienteABM(Empleado pEmpleado)
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
            this.empleado = pEmpleado;
        }

        private void ClienteFRM_Load(object sender, EventArgs e)
        {
            this.Text = $"Clientes - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            // Actualizar listado
            ClientesDGV.DataSource = null;
            ClientesDGV.DataSource = clienteBLL.Consultar();

            // Actualizar elemementos
            Cliente cliente = (Cliente)ClientesDGV.Rows[0].DataBoundItem;
            MapearDesdeObjeto(cliente);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Cliente pCliente)
        {
            IdTXT.Text = pCliente.Id.ToString();
            CategoriaCBX.Text = pCliente.Categoria;
            DNI_o_CUIT_Textbox.Text= pCliente.DNI_o_CUIT;
            NombreApellido_o_RazonSocial_Textbox.Text = pCliente.NombreApellido_o_RazonSocial;
            DireccionTXT.Text = pCliente.Direccion;
            TelefonoTXT.Text = pCliente.Telefono;
            EmailTXT.Text = pCliente.Email;
        }
        private Cliente MapearHaciaObjeto()
        {
            Cliente cliente = new Cliente
            {
                Id = int.Parse(IdTXT.Text),
                Categoria=CategoriaCBX.Text,
                DNI_o_CUIT=DNI_o_CUIT_Textbox.Text,
                NombreApellido_o_RazonSocial=NombreApellido_o_RazonSocial_Textbox.Text,
                Direccion=DireccionTXT.Text,
                Telefono=TelefonoTXT.Text,
                Email=EmailTXT.Text
            };
            return cliente;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS

        private void ClientesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cliente cliente = (Cliente)ClientesDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(cliente);
            }
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABM

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearHaciaObjeto();
            clienteBLL.Agregar(cliente);
            ActualizarPantalla();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearHaciaObjeto();
            clienteBLL.Eliminar(cliente.Id);
            ActualizarPantalla();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            Cliente cliente = MapearHaciaObjeto();
            clienteBLL.Modificar(cliente);
            ActualizarPantalla();
        }
    }
}
