using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class MudanzaABM : BaseForm
    {
        readonly Empleado empleado;
        readonly MudanzaBLL mudanzaBLL;
        public MudanzaABM(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
            mudanzaBLL = new MudanzaBLL();
        }

        private void MudanzaABM_Load(object sender, EventArgs e)
        {
            this.Text = $"Mudanzas - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            List<Mudanza> mudanzas = mudanzaBLL.Consultar();

            // Configuración del TreeView
            MudanzasTreeview.Nodes.Clear();

            // Llena el TreeView con la lista de mudanzas
            foreach (var mudanza in mudanzas)
            {
                // Almacena el objeto en el Tag, necesario luego en el evento AfterSelect
                var mudanzaNode = new TreeNode($"Mudanza {mudanza.Id}")
                {
                    Tag = mudanza 
                };

                mudanzaNode.Nodes.Add($"Fecha: {mudanza.Fecha}");
                mudanzaNode.Nodes.Add($"Camión: Patente {mudanza.Camion.Patente}, Marca {mudanza.Camion.Marca}");
                mudanzaNode.Nodes.Add($"Chofer: DNI {mudanza.Chofer.DNI}, Nombre: {mudanza.Chofer.NombreApellido}");
                
                var estibadoresNode = new TreeNode("Estibadores");
                foreach (var estibador in mudanza.Estibadores)
                {
                    estibadoresNode.Nodes.Add($"DNI: {estibador.DNI}, Nombre: {estibador.NombreApellido}");
                }
                mudanzaNode.Nodes.Add(estibadoresNode);

                var insumosNode = new TreeNode("Insumos");
                foreach (var insumo in mudanza.Insumos)
                {
                    insumosNode.Nodes.Add($"Cantidad: {insumo.Cantidad}, Descripción: {insumo.Descripcion}");
                }
                mudanzaNode.Nodes.Add(insumosNode);

                mudanzaNode.Nodes.Add($"Orden ID: {mudanza.OrdenID}");

                // Agrega el nodo de Mudanza al TreeView
                MudanzasTreeview.Nodes.Add(mudanzaNode);
            }

            // Maneja el evento AfterSelect para mostrar y editar los detalles de la Mudanza seleccionada
            MudanzasTreeview.AfterSelect += (sender, e) =>
            {
                TreeNode node = MudanzasTreeview.SelectedNode;

                if (node != null)
                {
                    // Verifica si el nodo actual tiene un nodo padre
                    while (node.Parent != null)
                    {
                        // Si tiene un nodo padre, actualiza el nodo actual al nodo padre
                        node = node.Parent;
                    }
                }
                MapearDesdeObjeto(node?.Tag as Mudanza);
            };
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Mudanza pMudanza)
        {
            IdTXT.Text = pMudanza.Id.ToString();
            FechaDTP.Text = pMudanza.Fecha.ToString("yyyy-MM-dd");
            PatenteTXT.Text = pMudanza.Camion?.Patente;
            MarcaTXT.Text = pMudanza.Camion?.Marca;
            DNITXT.Text = pMudanza.Chofer?.DNI.ToString();
            NombreApellidoTXT.Text = pMudanza.Chofer?.NombreApellido;

            HaciaEstibadoresDGV(pMudanza.Estibadores);
            HaciaInsumosDGV(pMudanza.Insumos);

            OrdenIDTXT.Text = pMudanza.OrdenID.ToString();
        }

        private void HaciaEstibadoresDGV(List<Empleado> pEstibadores)
        {
            EstibadoresDGV.Rows.Clear();
            EstibadoresDGV.Columns.Clear();

            EstibadoresDGV.Columns.Add("DNI", "DNI");
            EstibadoresDGV.Columns.Add("NombreApellido", "NombreApellido");

            foreach (var estibador in pEstibadores)
            {
                EstibadoresDGV.Rows.Add(estibador.DNI, estibador.NombreApellido);
            }
        }

        private void HaciaInsumosDGV(List<Insumo> insumos)
        {
            InsumosDGV.Rows.Clear();
            InsumosDGV.Columns.Clear();

            InsumosDGV.Columns.Add("Cantidad", "Cantidad");
            InsumosDGV.Columns.Add("Descripcion", "Descripcion");

            foreach (var insumo in insumos)
            {
                InsumosDGV.Rows.Add(insumo.Cantidad, insumo.Descripcion);
            }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private Mudanza MapearHaciaObjeto()
        {
            Mudanza mudanza = new Mudanza
            {
                Id = int.Parse(IdTXT.Text),
                Fecha = DateTime.Parse(FechaDTP.Text),
                Camion = new Camion
                {
                    Patente = PatenteTXT.Text,
                    Marca = MarcaTXT.Text
                },
                Chofer = new Empleado
                {
                    DNI = int.Parse(DNITXT.Text),
                    NombreApellido = NombreApellidoTXT.Text
                },
                Estibadores = DesdeEstibadoresDGV(),
                Insumos = DesdeInsumosDGV(),
                OrdenID = int.Parse(OrdenIDTXT.Text)
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


        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABM

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            Mudanza mudanza = MapearHaciaObjeto();
            mudanzaBLL.Agregar(mudanza);
            ActualizarPantalla();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            Mudanza mudanza = MapearHaciaObjeto();
            mudanzaBLL.Eliminar(mudanza.Id);
            ActualizarPantalla();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            Mudanza mudanza = MapearHaciaObjeto();
            mudanzaBLL.Modificar(mudanza);
            ActualizarPantalla();
        }




    }
}
