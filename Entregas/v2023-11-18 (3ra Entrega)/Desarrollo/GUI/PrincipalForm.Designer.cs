namespace GUI
{
    partial class PrincipalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuMudadora = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Camiones = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.Empleados = new System.Windows.Forms.ToolStripMenuItem();
            this.Facturas = new System.Windows.Forms.ToolStripMenuItem();
            this.Liquidaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Mudanzas = new System.Windows.Forms.ToolStripMenuItem();
            this.Órdenes = new System.Windows.Forms.ToolStripMenuItem();
            this.Tarifas = new System.Windows.Forms.ToolStripMenuItem();
            this.Venta = new System.Windows.Forms.ToolStripMenuItem();
            this.Captura = new System.Windows.Forms.ToolStripMenuItem();
            this.Facturación = new System.Windows.Forms.ToolStripMenuItem();
            this.Logística = new System.Windows.Forms.ToolStripMenuItem();
            this.Despacho = new System.Windows.Forms.ToolStripMenuItem();
            this.Liquidación = new System.Windows.Forms.ToolStripMenuItem();
            this.Seguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.Roles = new System.Windows.Forms.ToolStripMenuItem();
            this.Permisos = new System.Windows.Forms.ToolStripMenuItem();
            this.Respaldos = new System.Windows.Forms.ToolStripMenuItem();
            this.Restauraciones = new System.Windows.Forms.ToolStripMenuItem();
            this.Sistema = new System.Windows.Forms.ToolStripMenuItem();
            this.Dashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.Acerca = new System.Windows.Forms.ToolStripMenuItem();
            this.Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMudadora.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMudadora
            // 
            this.MenuMudadora.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuMudadora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.Venta,
            this.Logística,
            this.Seguridad,
            this.Sistema});
            this.MenuMudadora.Location = new System.Drawing.Point(0, 0);
            this.MenuMudadora.Name = "MenuMudadora";
            this.MenuMudadora.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.MenuMudadora.Size = new System.Drawing.Size(469, 24);
            this.MenuMudadora.TabIndex = 1;
            this.MenuMudadora.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Camiones,
            this.Clientes,
            this.Empleados,
            this.Facturas,
            this.Liquidaciones,
            this.Mudanzas,
            this.Órdenes,
            this.Tarifas});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(60, 22);
            this.Archivo.Text = "Archivo";
            // 
            // Camiones
            // 
            this.Camiones.Name = "Camiones";
            this.Camiones.Size = new System.Drawing.Size(147, 22);
            this.Camiones.Text = "Camiones";
            this.Camiones.Click += new System.EventHandler(this.Camiones_Click);
            // 
            // Clientes
            // 
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(147, 22);
            this.Clientes.Text = "Clientes";
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Empleados
            // 
            this.Empleados.Name = "Empleados";
            this.Empleados.Size = new System.Drawing.Size(147, 22);
            this.Empleados.Text = "Empleados";
            this.Empleados.Click += new System.EventHandler(this.Empleados_Click);
            // 
            // Facturas
            // 
            this.Facturas.Name = "Facturas";
            this.Facturas.Size = new System.Drawing.Size(147, 22);
            this.Facturas.Text = "Facturas";
            this.Facturas.Click += new System.EventHandler(this.Facturas_Click);
            // 
            // Liquidaciones
            // 
            this.Liquidaciones.Name = "Liquidaciones";
            this.Liquidaciones.Size = new System.Drawing.Size(147, 22);
            this.Liquidaciones.Text = "Liquidaciones";
            this.Liquidaciones.Click += new System.EventHandler(this.Liquidaciones_Click);
            // 
            // Mudanzas
            // 
            this.Mudanzas.Name = "Mudanzas";
            this.Mudanzas.Size = new System.Drawing.Size(147, 22);
            this.Mudanzas.Text = "Mudanzas";
            this.Mudanzas.Click += new System.EventHandler(this.Mudanzas_Click);
            // 
            // Órdenes
            // 
            this.Órdenes.Name = "Órdenes";
            this.Órdenes.Size = new System.Drawing.Size(147, 22);
            this.Órdenes.Text = "Órdenes";
            this.Órdenes.Click += new System.EventHandler(this.Órdenes_Click);
            // 
            // Tarifas
            // 
            this.Tarifas.Name = "Tarifas";
            this.Tarifas.Size = new System.Drawing.Size(147, 22);
            this.Tarifas.Text = "Tarifas";
            this.Tarifas.Click += new System.EventHandler(this.Tarifas_Click);
            // 
            // Venta
            // 
            this.Venta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Captura,
            this.Facturación});
            this.Venta.Name = "Venta";
            this.Venta.Size = new System.Drawing.Size(48, 22);
            this.Venta.Text = "Venta";
            // 
            // Captura
            // 
            this.Captura.Name = "Captura";
            this.Captura.Size = new System.Drawing.Size(136, 22);
            this.Captura.Text = "Captura";
            this.Captura.Click += new System.EventHandler(this.Captura_Click);
            // 
            // Facturación
            // 
            this.Facturación.Name = "Facturación";
            this.Facturación.Size = new System.Drawing.Size(136, 22);
            this.Facturación.Text = "Facturación";
            this.Facturación.Click += new System.EventHandler(this.Facturación_Click);
            // 
            // Logística
            // 
            this.Logística.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Despacho,
            this.Liquidación});
            this.Logística.Name = "Logística";
            this.Logística.Size = new System.Drawing.Size(66, 22);
            this.Logística.Text = "Logística";
            // 
            // Despacho
            // 
            this.Despacho.Name = "Despacho";
            this.Despacho.Size = new System.Drawing.Size(136, 22);
            this.Despacho.Text = "Despacho";
            this.Despacho.Click += new System.EventHandler(this.Despacho_Click);
            // 
            // Liquidación
            // 
            this.Liquidación.Name = "Liquidación";
            this.Liquidación.Size = new System.Drawing.Size(136, 22);
            this.Liquidación.Text = "Liquidación";
            this.Liquidación.Click += new System.EventHandler(this.Liquidación_Click);
            // 
            // Seguridad
            // 
            this.Seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Roles,
            this.Permisos,
            this.Respaldos,
            this.Restauraciones});
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Size = new System.Drawing.Size(72, 22);
            this.Seguridad.Text = "Seguridad";
            // 
            // Roles
            // 
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(153, 22);
            this.Roles.Text = "Roles";
            this.Roles.Click += new System.EventHandler(this.Roles_Click);
            // 
            // Permisos
            // 
            this.Permisos.Name = "Permisos";
            this.Permisos.Size = new System.Drawing.Size(153, 22);
            this.Permisos.Text = "Permisos";
            this.Permisos.Click += new System.EventHandler(this.Permisos_Click);
            // 
            // Respaldos
            // 
            this.Respaldos.Name = "Respaldos";
            this.Respaldos.Size = new System.Drawing.Size(153, 22);
            this.Respaldos.Text = "Respaldos";
            this.Respaldos.Click += new System.EventHandler(this.Respaldos_Click);
            // 
            // Restauraciones
            // 
            this.Restauraciones.Name = "Restauraciones";
            this.Restauraciones.Size = new System.Drawing.Size(153, 22);
            this.Restauraciones.Text = "Restauraciones";
            this.Restauraciones.Click += new System.EventHandler(this.Restauraciones_Click);
            // 
            // Sistema
            // 
            this.Sistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dashboard,
            this.Acerca,
            this.Salir});
            this.Sistema.Name = "Sistema";
            this.Sistema.Size = new System.Drawing.Size(60, 22);
            this.Sistema.Text = "Sistema";
            // 
            // Dashboard
            // 
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(180, 22);
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Acerca
            // 
            this.Acerca.Name = "Acerca";
            this.Acerca.Size = new System.Drawing.Size(180, 22);
            this.Acerca.Text = "Acerca";
            this.Acerca.Click += new System.EventHandler(this.Acerca_Click);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(180, 22);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 261);
            this.Controls.Add(this.MenuMudadora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuMudadora;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "PrincipalForm";
            this.Text = "PrincipalFRM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalForm_FormClosing);
            this.Load += new System.EventHandler(this.PrincipalForm_Load);
            this.MenuMudadora.ResumeLayout(false);
            this.MenuMudadora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMudadora;
        private System.Windows.Forms.ToolStripMenuItem Venta;
        private System.Windows.Forms.ToolStripMenuItem Captura;
        private System.Windows.Forms.ToolStripMenuItem Facturación;
        private System.Windows.Forms.ToolStripMenuItem Logística;
        private System.Windows.Forms.ToolStripMenuItem Despacho;
        private System.Windows.Forms.ToolStripMenuItem Liquidación;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem Camiones;
        private System.Windows.Forms.ToolStripMenuItem Clientes;
        private System.Windows.Forms.ToolStripMenuItem Empleados;
        private System.Windows.Forms.ToolStripMenuItem Facturas;
        private System.Windows.Forms.ToolStripMenuItem Liquidaciones;
        private System.Windows.Forms.ToolStripMenuItem Mudanzas;
        private System.Windows.Forms.ToolStripMenuItem Órdenes;
        private System.Windows.Forms.ToolStripMenuItem Tarifas;
        private System.Windows.Forms.ToolStripMenuItem Seguridad;
        private System.Windows.Forms.ToolStripMenuItem Respaldos;
        private System.Windows.Forms.ToolStripMenuItem Restauraciones;
        private System.Windows.Forms.ToolStripMenuItem Permisos;
        private System.Windows.Forms.ToolStripMenuItem Sistema;
        private System.Windows.Forms.ToolStripMenuItem Roles;
        private System.Windows.Forms.ToolStripMenuItem Acerca;
        private System.Windows.Forms.ToolStripMenuItem Salir;
        private System.Windows.Forms.ToolStripMenuItem Dashboard;
    }
}