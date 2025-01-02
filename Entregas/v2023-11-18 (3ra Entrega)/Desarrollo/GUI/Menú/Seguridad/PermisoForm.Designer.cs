namespace GUI
{
    partial class PermisoForm
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
            this.EmpleadosListbox = new System.Windows.Forms.ListBox();
            this.GrabarBTN = new System.Windows.Forms.Button();
            this.PermisoQuitarBTN = new System.Windows.Forms.Button();
            this.PermisoAgregarBTN = new System.Windows.Forms.Button();
            this.RolTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PermisoTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PermisosTreeview = new System.Windows.Forms.TreeView();
            this.RolesCombobox = new System.Windows.Forms.ComboBox();
            this.PermisosCombobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EmpleadosListbox
            // 
            this.EmpleadosListbox.FormattingEnabled = true;
            this.EmpleadosListbox.ItemHeight = 15;
            this.EmpleadosListbox.Location = new System.Drawing.Point(11, 11);
            this.EmpleadosListbox.Margin = new System.Windows.Forms.Padding(2);
            this.EmpleadosListbox.Name = "EmpleadosListbox";
            this.EmpleadosListbox.Size = new System.Drawing.Size(175, 259);
            this.EmpleadosListbox.TabIndex = 20;
            this.EmpleadosListbox.SelectedIndexChanged += new System.EventHandler(this.EmpleadosLista_SelectedIndexChanged);
            // 
            // GrabarBTN
            // 
            this.GrabarBTN.AutoSize = true;
            this.GrabarBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrabarBTN.Location = new System.Drawing.Point(470, 243);
            this.GrabarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.GrabarBTN.Name = "GrabarBTN";
            this.GrabarBTN.Size = new System.Drawing.Size(58, 27);
            this.GrabarBTN.TabIndex = 19;
            this.GrabarBTN.Text = "Grabar";
            this.GrabarBTN.UseVisualStyleBackColor = true;
            this.GrabarBTN.Click += new System.EventHandler(this.GrabarBTN_Click);
            // 
            // PermisoQuitarBTN
            // 
            this.PermisoQuitarBTN.AutoSize = true;
            this.PermisoQuitarBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PermisoQuitarBTN.Location = new System.Drawing.Point(470, 160);
            this.PermisoQuitarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.PermisoQuitarBTN.Name = "PermisoQuitarBTN";
            this.PermisoQuitarBTN.Size = new System.Drawing.Size(54, 27);
            this.PermisoQuitarBTN.TabIndex = 18;
            this.PermisoQuitarBTN.Text = "Quitar";
            this.PermisoQuitarBTN.UseVisualStyleBackColor = true;
            this.PermisoQuitarBTN.Click += new System.EventHandler(this.PermisoQuitarBTN_Click);
            // 
            // PermisoAgregarBTN
            // 
            this.PermisoAgregarBTN.AutoSize = true;
            this.PermisoAgregarBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PermisoAgregarBTN.Location = new System.Drawing.Point(402, 160);
            this.PermisoAgregarBTN.Margin = new System.Windows.Forms.Padding(2);
            this.PermisoAgregarBTN.Name = "PermisoAgregarBTN";
            this.PermisoAgregarBTN.Size = new System.Drawing.Size(64, 27);
            this.PermisoAgregarBTN.TabIndex = 17;
            this.PermisoAgregarBTN.Text = "Agregar";
            this.PermisoAgregarBTN.UseVisualStyleBackColor = true;
            this.PermisoAgregarBTN.Click += new System.EventHandler(this.PermisoAgregarBTN_Click);
            // 
            // RolTXT
            // 
            this.RolTXT.Location = new System.Drawing.Point(0, 0);
            this.RolTXT.Name = "RolTXT";
            this.RolTXT.Size = new System.Drawing.Size(100, 20);
            this.RolTXT.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Permiso";
            // 
            // PermisoTXT
            // 
            this.PermisoTXT.Location = new System.Drawing.Point(0, 0);
            this.PermisoTXT.Name = "PermisoTXT";
            this.PermisoTXT.Size = new System.Drawing.Size(100, 20);
            this.PermisoTXT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rol";
            // 
            // PermisosTreeview
            // 
            this.PermisosTreeview.Location = new System.Drawing.Point(208, 11);
            this.PermisosTreeview.Margin = new System.Windows.Forms.Padding(2);
            this.PermisosTreeview.Name = "PermisosTreeview";
            this.PermisosTreeview.Size = new System.Drawing.Size(175, 259);
            this.PermisosTreeview.TabIndex = 12;
            this.PermisosTreeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.PermisosArbol_AfterSelect);
            // 
            // RolesCombobox
            // 
            this.RolesCombobox.FormattingEnabled = true;
            this.RolesCombobox.Items.AddRange(new object[] {
            "Administrador",
            "Cajero",
            "Chofer",
            "Estibador",
            "Gerente de Operaciones",
            "Jefe de Logística",
            "Jefe de Venta",
            "Logístico",
            "Vendedor"});
            this.RolesCombobox.Location = new System.Drawing.Point(402, 30);
            this.RolesCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.RolesCombobox.Name = "RolesCombobox";
            this.RolesCombobox.Size = new System.Drawing.Size(121, 23);
            this.RolesCombobox.TabIndex = 21;
            // 
            // PermisosCombobox
            // 
            this.PermisosCombobox.FormattingEnabled = true;
            this.PermisosCombobox.Items.AddRange(new object[] {
            "About",
            "Administración",
            "Camiones",
            "Captura",
            "Clientes",
            "Dashboard",
            "Despacho",
            "Empleados",
            "Facturación",
            "Facturas",
            "Liquidación",
            "Liquidaciones",
            "Logística",
            "Mudanzas",
            "Órdenes",
            "Permisos",
            "Respaldos",
            "Restauraciones",
            "Roles",
            "Seguridad",
            "Tarifas",
            "Venta"});
            this.PermisosCombobox.Location = new System.Drawing.Point(402, 102);
            this.PermisosCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.PermisosCombobox.Name = "PermisosCombobox";
            this.PermisosCombobox.Size = new System.Drawing.Size(121, 23);
            this.PermisosCombobox.TabIndex = 22;
            // 
            // PermisoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 307);
            this.Controls.Add(this.EmpleadosListbox);
            this.Controls.Add(this.GrabarBTN);
            this.Controls.Add(this.PermisoQuitarBTN);
            this.Controls.Add(this.PermisoAgregarBTN);
            this.Controls.Add(this.RolesCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PermisosCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PermisosTreeview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PermisoForm";
            this.Text = "PermisoForm";
            this.Load += new System.EventHandler(this.PermisoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EmpleadosListbox;
        private System.Windows.Forms.Button GrabarBTN;
        private System.Windows.Forms.Button PermisoQuitarBTN;
        private System.Windows.Forms.Button PermisoAgregarBTN;
        private System.Windows.Forms.TextBox RolTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PermisoTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView PermisosTreeview;
        private System.Windows.Forms.ComboBox RolesCombobox;
        private System.Windows.Forms.ComboBox PermisosCombobox;
    }
}