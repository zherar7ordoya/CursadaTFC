using ABS;

using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class PrincipalForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIO
        readonly Empleado empleado;
        private readonly RolBLL rolBLL = new RolBLL();
        private IComposite puesto;
        private readonly List<Rol> listaRoles = new List<Rol>();

        public PrincipalForm(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            this.Text = $"La Mudadora - {empleado.NombreApellido}";
            CargarRolesDesdeXml();
            Rol rol = ObtenerRol(empleado.Puesto);
            if (rol != null)
            {
                puesto = rol;
                AplicarPermisos();
            }
            else
            {
                // Si el rol no existe, deshabilitar todos los elementos del menú
                foreach (ToolStripMenuItem item in MenuMudadora.Items)
                {
                    item.Enabled = false;
                    item.Visible = false;
                }
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| PERMISOS

        private Rol ObtenerRol(string pRol)
        {
            // Buscar el rol en la lista de roles
            return listaRoles.FirstOrDefault(x => x.ObtenerNombre() == pRol);
        }


        private void CargarRolesDesdeXml()
        {
            try
            {
                XElement root = rolBLL.Consultar();

                foreach (XElement rolElement in root.Elements("Rol"))
                {
                    string nombreRol = rolElement.Attribute("Nombre").Value;
                    Rol rol = new Rol(nombreRol);

                    foreach (XElement permisoElement in rolElement.Elements("Permiso"))
                    {
                        string nombrePermiso = permisoElement.Value;
                        Permiso permiso = new Permiso(nombrePermiso);
                        rol.AgregarNodo(permiso);
                    }

                    listaRoles.Add(rol);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void AplicarPermisos()
        {
            // Iterar sobre los elementos del menú y habilitar/deshabilitar según los permisos
            foreach (ToolStripMenuItem item in MenuMudadora.Items)
            {
                VerificarPermisos(item);
            }
        }

        private void VerificarPermisos(ToolStripMenuItem pItem)
        {
            // Verificar si el nombre del elemento está en la lista de nodos del rol actual
            bool tienePermiso = puesto.ObtenerNodos().Any(x => x.ObtenerNombre() == pItem.Name);

            // Habilitar/deshabilitar y hacer visible/invisible según los permisos
            pItem.Enabled = tienePermiso;
            pItem.Visible = tienePermiso;

            // Recursión a través de los subítems
            foreach (ToolStripMenuItem sub in pItem.DropDownItems)
            {
                VerificarPermisos(sub);
            }
        }

        #region ||||||||||||||||||||||||||||||||||||||||||||||||||| MENÚ ARCHIVO

        private void Camiones_Click(object sender, EventArgs e)
        {
            CamionABM formulario = new CamionABM(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            ClienteABM formulario = new ClienteABM(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Empleados_Click(object sender, EventArgs e)
        {
            EmpleadoABM formulario = new EmpleadoABM(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Facturas_Click(object sender, EventArgs e)
        {
            FacturaABM formulario = new FacturaABM(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Liquidaciones_Click(object sender, EventArgs e)
        {
            LiquidacionABM formulario = new LiquidacionABM(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Mudanzas_Click(object sender, EventArgs e)
        {
            MudanzaABM formulario = new MudanzaABM(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Órdenes_Click(object sender, EventArgs e)
        {
            OrdenABM formulario = new OrdenABM(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Tarifas_Click(object sender, EventArgs e)
        {
            TarifaABM formulario = new TarifaABM(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        #endregion

        #region ||||||||||||||||||||||||||||||||||||||||||||||||||||| MENÚ VENTA

        private void Captura_Click(object sender, EventArgs e)
        {
            CapturaForm formulario = new CapturaForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Facturación_Click(object sender, EventArgs e)
        {
            FacturacionForm formulario = new FacturacionForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        #endregion

        #region ||||||||||||||||||||||||||||||||||||||||||||||||| MENÚ LOGÍSTICA

        private void Despacho_Click(object sender, EventArgs e)
        {
            DespachoForm formulario = new DespachoForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Liquidación_Click(object sender, EventArgs e)
        {
            LiquidacionForm formulario = new LiquidacionForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        #endregion

        #region ||||||||||||||||||||||||||||||||||||||||||||||||| MENÚ SEGURIDAD

        private void Roles_Click(object sender, EventArgs e)
        {
            RolForm formulario = new RolForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Permisos_Click(object sender, EventArgs e)
        {
            PermisoForm formulario = new PermisoForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\

        private void Respaldos_Click(object sender, EventArgs e)
        {
            RespaldoForm formulario = new RespaldoForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Restauraciones_Click(object sender, EventArgs e)
        {
            RestauracionForm formulario = new RestauracionForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        #endregion

        #region ||||||||||||||||||||||||||||||||||||||||||||||||||| MENÚ SISTEMA

        private void Dashboard_Click(object sender, EventArgs e)
        {
            DashboardForm formulario = new DashboardForm(empleado)
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Acerca_Click(object sender, EventArgs e)
        {
            AboutBox formulario = new AboutBox();
            formulario.ShowDialog(this);
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            AccesoForm formulario = new AccesoForm();
            Hide();
            formulario.Show();
        }

        #endregion

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| CIERRE

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
