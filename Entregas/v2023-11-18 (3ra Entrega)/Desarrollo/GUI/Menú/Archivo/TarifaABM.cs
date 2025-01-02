using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class TarifaABM : BaseForm
    {
        readonly Empleado empleado;
        readonly TarifaBLL tarifaBLL;
        public TarifaABM(Empleado pEmpleado)
        {
            InitializeComponent();
            tarifaBLL = new TarifaBLL();
            this.empleado = pEmpleado;
        }

        private void TarifaFRM_Load(object sender, EventArgs e)
        {
            this.Text = $"Tarifas - {empleado.NombreApellido}";
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            List<Tarifa> tarifas = tarifaBLL.Consultar();

            // Configuración del TreeView
            TarifasTreeview.Nodes.Clear();

            // Llena el TreeView con la lista
            foreach (var tarifa in tarifas)
            {
                // Almacena el objeto en el Tag, necesario luego en el evento AfterSelect
                var tarifaNode = new TreeNode($"Tarifa {tarifa.Id}")
                {
                    Tag = tarifa
                };

                tarifaNode.Nodes.Add($"Desde: {tarifa.Desde}");
                tarifaNode.Nodes.Add($"Hasta: {tarifa.Hasta}");
                tarifaNode.Nodes.Add($"Monto del kilómetro: {tarifa.MontoKilometro}");

                var coeficientesNode = new TreeNode("Coeficientes");
                foreach (var coeficiente in tarifa.Coeficientes)
                {
                    coeficientesNode.Nodes.Add
                        (
                        $"Categoría: {coeficiente.Categoria}," +
                        $"Valor: {coeficiente.Valor}"
                        );
                }
                tarifaNode.Nodes.Add(coeficientesNode);

                // Agrega el nodo al TreeView
                TarifasTreeview.Nodes.Add(tarifaNode);
            }

            // Maneja el evento AfterSelect para mostrar y editar los detalles de la selección
            TarifasTreeview.AfterSelect += (sender, e) =>
            {
                TreeNode node = TarifasTreeview.SelectedNode;

                if (node != null)
                {
                    // Verifica si el nodo actual tiene un nodo padre
                    while (node.Parent != null)
                    {
                        // Si tiene un nodo padre, actualiza el nodo actual al nodo padre
                        node = node.Parent;
                    }
                }
                MapearDesdeObjeto(node?.Tag as Tarifa);
            };
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MAPEADORES

        private void MapearDesdeObjeto(Tarifa pTarifa)
        {
            IdTXT.Text = pTarifa.Id.ToString();
            DesdeDTP.Text = pTarifa.Desde.ToString();
            HastaDTP.Text = pTarifa.Hasta.ToString();
            MontoKilometroTXT.Text = pTarifa.MontoKilometro.ToString("C");

            HaciaCoeficientesDGV(pTarifa.Coeficientes);
        }
        private void HaciaCoeficientesDGV(List<Coeficiente> pCoeficientes)
        {
            CoeficientesDGV.Rows.Clear();
            CoeficientesDGV.Columns.Clear();

            CoeficientesDGV.Columns.Add("Categoria", "Categoría");
            CoeficientesDGV.Columns.Add("Valor", "Valor");


            foreach (var coeficiente in pCoeficientes)
            {
                CoeficientesDGV.Rows.Add
                    (
                    coeficiente.Categoria,
                    coeficiente.Valor
                    );
            }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private Tarifa MapearHaciaObjeto()
        {
            return new Tarifa
            {
                Id = int.Parse(IdTXT.Text),
                Desde = DateTime.Parse(DesdeDTP.Text),
                Hasta = DateTime.Parse(HastaDTP.Text),
                MontoKilometro = float.Parse(MontoKilometroTXT.Text.TrimStart('$')),

                Coeficientes = DesdeCoeficientesDGV()
            };
        }
        private List<Coeficiente> DesdeCoeficientesDGV()
        {
            List<Coeficiente> coeficientes = new List<Coeficiente>();

            foreach (DataGridViewRow coeficiente in CoeficientesDGV.Rows)
            {
                string categoria = coeficiente.Cells["Categoria"].Value.ToString();
                float valor = float.Parse(coeficiente.Cells["Valor"].Value.ToString());

                coeficientes.Add(new Coeficiente
                {
                    Categoria = categoria,
                    Valor = valor
                });
            }
            return coeficientes;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS

        private void CoeficientesDGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is float || e.Value is double || e.Value is decimal)
            {
                e.Value = string.Format("{0:N2}", e.Value); // Formato para coeficiente
                e.FormattingApplied = true;
                DataGridViewCell cell = CoeficientesDGV[e.ColumnIndex, e.RowIndex];
                cell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| ABM

        private void AltaBTN_Click(object sender, EventArgs e)
        {
            Tarifa tarifa = MapearHaciaObjeto();
            tarifaBLL.Agregar(tarifa);
            ActualizarPantalla();
        }

        private void BajaBTN_Click(object sender, EventArgs e)
        {
            Tarifa tarifa = MapearHaciaObjeto();
            tarifaBLL.Eliminar(tarifa.Id);
            ActualizarPantalla();
        }

        private void ModificacionBTN_Click(object sender, EventArgs e)
        {
            Tarifa tarifa = MapearHaciaObjeto();
            tarifaBLL.Modificar(tarifa);
            ActualizarPantalla();
        }
    }
}
