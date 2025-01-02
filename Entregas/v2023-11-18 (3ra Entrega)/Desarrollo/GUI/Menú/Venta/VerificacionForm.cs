using BEL;

using BLL;

using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class VerificacionForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO

        readonly Empleado empleado;

        public VerificacionForm(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
        }

        private void VerificacionForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Verificación - {empleado.NombreApellido}";
        }

        private void VerificarButton_Click(object sender, EventArgs e)
        {
            bool respuesta = Banco.ConfirmarTransferencia();
            if (respuesta)
            {
                VerificacionTextbox.Text = "Verificación positiva";
            }
            else
            {
                VerificacionTextbox.Text = "No se encontró la transferencia";
            }
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
