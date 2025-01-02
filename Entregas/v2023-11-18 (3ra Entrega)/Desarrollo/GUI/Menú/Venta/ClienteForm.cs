using BEL;

using BLL;

using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class ClienteForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO

        public string DNI_o_CUIT { get; private set; }
        readonly Empleado empleado;

        public ClienteForm
            (
            Empleado pEmpleado,
            string pDNI_o_CUIT
            )
        {
            InitializeComponent();
            empleado = pEmpleado;
            DNI_o_CUIT = pDNI_o_CUIT;
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Cliente - {empleado.NombreApellido}";
            DNI_o_CUIT_Textbox.Text = DNI_o_CUIT;
        }
        
        private void GrabarButton_Click(object sender, EventArgs e)
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            Cliente cliente = new Cliente
            {
                Categoria = CategoriaCombobox.Text,
                DNI_o_CUIT= DNI_o_CUIT_Textbox.Text,
                NombreApellido_o_RazonSocial = NombreTextbox.Text,
                Direccion = DireccionTextbox.Text,
                Telefono = TelefonoTextbox.Text,
                Email = EmailTextbox.Text
            };
            clienteBLL.Agregar(cliente);
            DNI_o_CUIT = cliente.DNI_o_CUIT;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
