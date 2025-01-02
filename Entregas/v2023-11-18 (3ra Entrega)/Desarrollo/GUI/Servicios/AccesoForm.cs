using System;
using System.Drawing;
using System.Windows.Forms;

using BLL;
using BEL;
using SRV;

namespace GUI
{
    public partial class AccesoForm : BaseForm
    {
        readonly EmpleadoBLL empleadoBLL;
        public AccesoForm()
        {
            InitializeComponent();
            empleadoBLL = new EmpleadoBLL();
        }
        private void AccesoFRM_Load(object sender, EventArgs e)
        {
            CentrarControles();
        }

        private void CentrarControles()
        {
            // Calcula el centro del formulario
            int formX = this.Width / 2;
            int formY = this.Height / 2;

            // Calcula las ubicaciones para los controles
            int labelUsuarioX = formX - UsuarioLabel.Width;
            int labelUsuarioY = formY - (AccederButton.Height * 4) + 5;
            int textboxUsuarioX = formX;
            int textboxUsuarioY = formY - (AccederButton.Height * 4);

            int labelContraseñaX = formX - ContraseñaLabel.Width;
            int labelContraseñaY = formY - (AccederButton.Height * 2) + 5;
            int textboxContraseñaX = formX;
            int textboxContraseñaY = formY - (AccederButton.Height * 2);

            int botonAccederX = formX - (AccederButton.Width / 2);
            int botonAccederY = formY + 5;

            // Establece las ubicaciones de los controles
            UsuarioLabel.Location = new Point(labelUsuarioX, labelUsuarioY);
            UsuarioTextbox.Location = new Point(textboxUsuarioX, textboxUsuarioY);
            ContraseñaLabel.Location = new Point(labelContraseñaX, labelContraseñaY);
            ContraseñaTextbox.Location = new Point(textboxContraseñaX, textboxContraseñaY);
            AccederButton.Location = new Point(botonAccederX, botonAccederY);
        }

        private void AccederBTN_Click(object sender, EventArgs e)
        {
            string username = UsuarioTextbox.Text;
            string password = ContraseñaTextbox.Text;
            Empleado empleado = empleadoBLL.GetByUsername(username);

            if (empleado == null)
            {
                MessageBox.Show("No se ha encontrado al usuario.");
                return;
            }

            if (empleado.Intento > 2)
            {
                MessageBox.Show("Cuenta bloqueada.\nContacte al administrador.");
                return;
            }
            
            if (empleado.Password == Criptografia.Encriptar(password))
            {
                // Reset sobre el usuario
                empleado.Intento = 0;
                empleadoBLL.Modificar(empleado);

                PrincipalForm formulario = new PrincipalForm(empleado);
                Hide();
                formulario.Show();
            }
            else
            {
                empleado.Intento++;
                empleadoBLL.Modificar(empleado);

                MessageBox.Show($"Datos incorrectos.\nIntento #{empleado.Intento}");

                if (empleado.Intento > 2)
                {
                    MessageBox.Show("Demasiados intentos.\nSe ha bloqueado la cuenta.\nContacte al administrador.");
                }
            }
        }
    }
}
