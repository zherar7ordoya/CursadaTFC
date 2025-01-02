using BEL;

using BLL;

using System;
using System.Windows.Forms;

using SRV;

namespace GUI
{
    public partial class EmpleadoABM : BaseForm
    {
        Empleado empleado;
        readonly EmpleadoBLL empleadoBLL;
        public EmpleadoABM(Empleado pEmpleado)
        {
            InitializeComponent();
            empleadoBLL = new EmpleadoBLL();
            this.empleado = pEmpleado;
        }

        private void EmpleadoFRM_Load(object sender, EventArgs e)
        {
            this.Text = $"Empleados - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            // Actualizar listado
            EmpleadosDGV.DataSource = null;
            EmpleadosDGV.DataSource = empleadoBLL.Consultar();

            // Actualizar elemementos
            Empleado empleado = (Empleado)EmpleadosDGV.Rows[0].DataBoundItem;
            MapearDesdeObjeto(empleado);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Empleado pEmpleado)
        {
            IdTXT.Text = pEmpleado.Id.ToString();
            DNITXT.Text = pEmpleado.DNI.ToString();
            NombreApellidoTXT.Text = pEmpleado.NombreApellido;
            FechaAltaDTP.Text = pEmpleado.FechaAlta.ToString();
            PuestoCBX.Text = pEmpleado.Puesto;
            DireccionTXT.Text = pEmpleado.Direccion;
            TelefonoTXT.Text = pEmpleado.Telefono;
            EmailTXT.Text = pEmpleado.Email;

            // Autenticación
            UsernameTXT.Text = pEmpleado.Username;
            PasswordTXT.Text = Criptografia.Desencriptar(pEmpleado.Password);
            IntentoTXT.Text = pEmpleado.Intento.ToString();
        }
        private Empleado MapearHaciaObjeto()
        {
            Empleado empleado = new Empleado
            {
                Id = int.Parse(IdTXT.Text),
                DNI = int.Parse(DNITXT.Text),
                NombreApellido = NombreApellidoTXT.Text.ToString(),
                FechaAlta = DateTime.Parse(FechaAltaDTP.Text),
                Puesto = PuestoCBX.Text,
                Direccion = DireccionTXT.Text,
                Telefono = TelefonoTXT.Text,
                Email = EmailTXT.Text,

                // Autenticación
                Username = UsernameTXT.Text,
                Password = Criptografia.Encriptar(PasswordTXT.Text),
                Intento = int.Parse(IntentoTXT.Text)
            };
            return empleado;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS

        private void EmpleadosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Empleado empleado = (Empleado)EmpleadosDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(empleado);
            }
        }

        private void EmpleadosDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Empleado empleado = (Empleado)EmpleadosDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(empleado);
            }
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABM

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            if (empleadoBLL.YaExisteDNI(int.Parse(DNITXT.Text)))
            {
                MessageBox.Show($"DNI {DNITXT.Text} ya existe.");
                return;
            }

            if (empleadoBLL.YaExisteUsername(UsernameTXT.Text))
            {
                MessageBox.Show($"Usuario {UsernameTXT.Text} ya existe.");
                return;
            }

            Empleado empleado = MapearHaciaObjeto();
            empleadoBLL.Agregar(empleado);
            ActualizarPantalla();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearHaciaObjeto();
            empleadoBLL.Eliminar(empleado.Id);
            ActualizarPantalla();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            Empleado empleado = MapearHaciaObjeto();
            empleadoBLL.Modificar(empleado);
            ActualizarPantalla();
        }
    }
}
