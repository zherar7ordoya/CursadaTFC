using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class DashboardForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO

        Empleado empleado;
        readonly FacturaBLL facturaBLL;
        public DashboardForm(Empleado pEmpleado)
        {
            InitializeComponent();
            facturaBLL = new FacturaBLL();
            empleado = pEmpleado;
        }

        private void VentaChart_Load(object sender, EventArgs e)
        {
            this.Text = $"Dashboard de Ventas - {empleado.NombreApellido}";
            CargarChart();
        }

        private void CargarChart()
        {
            

            List<Factura> facturas = facturaBLL.Consultar();

            // Definir un título para el chart
            Title titulo = new Title("Chart de Ventas");
            titulo.Font = new Font("Tahoma", 20, FontStyle.Bold);
            VentasChart.Titles.Add(titulo);

            // Supongamos que ya tienes una serie creada con el nombre predeterminado "Series1"
            Series serie = VentasChart.Series["Series1"];
            serie.Name = "Facturación";

            // Configurar el formato del eje Y con signo monetario
            VentasChart.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "C";

            // Cargar los datos en el Chart
            VentasChart.Series["Facturación"].Points.DataBindXY(
                facturas.Select(f => f.Fecha).ToArray(),
                facturas.Select(f => f.Total).ToArray());

            // Personalizar el Chart
            VentasChart.Titles.Add("Facturas Totales");
            VentasChart.ChartAreas["ChartArea1"].AxisX.Title = "Fecha";
            VentasChart.ChartAreas["ChartArea1"].AxisY.Title = "Total";
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS

        private void TipoCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            VentasChart.Series["Facturación"].ChartType =
                (SeriesChartType)Enum.Parse(typeof(SeriesChartType),
                TipoCBX.SelectedItem.ToString());
        }

        private void ColorCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            VentasChart.Palette = 
                (ChartColorPalette)Enum.Parse(typeof(ChartColorPalette),
                ColorCBX.SelectedItem.ToString());
        }

        private void ExportarBTN_Click(object sender, EventArgs e)
        {
            string nombre = NombreTXT.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe especificar un nombre de archivo.");
                return;
            }

            string formato = FormatoCBX.Text;
            if (string.IsNullOrEmpty(formato))
            {
                MessageBox.Show("Debe especificar un formato de archivo.");
                return;
            }

            string archivo = $"{nombre}.{formato}";

            VentasChart.SaveImage(
            archivo,
            (ChartImageFormat)Enum.Parse(typeof(ChartImageFormat),
            formato));

            MessageBox.Show("Imagen guardada");
        }
    }
}


