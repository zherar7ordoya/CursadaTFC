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
    public partial class DespachoForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO

        readonly Empleado empleado;
        Orden orden = new Orden();
        readonly OrdenBLL ordenBLL = new OrdenBLL();
        Mudanza mudanza = new Mudanza();
        MudanzaBLL mudanzaBLL = new MudanzaBLL();


        public DespachoForm(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
        }

        private void DespachoForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Despacho - {empleado.NombreApellido}";
            CargarTreeview();
            OrdenesTreeview.AfterSelect += OrdenesTreeview_AfterSelect;
        }


        private void CargarTreeview()
        {
            // Recuperar las órdenes con estado "Pagado"
            List<Orden> ordenes = ordenBLL.ListarEstadoPagado();

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
            OrdenLugarCargaTextbox.Text = pOrden.DescripcionLugarCarga;
            OrdenDestinoTextbox.Text = pOrden.DireccionDestino;
            OrdenLugarDescargaTextbox.Text = pOrden.DescripcionLugarDescarga;
            OrdenObservacionesTextbox.Text = pOrden.Observaciones;
            OrdenDistanciaTextbox.Text = pOrden.KilometrosDistancia.ToString();

            HaciaMueblesDGV(pOrden.Muebles);
        }


        private void HaciaMueblesDGV(List<Mueble> pMuebles)
        {
            MueblesDGV.Rows.Clear();
            MueblesDGV.Columns.Clear();

            MueblesDGV.Columns.Add("Cantidad", "Cantidad");
            MueblesDGV.Columns.Add("Descripcion", "Descripción");

            foreach (var mueble in pMuebles)
            {
                MueblesDGV.Rows.Add(mueble.Cantidad, mueble.Descripcion);
            }
        }



        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private Mudanza MapearHaciaObjeto()
        {
            Mudanza mudanza = new Mudanza
            {
                Fecha = DateTime.Parse(MudanzaFechaDatetimepicker.Text),
                Camion = new Camion
                {
                    Patente = PatenteTextbox.Text,
                    Marca = MarcaTextbox.Text
                },
                Chofer = new Empleado
                {
                    DNI = int.Parse(DNITextbox.Text),
                    NombreApellido = NombreApellidoTextbox.Text
                },
                Estibadores = DesdeEstibadoresDGV(),
                Insumos = DesdeInsumosDGV(),
                OrdenID = int.Parse(OrdenIdTextbox.Text)
            };

            return mudanza;
        }

        private List<Empleado> DesdeEstibadoresDGV()
        {
            List<Empleado> estibadores = new List<Empleado>();

            foreach (DataGridViewRow fila in EstibadoresDGV.Rows)
            {
                if (fila.Cells["DNI"].Value != null && fila.Cells["NombreApellido"].Value != null)
                {
                    if (int.TryParse(fila.Cells["DNI"].Value.ToString(), out int dni))
                    {
                        string nombreApellido = fila.Cells["NombreApellido"].Value.ToString();
                        estibadores.Add(new Empleado { DNI = dni, NombreApellido = nombreApellido });
                    }
                }
            }
            return estibadores;
        }

        private List<Insumo> DesdeInsumosDGV()
        {
            List<Insumo> insumos = new List<Insumo>();

            foreach (DataGridViewRow fila in InsumosDGV.Rows)
            {
                if (fila.Cells["Cantidad"].Value != null && fila.Cells["Descripcion"].Value != null)
                {
                    int cantidad;
                    if (int.TryParse(fila.Cells["Cantidad"].Value.ToString(), out cantidad))
                    {
                        string descripcion = fila.Cells["Descripcion"].Value.ToString();
                        insumos.Add(new Insumo { Cantidad = cantidad, Descripcion = descripcion });
                    }
                }
            }

            return insumos;
        }


        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private void GenerarNotaMudanzaButton_Click(object sender, EventArgs e)
        {
            GrabarMudanza();
            CrearPDF();
            CargarTreeview();
        }


        private void GrabarMudanza()
        {
            Mudanza nueva = MapearHaciaObjeto();
            mudanzaBLL.Agregar(nueva);
            mudanza = mudanzaBLL.BuscarPorOrdenId(nueva.OrdenID);
            MudanzaIdTextbox.Text = mudanza.Id.ToString();

            orden = ordenBLL.BuscarPorId(nueva.OrdenID);
            orden.Estado = "Tránsito";
            ordenBLL.Modificar(orden);

            MessageBox.Show("Mudanza grabada");
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
            gfx.DrawString("Fecha: " + MudanzaFechaDatetimepicker.Text, font, XBrushes.Black, xLeft, y);
            y += lineHeight;
            gfx.DrawString("Nota de Mudanza ID: " + MudanzaIdTextbox.Text.PadLeft(5, '0'), font, XBrushes.Black, xLeft, y);

            // Línea divisoria
            y += 2 * lineHeight;
            gfx.DrawLine(XPens.Black, xLeft, y, xRight + 100, y);

            // Primera sección: información de la orden de pedido
            y += lineHeight;
            gfx.DrawString("Orden ID: " + OrdenIdTextbox.Text, font, XBrushes.Black, xLeft, y);
            y += lineHeight;
            gfx.DrawString("Fecha de Servicio: " + OrdenFechaDatetimepicker.Text, font, XBrushes.Black, xLeft, y);
            gfx.DrawString("Origen: " + OrdenOrigenTextbox.Text, font, XBrushes.Black, xLeft, y + lineHeight);
            gfx.DrawString("Descripción del lugar de carga: " + OrdenLugarCargaTextbox.Text, font, XBrushes.Black, xLeft, y + 2 * lineHeight);
            gfx.DrawString("Destino: " + OrdenDestinoTextbox.Text, font, XBrushes.Black, xLeft, y + 3 * lineHeight);
            gfx.DrawString("Descripción del lugar de descarga: " + OrdenLugarDescargaTextbox.Text, font, XBrushes.Black, xLeft, y + 4 * lineHeight);

            // Segunda sección: lista de muebles a transportar
            y += 6 * lineHeight;
            gfx.DrawString("Lista de Muebles a Transportar:", font, XBrushes.Black, xLeft, y);

            // DataGridView de Muebles
            y += 2 * lineHeight;
            DrawDataGridView(gfx, MueblesDGV, xLeft, ref y);

            // Observaciones
            y += 2 * lineHeight;
            gfx.DrawString("Observaciones: " + OrdenObservacionesTextbox.Text, font, XBrushes.Black, xLeft, y);

            // Tercera sección: asignaciones
            y += 2 * lineHeight;
            gfx.DrawString("Asignaciones:", font, XBrushes.Black, xLeft, y);

            // Camión
            y += lineHeight;
            gfx.DrawString("Camión - Patente: " + PatenteTextbox.Text, font, XBrushes.Black, xLeft, y);
            gfx.DrawString("Camión - Marca: " + MarcaTextbox.Text, font, XBrushes.Black, xLeft, y + lineHeight);

            // Chofer
            y += 2 * lineHeight;
            gfx.DrawString("Chofer - DNI: " + DNITextbox.Text, font, XBrushes.Black, xLeft, y);
            gfx.DrawString("Chofer - Nombre: " + NombreApellidoTextbox.Text, font, XBrushes.Black, xLeft, y + lineHeight);

            // DataGridView de Estibadores
            y += 2 * lineHeight;
            gfx.DrawString("Estibadores:", font, XBrushes.Black, xLeft, y);
            y += 2 * lineHeight;
            DrawDataGridView(gfx, EstibadoresDGV, xLeft, ref y);

            // DataGridView de Insumos
            y += 2 * lineHeight;
            gfx.DrawString("Insumos:", font, XBrushes.Black, xLeft, y);
            y += 2 * lineHeight;
            DrawDataGridView(gfx, InsumosDGV, xLeft, ref y);

            // Guardar el documento PDF con el nombre "Mudanza" + Nota de Mudanza ID
            string mudanzaNumber = MudanzaIdTextbox.Text.PadLeft(5, '0');
            string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Mudanza{mudanzaNumber}.pdf");
            document.Save(pdfFilePath);

            // Abrir el PDF generado
            Process.Start(pdfFilePath);
        }













        private void DrawDataGridView(XGraphics gfx, DataGridView dataGridView, int x, ref int y)
        {
            XFont font = new XFont("Arial", 12, XFontStyle.Regular);

            int headerHeight = 20;
            int rowHeight = 15;
            int width = 200;

            // Dibujar encabezado
            gfx.DrawRectangle(XPens.Black, x, y, width, headerHeight);
            gfx.DrawString("Cantidad", font, XBrushes.Black, x, y);
            gfx.DrawString("Descripción", font, XBrushes.Black, x + 80, y);

            // Dibujar filas
            y += headerHeight;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, width, rowHeight);
                    gfx.DrawString(row.Cells[0].Value.ToString(), font, XBrushes.Black, x, y);
                    gfx.DrawString(row.Cells[1].Value.ToString(), font, XBrushes.Black, x + 80, y);

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
