using BEL;

using BLL;

using PdfSharp.Drawing;
using PdfSharp.Pdf;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class LiquidacionForm : BaseForm
    {

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO

        readonly Empleado empleado;
        Orden orden;
        readonly OrdenBLL ordenBLL = new OrdenBLL();
        private float reembolso = 0;
        Liquidacion liquidacion;
        readonly LiquidacionBLL liquidacionBLL = new LiquidacionBLL();


        public LiquidacionForm(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
        }

        private void LiquidacionForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Liquidación - {empleado.NombreApellido}";
            CargarTreeview();
            OrdenesTreeview.AfterSelect += OrdenesTreeview_AfterSelect;
        }



        private void CargarTreeview()
        {
            // Recuperar las órdenes con estado "Pagado"
            List<Orden> ordenes = ordenBLL.ListarEstadoTransito();

            // Configuración del TreeView
            OrdenesTreeview.Nodes.Clear();

            // Llena el TreeView con la lista de mudanzas
            foreach (var orden in ordenes)
            {
                // Almacena el objeto en el Tag, necesario luego en el evento AfterSelect
                var ordenNode = new TreeNode($"Orden {orden.Id}")
                {
                    Tag = orden
                };

                ordenNode.Nodes.Add($"Estado: {orden.Estado}");
                ordenNode.Nodes.Add($"Fecha: {orden.ServicioFecha}");
                ordenNode.Nodes.Add($"Dirección de origen: {orden.DireccionOrigen}");
                ordenNode.Nodes.Add($"Descripción del lugar de carga: {orden.DescripcionLugarCarga}");
                ordenNode.Nodes.Add($"Dirección de destino: {orden.DireccionDestino}");
                ordenNode.Nodes.Add($"Descripción del lugar de descarga: {orden.DescripcionLugarDescarga}");

                var mueblesNode = new TreeNode("Muebles");
                foreach (var mueble in orden.Muebles)
                {
                    mueblesNode.Nodes.Add($"Cantidad: {mueble.Cantidad}, Descripción: {mueble.Descripcion}");
                }
                ordenNode.Nodes.Add(mueblesNode);

                ordenNode.Nodes.Add($"Observaciones: {orden.Observaciones}");
                ordenNode.Nodes.Add($"Distancia en kilómetros: {orden.KilometrosDistancia}");
                ordenNode.Nodes.Add($"Monto: {orden.Monto}");

                ordenNode.Nodes.Add($"Cliente ID: {orden.ClienteID}");

                // Agrega el nodo de Mudanza al TreeView
                OrdenesTreeview.Nodes.Add(ordenNode);
            }

        }

        private void OrdenesTreeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;

            if (node != null)
            {
                while (node.Parent != null)
                {
                    node = node.Parent;
                }
            }

            MapearDesdeObjetoOrden(node?.Tag as Orden);
        }

        private void MapearDesdeObjetoOrden(Orden pOrden)
        {
            OrdenIdTextbox.Text = pOrden.Id.ToString();
            OrdenFechaDatetimepicker.Text = pOrden.ServicioFecha.ToString();
            OrdenOrigenTextbox.Text = pOrden.DireccionOrigen;
            OrdenDestinoTextbox.Text = pOrden.DireccionDestino;
            OrdenDistanciaTextbox.Text = pOrden.KilometrosDistancia.ToString();
            OrdenMontoTextbox.Text = pOrden.Monto.ToString();
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private void CalcularLiquidacionButton_Click(object sender, EventArgs e)
        {
            SumarComprobantes();
            CalcularLiquidacion();
        }


        private void SumarComprobantes()
        {
            reembolso = 0;

            // Recorrer todas las filas y sumar los montos
            foreach (DataGridViewRow row in ComprobantesDGV.Rows)
            {
                if
                    (
                    row.Cells[2].Value != null && 
                    float.TryParse(row.Cells[2].Value.ToString(), out float monto) &&
                    !row.IsNewRow
                    )
                {
                    reembolso += monto;
                }
            }
            LiquidacionReembolsoTextbox.Text = reembolso.ToString();
        }

        private void CalcularLiquidacion()
        {
            float montoReembolso = float.TryParse(LiquidacionReembolsoTextbox.Text, out float result) ? result : 0;
            float montoOrden = float.TryParse(OrdenMontoTextbox.Text, out float resultado) ? resultado : 0;
            float montoComision = montoOrden * 0.15f;
            float montoTotal = montoReembolso + montoComision;

            LiquidacionReembolsoTextbox.Text = montoReembolso.ToString();
            LiquidacionMontoTextbox.Text = montoOrden.ToString();
            LiquidacionComisionTextbox.Text = montoComision.ToString();
            LiquidacionTotalTextbox.Text = montoTotal.ToString();
        }



















        private void GenerarNotaLiquidacionButton_Click(object sender, EventArgs e)
        {
            GrabarLiquidacion();
            CrearPDF();
            CargarTreeview();



        }



        private void GrabarLiquidacion()
        {
            Liquidacion nueva = MapearHaciaObjeto();
            liquidacionBLL.Agregar(nueva);
            liquidacion = liquidacionBLL.BuscarPorOrdenId(nueva.OrdenID);
            LiquidacionIdTextbox.Text = liquidacion.Id.ToString();

            orden = ordenBLL.BuscarPorId(nueva.OrdenID);
            orden.Estado = "Completado";
            ordenBLL.Modificar(orden);

            MessageBox.Show("Mudanza grabada");
        }


        private Liquidacion MapearHaciaObjeto()
        {
            return new Liquidacion
            {
                Fecha = DateTime.Parse(LiquidacionFechaDatetimepicker.Text),

                Comprobantes = DesdeComprobantesDGV(),

                MontoOrden = float.Parse(LiquidacionMontoTextbox.Text.TrimStart('$')),
                MontoReembolso = float.Parse(LiquidacionReembolsoTextbox.Text.TrimStart('$')),
                Total = float.Parse(LiquidacionTotalTextbox.Text.TrimStart('$')),
                OrdenID = int.Parse(OrdenIdTextbox.Text)
            };
        }
        private List<Comprobante> DesdeComprobantesDGV()
        {
            List<Comprobante> comprobantes = new List<Comprobante>();

            foreach (DataGridViewRow comprobante in ComprobantesDGV.Rows)
            {
                if (!comprobante.IsNewRow)
                {
                    DateTime fecha = DateTime.Parse(comprobante.Cells["Fecha"].Value.ToString());
                    string detalle = comprobante.Cells["Detalle"].Value.ToString();
                    float monto = float.Parse(comprobante.Cells["Monto"].Value.ToString());

                    comprobantes.Add(new Comprobante
                    {
                        Fecha = fecha,
                        Detalle = detalle,
                        Monto = monto
                    });
                }
            }
            return comprobantes;
        }


        private void CrearPDF()
        {
            // Crear un documento PDF
            PdfDocument document = new PdfDocument();

            // Añadir una página
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12, XFontStyle.Regular);

            // Definir posiciones
            int xLeft = 50;
            int xRight = 400;
            int y = 50;
            int lineHeight = 15;

            // Cabecera
            gfx.DrawString("Fecha: " + LiquidacionFechaDatetimepicker.Text, font, XBrushes.Black, xLeft, y);
            y += lineHeight;
            gfx.DrawString("Nota de Liquidación ID: " + LiquidacionIdTextbox.Text.PadLeft(5, '0'), font, XBrushes.Black, xLeft, y);

            // Línea divisoria
            y += 2 * lineHeight;
            gfx.DrawLine(XPens.Black, xLeft, y, xRight + 100, y);

            // Sección 1: información de la orden de pedido
            y += lineHeight;
            gfx.DrawString("Orden ID: " + OrdenIdTextbox.Text, font, XBrushes.Black, xLeft, y);
            y += lineHeight;
            gfx.DrawString("Origen: " + OrdenOrigenTextbox.Text, font, XBrushes.Black, xLeft, y + lineHeight);
            gfx.DrawString("Destino: " + OrdenDestinoTextbox.Text, font, XBrushes.Black, xLeft, y + 2 * lineHeight);
            gfx.DrawString("Distancia: " + OrdenDistanciaTextbox.Text + " km", font, XBrushes.Black, xLeft, y + 3 * lineHeight);
            gfx.DrawString("Monto: $" + OrdenMontoTextbox.Text, font, XBrushes.Black, xLeft, y + 4 * lineHeight);

            // Línea divisoria
            y += 6 * lineHeight;
            gfx.DrawLine(XPens.Black, xLeft, y, xRight + 100, y);

            // Sección 2: comprobantes de gastos presentados
            y += lineHeight;
            gfx.DrawString("Comprobantes de Gastos Presentados:", font, XBrushes.Black, xLeft, y);

            // DataGridView de Comprobantes
            y += 2 * lineHeight;
            DrawDataGridView(gfx, ComprobantesDGV, xLeft, ref y);

            // Línea divisoria
            y += 2 * lineHeight;
            gfx.DrawLine(XPens.Black, xLeft, y, xRight + 100, y);

            // Sección 3: liquidación
            y += lineHeight;
            gfx.DrawString("Liquidación:", font, XBrushes.Black, xLeft, y);

            // Reembolso (suma de los comprobantes)
            y += lineHeight;
            gfx.DrawString("Reembolso: $" + CalcularSumaComprobantes().ToString(), font, XBrushes.Black, xLeft, y);

            // Monto de la orden
            y += lineHeight;
            gfx.DrawString("Monto de la Orden: $" + LiquidacionMontoTextbox.Text, font, XBrushes.Black, xLeft, y);

            // Monto de la comisión (porcentaje sobre el monto de la orden)
            y += lineHeight;
            double porcentajeComision = 0.15; 
            double montoComision = double.Parse(LiquidacionMontoTextbox.Text) * porcentajeComision;
            gfx.DrawString($"Comisión ({porcentajeComision * 100}%): ${montoComision}", font, XBrushes.Black, xLeft, y);

            // Total (suma de reembolso y comisión)
            y += lineHeight;
            double total = CalcularSumaComprobantes() + montoComision;
            gfx.DrawString("Total: $" + total.ToString(), font, XBrushes.Black, xLeft, y);

            // Guardar el documento PDF con el nombre "Mudanza" + Nota de Liquidación ID
            string liquidacionNumber = LiquidacionIdTextbox.Text.PadLeft(5, '0');
            string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Liquidacion{liquidacionNumber}.pdf");
            document.Save(pdfFilePath);

            // Abrir el PDF generado
            Process.Start(pdfFilePath);
        }

        private double CalcularSumaComprobantes()
        {
            double suma = 0;
            foreach (DataGridViewRow row in ComprobantesDGV.Rows)
            {
                if (!row.IsNewRow)
                {
                    suma += double.Parse(row.Cells[2].Value.ToString());
                }
            }
            return suma;
        }

        private void DrawDataGridView(XGraphics gfx, DataGridView dataGridView, int x, ref int y)
        {
            XFont font = new XFont("Arial", 12, XFontStyle.Regular);
            int headerHeight = 20;
            int rowHeight = 15;
            int width = 200;

            // Dibujar encabezado
            gfx.DrawRectangle(XPens.Black, x, y, width, headerHeight);
            gfx.DrawString("Fecha", font, XBrushes.Black, x, y);
            gfx.DrawString("Detalle", font, XBrushes.Black, x + 80, y);
            gfx.DrawString("Monto", font, XBrushes.Black, x + 160, y);

            // Dibujar filas
            y += headerHeight;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, width, rowHeight);
                    gfx.DrawString(row.Cells[0].Value.ToString(), font, XBrushes.Black, x, y);
                    gfx.DrawString(row.Cells[1].Value.ToString(), font, XBrushes.Black, x + 80, y);
                    gfx.DrawString(row.Cells[2].Value.ToString(), font, XBrushes.Black, x + 160, y);

                    y += rowHeight;
                }
            }
        }

        private void CancelarOrdenButton_Click(object sender, EventArgs e)
        {
            orden = ordenBLL.BuscarPorId(int.Parse(OrdenIdTextbox.Text));
            orden.Estado = "Cancelado";
            ordenBLL.Modificar(orden);
            MessageBox.Show("Orden cancelada");
        }
    }
}
