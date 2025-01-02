using BEL;

using SRV;

using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class RestauracionForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO
        //public string Username { get; set; }
        //public string NombreApellido { get; set; }
        Empleado empleado;

        public RestauracionForm(Empleado pEmpleado)
        {
            InitializeComponent();
            //Username = pUsername;
            //EmpleadoBLL empleadoBLL = new EmpleadoBLL();
            //Empleado empleado = empleadoBLL.GetByUsername(Username);
            //NombreApellido = empleado.NombreApellido;
            empleado = pEmpleado;
        }

        private void RestauracionForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Restauraciones - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            // Actualizar listado
            RespaldosDGV.DataSource = null;
            RespaldosDGV.DataSource = Archivador.ConsultarRespaldos();

            // Actualizar elemementos
            Bitacora bitacora = (Bitacora)RespaldosDGV.Rows[0].DataBoundItem;
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

        private void RespaldosDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Bitacora bitacora = (Bitacora)RespaldosDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(bitacora);
            }
        }

        private void RespaldosDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Bitacora bitacora = (Bitacora)RespaldosDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(bitacora);
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BOTONERA

        private void RespaldarBTN_Click(object sender, EventArgs e)
        {
            try
            {
                Archivador.Restaurar
                    (
                    int.Parse(IdTXT.Text),
                    empleado.NombreApellido,
                    DescribirTextbox.Text
                    );
                
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

                MessageBox.Show
                    (
                    "Ha ocurrido un error",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
