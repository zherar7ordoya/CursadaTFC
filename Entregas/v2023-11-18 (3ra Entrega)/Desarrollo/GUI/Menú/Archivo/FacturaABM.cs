using BEL;

using BLL;

using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class FacturaABM : BaseForm
    {
        Empleado empleado;
        readonly FacturaBLL facturaBLL;
        public FacturaABM(Empleado pEmpleado)
        {
            InitializeComponent();
            facturaBLL = new FacturaBLL();
            this.empleado = pEmpleado;
        }

        private void FacturaFRM_Load(object sender, EventArgs e)
        {
            this.Text = $"Facturas - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            // Actualizar listado
            FacturasDGV.DataSource = null;
            FacturasDGV.DataSource = facturaBLL.Consultar();

            // Actualizar elemementos
            Factura factura = (Factura)FacturasDGV.Rows[0].DataBoundItem;
            MapearDesdeObjeto(factura);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Factura pFactura)
        {
            IdTXT.Text = pFactura.Id.ToString();
            FechaDTP.Text = pFactura.Fecha.ToString();
            MontoOrdenTXT.Text = pFactura.MontoOrden.ToString("C");
            ImpuestoTXT.Text = pFactura.Impuesto.ToString("C");
            TotalTXT.Text = pFactura.Total.ToString("C");
            OrdenIDTXT.Text = pFactura.OrdenID.ToString();
        }
        private Factura MapearHaciaObjeto()
        {
            Factura factura = new Factura
            {
                Id = int.Parse(IdTXT.Text),
                Fecha = DateTime.Parse(FechaDTP.Text),
                MontoOrden=float.Parse(MontoOrdenTXT.Text.TrimStart('$')),
                Impuesto=float.Parse(ImpuestoTXT.Text.TrimStart('$')),
                Total=float.Parse(TotalTXT.Text.TrimStart('$')),
                OrdenID=int.Parse(OrdenIDTXT.Text)
            };
            return factura;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS

        private void FacturasDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Factura factura = (Factura)FacturasDGV.Rows[e.RowIndex].DataBoundItem;
                MapearDesdeObjeto(factura);
            }
        }

        private void FacturasDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is float || e.Value is double || e.Value is decimal)
            {
                e.Value = string.Format("{0:C}", e.Value);
                e.FormattingApplied = true;
            }
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABM

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            Factura factura = MapearHaciaObjeto();
            facturaBLL.Agregar(factura);
            ActualizarPantalla();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            Factura factura = MapearHaciaObjeto();
            facturaBLL.Eliminar(factura.Id);
            ActualizarPantalla();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            Factura factura = MapearHaciaObjeto();
            facturaBLL.Modificar(factura);
            ActualizarPantalla();
        }
    }
}
