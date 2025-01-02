using BEL;

using System;
using System.Windows.Forms;

using SRV;

namespace GUI
{

    public partial class RespaldoForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO
        //public string Username { get; set; }
        //public string NombreApellido { get; set; }
        Empleado empleado;

        public RespaldoForm(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
            //Username = pUsername;
            //EmpleadoBLL empleadoBLL = new EmpleadoBLL();
            //Empleado empleado = empleadoBLL.GetByUsername(Username);
            //NombreApellido = empleado.NombreApellido;
        }

        private void RespaldoForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Respaldos - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            // Actualizar listado
            BitacorasDGV.DataSource = null;
            BitacorasDGV.DataSource = Archivador.ConsultarTodo();

            // Actualizar elemementos
            Bitacora bitacora = (Bitacora)BitacorasDGV.Rows[0].DataBoundItem;
            MapearDesdeObjeto(bitacora);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Bitacora pBitacora)
        {
            IdTXT.Text = pBitacora.Id.ToString();
            FechaHoraTXT.Text = pBitacora.FechaHora.ToString();
            UsuarioTXT.Text = pBitacora.Usuario;
            TipoTXT.Text = pBitacora.Tipo;
            DescripcionTXT.Text = pBitacora.Descripcion;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS

        private void BitacorasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Bitacora bitacora = (Bitacora)BitacorasDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(bitacora);
            }
        }

        private void BitacorasDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Bitacora bitacora = (Bitacora)BitacorasDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(bitacora);
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BOTONERA

        private void RespaldarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Archivador.Respaldar(empleado.NombreApellido, DescribirTextbox.Text);

                MessageBox.Show
                    (
                    "Se realizó con éxito el respaldo de los archivos",
                    "Operación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                ActualizarPantalla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    "Ha ocurrido un error",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
