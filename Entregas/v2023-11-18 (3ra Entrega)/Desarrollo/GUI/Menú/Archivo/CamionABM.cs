using BEL;

using BLL;

using System;
using System.Windows.Forms;

/*
Con e (event): Camion camion = (Camion)CamionesDGV.Rows[e.RowIndex].DataBoundItem;
Sin e (event): Camion camion = (Camion)CamionesDGV.CurrentRow.DataBoundItem;
*/

namespace GUI
{
    public partial class CamionABM : BaseForm
    {
        Empleado empleado;
        readonly CamionBLL camionBLL;
        public CamionABM(Empleado pEmpleado)
        {
            InitializeComponent();
            camionBLL = new CamionBLL();
            this.empleado = pEmpleado;
        }

        private void CamionFRM_Load(object sender, EventArgs e)
        {
            this.Text = $"Camiones - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            // Actualizar listado
            CamionesDGV.DataSource = null;
            CamionesDGV.DataSource = camionBLL.Consultar();

            // Actualizar elemementos
            Camion camion = (Camion)CamionesDGV.Rows[0].DataBoundItem;
            MapearDesdeObjeto(camion);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Camion pCamion)
        {
            IdTXT.Text = pCamion.Id.ToString();
            PatenteTXT.Text = pCamion.Patente;
            MarcaTXT.Text = pCamion.Marca;
        }
        private Camion MapearHaciaObjeto()
        {
            Camion camion = new Camion
            {
                Id = int.Parse(IdTXT.Text),
                Patente = PatenteTXT.Text,
                Marca = MarcaTXT.Text
            };
            return camion;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS

        private void CamionesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Camion camion = (Camion)CamionesDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(camion);
            }
        }

        private void CamionesDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Camion camion = (Camion)CamionesDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(camion);
            }
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABM

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            Camion camion = MapearHaciaObjeto();
            camionBLL.Agregar(camion);
            ActualizarPantalla();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            Camion camion = MapearHaciaObjeto();
            camionBLL.Eliminar(camion.Id);
            ActualizarPantalla();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            Camion camion = MapearHaciaObjeto();
            camionBLL.Modificar(camion);
            ActualizarPantalla();
        }
    }
}
