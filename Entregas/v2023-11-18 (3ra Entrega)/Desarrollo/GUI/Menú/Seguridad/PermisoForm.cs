using ABS;

using BEL;

using BLL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class PermisoForm : BaseForm
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||| INICIALIZACIÓN

        readonly Empleado empleado;
        private readonly RolBLL rolBLL = new RolBLL();

               
        private readonly IComposite raiz;
        EmpleadoBLL empleadoBLL;
        List<Empleado> empleados;

        public PermisoForm(Empleado pEmpleado)
        {
            InitializeComponent();
            empleado = pEmpleado;

            empleadoBLL = new EmpleadoBLL();
            empleados = empleadoBLL.Consultar();

            raiz = new Rol("Roles");
        }

        private void PermisoForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Permisos - {empleado.NombreApellido}";

            // ListBox
            EmpleadosListbox.DisplayMember = "NombreApellido";
            foreach (var empleado in empleados)
            {
                EmpleadosListbox.Items.Add(empleado);
            }
            EmpleadosListbox.SelectedIndexChanged += EmpleadosLista_SelectedIndexChanged;

            // TreeView
            //CargarPermisos(string.Empty);
            PermisosTreeview.AfterSelect += PermisosArbol_AfterSelect;
        }



        // Acepta filtrado por rol (no se usa, pero acepta)
        private void CargarPermisos(string pRol)
        {
            try
            {
                // Limpiar el árbol antes de reconstruirlo
                PermisosTreeview.Nodes.Clear();

                // Leer el archivo XML de roles
                XElement rolesArchivo = rolBLL.Consultar();

                // Obtener todos los roles o el rol especificado en el archivo XML
                IEnumerable<XElement> rolesElements;

                // Obtener todos los roles si rol == empty
                if (string.IsNullOrWhiteSpace(pRol))
                {
                    rolesElements = rolesArchivo.Descendants("Rol");
                }
                // Obtener un rol específico
                else
                {
                    rolesElements = rolesArchivo.Descendants("Rol")
                        .Where(x => x.Attribute("Nombre")?.Value == pRol);
                }

                // Construir el árbol a partir de los roles obtenidos
                foreach (var rolElement in rolesElements)
                {
                    string rolNombre = rolElement.Attribute("Nombre")?.Value;

                    if (!string.IsNullOrEmpty(rolNombre))
                    {
                        // Crear un nodo para el rol actual
                        Rol rol = new Rol(rolNombre);

                        // Agregar permisos al nodo del rol actual
                        foreach (XElement permisoElement in rolElement.Elements("Permiso"))
                        {
                            string permisoNombre = permisoElement.Value;
                            Permiso permiso = new Permiso(permisoNombre);
                            rol.AgregarNodo(permiso);
                        }
                        raiz.AgregarNodo(rol);
                    }
                }
                //ConstruirTreeView(ArbolPermisos.Nodes, raiz);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConstruirTreeView(TreeNodeCollection pTNC, IComposite pNodo)
        {
            // Limpiar el árbol antes de reconstruirlo
            pTNC.Clear();

            // Crear un nodo para cada rol y agregarlo al árbol
            foreach (IComposite subNodo in pNodo.ObtenerNodos())
            {
                TreeNode treeNode = new TreeNode(subNodo.ObtenerNombre());

                // Agregar el nuevo nodo al árbol
                pTNC.Add(treeNode);

                // Si el nodo tiene subnodos (permisos), agregarlos también
                foreach (IComposite subNodoPermiso in subNodo.ObtenerNodos())
                {
                    TreeNode permisoNode = new TreeNode(subNodoPermiso.ObtenerNombre());
                    treeNode.Nodes.Add(permisoNode);
                }
            }
        }


        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS


        private TreeNode BuscarNodo(TreeNodeCollection nodos, string textoBuscado)
        {
            TreeNode nodoCoincidente = null;

            foreach (TreeNode nodo in nodos)
            {
                Console.WriteLine("Nodo actual: " + nodo.Text);

                if (nodo.Text == textoBuscado)
                {
                    Console.WriteLine("¡Nodo encontrado!");
                    nodoCoincidente = nodo;
                }

                TreeNode nodoHijo = BuscarNodo(nodo.Nodes, textoBuscado);

                // Actualizar el nodo coincidente si encontramos un nodo hijo que coincide
                if (nodoHijo != null)
                {
                    nodoCoincidente = nodoHijo;
                }
            }

            return nodoCoincidente;
        }


        private bool ExistePermisoEnRol(TreeNode rolNode, string permiso)
        {
            // Verificar si el permiso ya existe en el rol
            foreach (TreeNode nodo in rolNode.Nodes)
            {
                if (nodo.Text == permiso)
                {
                    return true;
                }
            }
            return false;
        }

        private bool ExisteRolEnTreeView(string nombreRol)
        {
            foreach (TreeNode nodo in PermisosTreeview.Nodes)
            {
                if (nodo.Text == nombreRol)
                {
                    return true;
                }
            }
            return false;
        }


        //private void RecorrerTreeView(XElement parentElement, TreeNodeCollection nodes)
        //{
        //    foreach (TreeNode node in nodes)
        //    {
        //        // Crear un elemento para cada nodo del TreeView
        //        XElement nodeElement;

        //        if (node.Nodes.Count > 0)
        //        {
        //            // Nodo de rol con permisos
        //            nodeElement = new XElement("Rol");
        //            nodeElement.SetAttributeValue("Nombre", node.Text);

        //            // Recursivamente agregar nodos hijos (permisos) si tiene permisos
        //            RecorrerTreeView(nodeElement, node.Nodes);

        //            // Agregar el elemento al padre solo si tiene hijos (permisos)
        //            parentElement.Add(nodeElement);
        //        }
        //        else
        //        {
        //            if (node.Parent == null)
        //            {
        //                // Nodo de rol sin permisos
        //                nodeElement = new XElement("Rol");
        //                nodeElement.SetAttributeValue("Nombre", node.Text);

        //                // Agregar el elemento al padre solo si no es un rol sin permisos
        //                parentElement.Add(nodeElement);
        //            }
        //            else
        //            {
        //                // Nodo de permiso
        //                nodeElement = new XElement("Permiso", node.Text);

        //                // Agregar el elemento al padre solo si no es un rol sin permisos
        //                parentElement.Add(nodeElement);
        //            }
        //        }
        //    }
        //}


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| BOTONERA








        private void PermisoAgregarBTN_Click(object sender, EventArgs e)
        {
            //AgregarPermiso(RolTXT.Text, PermisoTXT.Text);
            // Buscar el nodo del rol
            TreeNode rolNode = BuscarNodo(PermisosTreeview.Nodes, RolesCombobox.Text);

            if (rolNode != null)
            {
                // Verificar si el permiso ya existe antes de agregarlo
                if (!ExistePermisoEnRol(rolNode, PermisosCombobox.Text))
                {
                    // Agregar el nuevo permiso como un nodo hijo
                    TreeNode nuevoPermisoNode = new TreeNode(PermisosCombobox.Text);
                    rolNode.Nodes.Add(nuevoPermisoNode);
                }
                else
                {
                    MessageBox.Show($"El permiso '{PermisosCombobox.Text}' ya existe en el rol '{RolesCombobox.Text}'.");
                }
            }
            else
            {
                MessageBox.Show($"Rol no encontrado: {RolesCombobox.Text}");
            }
        }


        private void PermisoQuitarBTN_Click(object sender, EventArgs e)
        {

            // Buscar el nodo del rol
            TreeNode rolNode = BuscarNodo(PermisosTreeview.Nodes, RolesCombobox.Text);

            if (rolNode != null)
            {
                // Buscar y quitar el nodo del permiso
                TreeNode permisoNode = BuscarNodo(rolNode.Nodes, PermisosCombobox.Text);

                if (permisoNode != null)
                {
                    rolNode.Nodes.Remove(permisoNode);
                    PermisosTreeview.Refresh();
                }
                else
                {
                    MessageBox.Show($"Permiso no encontrado: {PermisosCombobox.Text}");
                }
            }
            else
            {
                MessageBox.Show($"Rol no encontrado: {RolesCombobox.Text}");
            }
        }


        //private void GrabarBTN_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Crear un nuevo elemento raíz
        //        XElement rolesElement = new XElement("Roles");

        //        // Recorrer los nodos del TreeView y agregarlos al nuevo elemento raíz
        //        RecorrerTreeView(rolesElement, ArbolPermisos.Nodes);

        //        // Guardar el nuevo documento XML en el archivo
        //        // doc.Save(rutaArchivo);
        //        rolORM.Modificar(rolesElement);

        //        MessageBox.Show("Cambios guardados correctamente.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}







        private void GrabarBTN_Click(object sender, EventArgs e)
        {
            try
            {



                // Cargar el XML actual
                XElement rolesXml = rolBLL.Consultar();

                // Obtener el nombre del rol modificado
                string nombreRolModificado = PermisosTreeview.Nodes[0].Text; // Suponemos que el primer nodo es siempre el rol principal

                // Buscar el nodo con el mismo nombre en el XML
                XElement nodoRolXml = rolesXml.Descendants("Rol")
                    .FirstOrDefault(x => x.Attribute("Nombre")?.Value == nombreRolModificado);

                // Si se encuentra el nodo, eliminarlo
                if (nodoRolXml != null)
                {
                    nodoRolXml.Remove();
                }

                // Recorrer los nodos del TreeView y agregarlos al XML
                RecorrerTreeView(rolesXml, PermisosTreeview.Nodes);

                // Guardar el nuevo documento XML en el archivo
                rolBLL.Modificar(rolesXml);

                MessageBox.Show("Cambios guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Método para actualizar el XML con la información del TreeView
        private void RecorrerTreeView(XElement parentElement, TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Nodes.Count == 0)
                {
                    // Es un permiso, agregarlo al nodo XML
                    parentElement.Add(new XElement("Permiso", node.Text));
                }
                else
                {
                    // Es un rol con permisos
                    XElement nodoRolXml = new XElement("Rol", new XAttribute("Nombre", node.Text));
                    parentElement.Add(nodoRolXml);

                    // Llamar recursivamente para actualizar los permisos
                    RecorrerTreeView(nodoRolXml, node.Nodes);
                }
            }
        }









        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS


        private void PermisosArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                // Verificar si el nodo seleccionado tiene un padre
                TreeNode padre = e.Node.Parent;

                // Obtener el nombre del rol desde el nodo seleccionado o su nodo padre
                string nombreRol = (padre != null) ? padre.Text : e.Node.Text;

                // Verificar si el nodo seleccionado es permiso
                if (e.Node.Nodes.Count == 0 && e.Node.Parent != null)
                {
                    // El nodo seleccionado es un permiso
                    RolesCombobox.Text = nombreRol;
                    PermisosCombobox.Text = e.Node.Text;
                }
                else
                {
                    // El nodo seleccionado es un rol nuevo (sin permisos)
                    //RolTXT.Text = nombreRol;
                    //PermisoTXT.Text = string.Empty;
                    RolesCombobox.Text = nombreRol;
                    PermisosCombobox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpleadosLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el objeto Empleado seleccionado
            if (EmpleadosListbox.SelectedIndex != -1)
            {
                Empleado seleccionado = (Empleado)EmpleadosListbox.SelectedItem;

                // Reiniciar raiz cada vez que se selecciona un nuevo empleado
                raiz.LimpiarNodos();

                CargarPermisos(seleccionado.Puesto);

                // Limpiar el TreeView antes de cargar los nuevos permisos
                PermisosTreeview.Nodes.Clear();

                ConstruirTreeView(PermisosTreeview.Nodes, raiz);
            }
        }
    }
}
