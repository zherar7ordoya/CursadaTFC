using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class OrdenABM : BaseForm
    {
        readonly Empleado empleado;
        readonly OrdenBLL ordenBLL;
        public OrdenABM(Empleado pEmpleado)
        {
            InitializeComponent();
            ordenBLL = new OrdenBLL();
            this.empleado = pEmpleado;
        }

        private void OrdenFRM_Load(object sender, EventArgs e)
        {
            this.Text = $"Órdenes - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            List <Orden> ordenes = ordenBLL.Consultar();

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

            // Maneja el evento AfterSelect para mostrar y editar los detalles de la Mudanza seleccionada
            OrdenesTreeview.AfterSelect += (sender, e) =>
            {
                TreeNode node = OrdenesTreeview.SelectedNode;

                if (node != null)
                {
                    // Verifica si el nodo actual tiene un nodo padre
                    while (node.Parent != null)
                    {
                        // Si tiene un nodo padre, actualiza el nodo actual al nodo padre
                        node = node.Parent;
                    }
                }
                MapearDesdeObjeto(node?.Tag as Orden);
            };
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Orden pOrden)
        {
            IdTXT.Text = pOrden.Id.ToString();
            EstadoTXT.Text = pOrden.Estado;
            FechaDTP.Text = pOrden.ServicioFecha.ToString();
            DireccionOrigenTXT.Text = pOrden.DireccionOrigen;
            LugarCargaTXT.Text = pOrden.DescripcionLugarCarga;
            DireccionDestinoTXT.Text = pOrden.DireccionDestino;
            LugarDescargaTXT.Text = pOrden.DescripcionLugarDescarga;

            HaciaMueblesDGV(pOrden.Muebles);
            
            ObservacionesTXT.Text = pOrden.Observaciones;
            KilometrosDistanciaTXT.Text = pOrden.KilometrosDistancia.ToString();
            MontoTXT.Text = pOrden.Monto.ToString("C");
            ClienteIDTXT.Text = pOrden.ClienteID.ToString();
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

        private Orden MapearHaciaObjeto()
        {
            return new Orden
            {
                Id = int.Parse(IdTXT.Text),
                Estado=EstadoTXT.Text,
                ServicioFecha = DateTime.Parse(FechaDTP.Text),
                DireccionOrigen=DireccionOrigenTXT.Text,
                DescripcionLugarCarga=LugarCargaTXT.Text,
                DireccionDestino=DireccionDestinoTXT.Text,
                DescripcionLugarDescarga=LugarDescargaTXT.Text,

                Muebles = DesdeMueblesDGV(),
                
                Observaciones=ObservacionesTXT.Text,
                KilometrosDistancia=int.Parse(KilometrosDistanciaTXT.Text),
                Monto = float.Parse(MontoTXT.Text.TrimStart('$')),
                ClienteID=int.Parse(ClienteIDTXT.Text)
            };
        }

        private List<Mueble> DesdeMueblesDGV()
        {
            List<Mueble> muebles = new List<Mueble>();

            foreach (DataGridViewRow mueble in MueblesDGV.Rows)
            {
                int cantidad = int.Parse(mueble.Cells["Cantidad"].Value.ToString());
                string descripcion = mueble.Cells["Descripcion"].Value.ToString();
                muebles.Add(new Mueble { Cantidad = cantidad, Descripcion = descripcion });
            }
            return muebles;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABM

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            Orden orden = MapearHaciaObjeto();
            ordenBLL.Agregar(orden);
            ActualizarPantalla();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            Orden orden = MapearHaciaObjeto();
            ordenBLL.Eliminar(orden.Id);
            ActualizarPantalla();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            Orden orden = MapearHaciaObjeto();
            ordenBLL.Modificar(orden);
            ActualizarPantalla();
        }
    }
}
