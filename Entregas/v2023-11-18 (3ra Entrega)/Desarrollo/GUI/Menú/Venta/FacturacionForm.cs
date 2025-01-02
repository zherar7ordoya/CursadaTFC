using BEL;

using BLL;

using Microsoft.Reporting.WinForms;

using PdfSharp.Drawing;
using PdfSharp.Pdf;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class FacturacionForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO

        readonly Empleado empleado;

        Cliente cliente = new Cliente();
        ClienteBLL clienteBLL = new ClienteBLL();

        Orden orden = new Orden();
        OrdenBLL ordenBLL = new OrdenBLL();

        Factura factura = new Factura();
        FacturaBLL facturaBLL = new FacturaBLL();

        public FacturacionForm(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
        }

        private void FacturacionForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Facturación - {empleado.NombreApellido}";
            CargarTreeview();
            OrdenesTreeview.AfterSelect += OrdenesTreeview_AfterSelect;
            ContadoRadiobutton.CheckedChanged += ViaContado;
            TransferenciaRadiobutton.CheckedChanged += ViaTransferencia;
            //this.miReportViewer.RefreshReport();
        }


        private void CargarTreeview()
        {
            // Recuperar las órdenes con estado "Solicitado"
            List<Orden> ordenes = ordenBLL.ListarEstadoSolicitado();

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

            MapearDesdeObjetoCliente(pOrden.ClienteID);
        }

        private void MapearDesdeObjetoCliente(int pId)
        {
            cliente = clienteBLL.BuscarPorId(pId);
            Cliente_DNI_o_CUIT_Textbox.Text = cliente.DNI_o_CUIT;
            ClienteNombreTextbox.Text = cliente.NombreApellido_o_RazonSocial;
            ClienteDireccionTextbox.Text = cliente.Direccion;

            CompletarDatosFactura();
        }

        private void CompletarDatosFactura()
        {
            string detalle =
                $"Fecha de mudanza: {OrdenFechaDatetimepicker.Text}\n" +
                $"Dirección de Origen: {OrdenOrigenTextbox.Text}\n" +
                $"Dirección de Destino: {OrdenDestinoTextbox.Text}\n" +
                $"Distancia a cubrir: {OrdenDistanciaTextbox.Text}";
            FacturaDetalleTextbox.Text = detalle;
            FacturaSubtotalTextbox.Text = OrdenMontoTextbox.Text;
            float subtotal = float.Parse(FacturaSubtotalTextbox.Text);
            float impuesto = subtotal * 0.15f;
            float total = subtotal + impuesto;
            FacturaImpuestoTextbox.Text = impuesto.ToString();
            FacturaTotalTextbox.Text = total.ToString();
        }

        private void ViaContado(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                if (radio.Checked)
                {
                    MessageBox.Show("Ingrese el dinero en caja y luego indique que el pago ha sido verificado");
                }
            }
        }

        private void ViaTransferencia(object sender, EventArgs e)
        {
            if (sender is RadioButton radio)
            {
                if (radio.Checked)
                {
                    VerificacionForm formulario = new VerificacionForm(empleado);
                    DialogResult result = formulario.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show("De corresponder, indique que el pago ha sido verificado");
                    }
                }
            }
        }

        private void PagoVerificadoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PagoVerificadoCheckbox.Checked)
            {
                GenerarFacturaButton.Enabled = true;
            }
            else
            {
                GenerarFacturaButton.Enabled = false;
            }
        }

        private void GenerarFacturaButton_Click(object sender, EventArgs e)
        {
            GrabarFactura();
            CrearPDF();
            CargarTreeview();
        }

        private void GrabarFactura()
        {
            Factura nueva = new Factura
            {
                Fecha = FacturaFechaDatetimepicker.Value,
                MontoOrden = float.Parse(FacturaSubtotalTextbox.Text),
                Impuesto = float.Parse(FacturaImpuestoTextbox.Text),
                Total = float.Parse(FacturaTotalTextbox.Text),
                OrdenID = int.Parse(OrdenIdTextbox.Text)
            };
            facturaBLL.Agregar(nueva);
            factura = facturaBLL.BuscarPorOrdenId(nueva.OrdenID);
            FacturaIdTextbox.Text = factura.Id.ToString();
            orden = ordenBLL.BuscarPorId(nueva.OrdenID);
            orden.Estado = "Pagado";
            ordenBLL.Modificar(orden);
            MessageBox.Show("Factura grabada");
        }

        private void CrearPDF()
        {
            FacturaReporte factura = new FacturaReporte
            {
                //Cliente
                ClienteDNI_o_CUIT = int.Parse(Cliente_DNI_o_CUIT_Textbox.Text),
                ClienteNombre = ClienteNombreTextbox.Text,
                ClienteDireccion = ClienteDireccionTextbox.Text,

                //Orden
                OrdenID = int.Parse(OrdenIdTextbox.Text),
                OrdenFechaServicio = DateTime.Parse(OrdenFechaDatetimepicker.Text),
                OrdenOrigen = OrdenOrigenTextbox.Text,
                OrdenDestino = OrdenDestinoTextbox.Text,
                OrdenDistancia = int.Parse(OrdenDistanciaTextbox.Text),
                OrdenMonto = float.Parse(OrdenMontoTextbox.Text),

                //Factura
                FacturaID = int.Parse(FacturaIdTextbox.Text),
                FacturaFecha = DateTime.Parse(FacturaFechaDatetimepicker.Text),
                FacturaImpuesto = float.Parse(FacturaImpuestoTextbox.Text),
                FacturaTotal = float.Parse(FacturaTotalTextbox.Text),
            };

            List<FacturaReporte> facturas = new List<FacturaReporte>
            {
                factura
            };

            List<Mueble> muebles = orden.Muebles;
            FacturaForm formulario = new FacturaForm(facturas, muebles);
            formulario.ShowDialog(this);
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
