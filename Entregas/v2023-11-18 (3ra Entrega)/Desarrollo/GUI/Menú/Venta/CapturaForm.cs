using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class CapturaForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO

        readonly Empleado empleado;
        Cliente cliente;
        readonly ClienteBLL clienteBLL = new ClienteBLL();
        Orden orden;
        OrdenBLL ordenBLL = new OrdenBLL();

        public CapturaForm(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
        }

        private void CapturaForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Captura - {empleado.NombreApellido}";
        }

        private void Cliente_DNI_o_CUIT_Textbox_Leave(object sender, EventArgs e)
        {
            cliente = clienteBLL.BuscarPorDNI_o_CUIT(Cliente_DNI_o_CUIT_Textbox.Text);

            if (cliente != null)
            {
                // Si el cliente existe, ompletar los otros campos
                ClienteIdTextbox.Text = cliente.Id.ToString();
                MudanzaCategoriaTextbox.Text = cliente.Categoria;
                ClienteNombreTextbox.Text = cliente.NombreApellido_o_RazonSocial;
                ClienteDireccionTextbox.Text = cliente.Direccion;
            }
            else
            {
                // Si el cliente no existe, abrir el formulario emergente para agregarlo
                using (ClienteForm formulario = new ClienteForm(empleado, Cliente_DNI_o_CUIT_Textbox.Text))
                {
                    DialogResult result = formulario.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        // Actualizar los campos del formulario principal con la información del nuevo cliente
                        cliente = clienteBLL.BuscarPorDNI_o_CUIT(formulario.DNI_o_CUIT);

                        Cliente_DNI_o_CUIT_Textbox.Text = cliente.DNI_o_CUIT;
                        MudanzaCategoriaTextbox.Text = cliente.Categoria;
                        ClienteIdTextbox.Text = cliente.Id.ToString();
                        ClienteNombreTextbox.Text = cliente.NombreApellido_o_RazonSocial;
                        ClienteDireccionTextbox.Text = cliente.Direccion;
                    }
                }
            }
        }


        private void KilometrosDistanciaTextbox_Leave(object sender, EventArgs e)
        {
            float monto = ordenBLL.CotizarServicio
                (
                MudanzaFechaDTP.Value,
                MudanzaCategoriaTextbox.Text,
                int.Parse(MudanzaKilometrosTextbox.Text)
                );
            MudanzaMontoTextbox.Text = monto.ToString();
        }

        private void GrabarButton_Click(object sender, EventArgs e)
        {
            orden = new Orden
            {
                Estado = "Solicitado",
                ServicioFecha = DateTime.Parse(MudanzaFechaDTP.Text),
                DireccionOrigen = MudanzaOrigenTextbox.Text,
                DescripcionLugarCarga = MudanzaLugarCargaTextbox.Text,
                DireccionDestino = MudanzaDestinoTextbox.Text,
                DescripcionLugarDescarga = MudanzaLugarCargaTextbox.Text,
                Muebles = DesdeMueblesDGV(),
                Observaciones = MudanzaObservacionesTextbox.Text,
                KilometrosDistancia = int.Parse(MudanzaKilometrosTextbox.Text),
                Monto = float.Parse(MudanzaMontoTextbox.Text),
                ClienteID = int.Parse(ClienteIdTextbox.Text)
            };
            ordenBLL.Agregar(orden);
            MessageBox.Show("Orden agregada correctamente.");
            LimpiarPantalla();
        }


        private List<Mueble> DesdeMueblesDGV()
        {
            List<Mueble> muebles = new List<Mueble>();

            foreach (DataGridViewRow mueble in MueblesDatagridview.Rows)
            {
                if (!mueble.IsNewRow)
                {
                    int cantidad = int.Parse(mueble.Cells["Cantidad"].Value.ToString());
                    string descripcion = mueble.Cells["Descripcion"].Value.ToString();
                    muebles.Add(new Mueble { Cantidad = cantidad, Descripcion = descripcion });
                }
            }
            return muebles;
        }

        private void LimpiarPantalla()
        {
            // Limpiar TextBoxes
            foreach (Control control in Controls.OfType<TextBox>())
            {
                ((TextBox)control).Clear();
            }

            // Limpiar ComboBoxes
            foreach (Control control in Controls.OfType<ComboBox>())
            {
                ((ComboBox)control).SelectedIndex = -1;
            }

            // Limpiar DataGridViews
            foreach (Control control in Controls.OfType<DataGridView>())
            {
                ((DataGridView)control).DataSource = null;
            }

            // Limpiar DateTimePickers
            foreach (Control control in Controls.OfType<DateTimePicker>())
            {
                ((DateTimePicker)control).Value = DateTime.Now;
            }
        }


    }
}
