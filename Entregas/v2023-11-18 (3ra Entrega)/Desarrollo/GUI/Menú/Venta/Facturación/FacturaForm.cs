using BEL;

using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FacturaForm : Form
    {
        public List<FacturaReporte> ListaFacturas { get; set; }
        public List<Mueble> ListaMuebles { get; set; }
        public FacturaForm
            (
            List<FacturaReporte> pListaFacturas,
            List<Mueble> pListaMuebles
            )
        {
            InitializeComponent();
            ListaFacturas = pListaFacturas;
            ListaMuebles = pListaMuebles;
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            FacturaReportviewer.LocalReport.DataSources.Clear();
            FacturaReportviewer.LocalReport.DataSources.Add(new ReportDataSource("FacturaDataset", ListaFacturas));
            FacturaReportviewer.LocalReport.DataSources.Add(new ReportDataSource("MueblesDataset", ListaMuebles));
            FacturaReportviewer.RefreshReport();
        }
    }
}
