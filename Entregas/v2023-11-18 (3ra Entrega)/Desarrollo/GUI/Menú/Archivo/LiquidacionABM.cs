using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class LiquidacionABM : BaseForm
    {
        Empleado empleado;
        readonly LiquidacionBLL liquidacionBLL;
        public LiquidacionABM(Empleado pEmpleado)
        {
            InitializeComponent();
            liquidacionBLL = new LiquidacionBLL();
            this.empleado = pEmpleado;
        }

        private void LiquidacionFRM_Load(object sender, EventArgs e)
        {
            this.Text = $"Liquidaciones - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            List<Liquidacion> liquidaciones = liquidacionBLL.Consultar();

            // Configuración del TreeView
            LiquidacionesTreeview.Nodes.Clear();

            // Llena el TreeView con la lista de mudanzas
            foreach (var liquidacion in liquidaciones)
            {
                // Almacena el objeto en el Tag, necesario luego en el evento AfterSelect
                var liquidacionNode = new TreeNode($"Orden {liquidacion.Id}")
                {
                    Tag = liquidacion
                };

                liquidacionNode.Nodes.Add($"Fecha: {liquidacion.Fecha}");

                var comprobantesNode = new TreeNode("Comprobantes");
                foreach (var comprobante in liquidacion.Comprobantes)
                {
                    comprobantesNode.Nodes.Add
                        (
                        $"Fecha: {comprobante.Fecha}," +
                        $"Detalle: {comprobante.Detalle}," +
                        $"Monto: {comprobante.Monto}"
                        );
                }
                liquidacionNode.Nodes.Add(comprobantesNode);

                liquidacionNode.Nodes.Add($"Monto de la orden: {liquidacion.MontoOrden}");
                liquidacionNode.Nodes.Add($"Monto del reembolso: {liquidacion.MontoReembolso}");
                liquidacionNode.Nodes.Add($"Total: {liquidacion.Total}");

                liquidacionNode.Nodes.Add($"Orden ID: {liquidacion.OrdenID}");

                // Agrega el nodo de Mudanza al TreeView
                LiquidacionesTreeview.Nodes.Add(liquidacionNode);
            }

            // Maneja el evento AfterSelect para mostrar y editar los detalles de la Mudanza seleccionada
            LiquidacionesTreeview.AfterSelect += (sender, e) =>
            {
                TreeNode node = LiquidacionesTreeview.SelectedNode;

                if (node != null)
                {
                    // Verifica si el nodo actual tiene un nodo padre
                    while (node.Parent != null)
                    {
                        // Si tiene un nodo padre, actualiza el nodo actual al nodo padre
                        node = node.Parent;
                    }
                }
                MapearDesdeObjeto(node?.Tag as Liquidacion);
            };
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Liquidacion pLiquidacion)
        {
            IdTXT.Text = pLiquidacion.Id.ToString();
            FechaDTP.Text = pLiquidacion.Fecha.ToString();

            HaciaComprobantesDGV(pLiquidacion.Comprobantes);

            MontoOrdenTXT.Text = pLiquidacion.MontoOrden.ToString("C");
            MontoReembolsoTXT.Text = pLiquidacion.MontoReembolso.ToString("C");
            TotalTXT.Text = pLiquidacion.Total.ToString("C");
            OrdenIDTXT.Text = pLiquidacion.OrdenID.ToString();
        }
        private void HaciaComprobantesDGV(List<Comprobante> pComprobantes)
        {
            ComprobantesDGV.Rows.Clear();
            ComprobantesDGV.Columns.Clear();

            ComprobantesDGV.Columns.Add("Fecha", "Fecha");
            ComprobantesDGV.Columns.Add("Detalle", "Detalle");
            ComprobantesDGV.Columns.Add("Monto", "Monto");

            foreach (var comprobante in pComprobantes)
            {
                ComprobantesDGV.Rows.Add
                    (
                    comprobante.Fecha,
                    comprobante.Detalle,
                    comprobante.Monto
                    );
            }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private Liquidacion MapearHaciaObjeto()
        {
            return new Liquidacion
            {
                Id = int.Parse(IdTXT.Text),
                Fecha = DateTime.Parse(FechaDTP.Text),

                Comprobantes = DesdeComprobantesDGV(),
                
                MontoOrden = float.Parse(MontoOrdenTXT.Text.TrimStart('$')),
                MontoReembolso = float.Parse(MontoReembolsoTXT.Text.TrimStart('$')),
                Total = float.Parse(TotalTXT.Text.TrimStart('$')),
                OrdenID = int.Parse(OrdenIDTXT.Text)
            };
        }
        private List<Comprobante> DesdeComprobantesDGV()
        {
            List<Comprobante> comprobantes = new List<Comprobante>();

            foreach (DataGridViewRow comprobante in ComprobantesDGV.Rows)
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
            return comprobantes;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS

        private void ComprobantesDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
            Liquidacion liquidacion = MapearHaciaObjeto();
            liquidacionBLL.Agregar(liquidacion);
            ActualizarPantalla();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            Liquidacion liquidacion = MapearHaciaObjeto();
            liquidacionBLL.Eliminar(liquidacion.Id);
            ActualizarPantalla();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            Liquidacion liquidacion = MapearHaciaObjeto();
            liquidacionBLL.Modificar(liquidacion);
            ActualizarPantalla();
        }
    }
}
