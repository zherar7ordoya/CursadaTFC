namespace GUI
{
    partial class EmpleadoABM
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
            this.PuestoCBX = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DireccionTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonoTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.EmpleadosDGV = new System.Windows.Forms.DataGridView();
            this.NombreApellidoTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DNITXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FechaAltaDTP = new System.Windows.Forms.DateTimePicker();
            this.IntentoTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PasswordTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UsernameTXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PuestoCBX
            // 
            this.PuestoCBX.FormattingEnabled = true;
            this.PuestoCBX.Items.AddRange(new object[] {
            "Administrador",
            "Cajero",
            "Chofer",
            "Estibador",
            "Gerente de Operaciones",
            "Jefe de Logística",
            "Jefe de Venta",
            "Logístico",
            "Vendedor"});
            this.PuestoCBX.Location = new System.Drawing.Point(503, 120);
            this.PuestoCBX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PuestoCBX.Name = "PuestoCBX";
            this.PuestoCBX.Size = new System.Drawing.Size(178, 23);
            this.PuestoCBX.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(453, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Fecha de Alta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DireccionTXT
            // 
            this.DireccionTXT.Location = new System.Drawing.Point(518, 147);
            this.DireccionTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DireccionTXT.Name = "DireccionTXT";
            this.DireccionTXT.Size = new System.Drawing.Size(163, 24);
            this.DireccionTXT.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Dirección";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(496, 203);
            this.EmailTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(185, 24);
            this.EmailTXT.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TelefonoTXT
            // 
            this.TelefonoTXT.Location = new System.Drawing.Point(507, 175);
            this.TelefonoTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TelefonoTXT.Name = "TelefonoTXT";
            this.TelefonoTXT.Size = new System.Drawing.Size(174, 24);
            this.TelefonoTXT.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Teléfono";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.AutoSize = true;
            this.ModificacionBTN.Location = new System.Drawing.Point(343, 315);
            this.ModificacionBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(100, 27);
            this.ModificacionBTN.TabIndex = 37;
            this.ModificacionBTN.Text = "Modificación";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.AutoSize = true;
            this.BajaBTN.Location = new System.Drawing.Point(281, 315);
            this.BajaBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(58, 27);
            this.BajaBTN.TabIndex = 36;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.AutoSize = true;
            this.AltaBTN.Location = new System.Drawing.Point(219, 315);
            this.AltaBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(58, 27);
            this.AltaBTN.TabIndex = 35;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // EmpleadosDGV
            // 
            this.EmpleadosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EmpleadosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadosDGV.Location = new System.Drawing.Point(9, 8);
            this.EmpleadosDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpleadosDGV.MultiSelect = false;
            this.EmpleadosDGV.Name = "EmpleadosDGV";
            this.EmpleadosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpleadosDGV.Size = new System.Drawing.Size(434, 303);
            this.EmpleadosDGV.TabIndex = 1;
            this.EmpleadosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpleadosDGV_CellClick);
            this.EmpleadosDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpleadosDGV_RowEnter);
            // 
            // NombreApellidoTXT
            // 
            this.NombreApellidoTXT.Location = new System.Drawing.Point(568, 64);
            this.NombreApellidoTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NombreApellidoTXT.Name = "NombreApellidoTXT";
            this.NombreApellidoTXT.Size = new System.Drawing.Size(113, 24);
            this.NombreApellidoTXT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre y Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "DNI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdTXT
            // 
            this.IdTXT.Enabled = false;
            this.IdTXT.Location = new System.Drawing.Point(476, 8);
            this.IdTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(205, 24);
            this.IdTXT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DNITXT
            // 
            this.DNITXT.Location = new System.Drawing.Point(487, 36);
            this.DNITXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DNITXT.Name = "DNITXT";
            this.DNITXT.Size = new System.Drawing.Size(194, 24);
            this.DNITXT.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Puesto";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaAltaDTP
            // 
            this.FechaAltaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaAltaDTP.Location = new System.Drawing.Point(541, 92);
            this.FechaAltaDTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FechaAltaDTP.Name = "FechaAltaDTP";
            this.FechaAltaDTP.Size = new System.Drawing.Size(140, 24);
            this.FechaAltaDTP.TabIndex = 5;
            // 
            // IntentoTXT
            // 
            this.IntentoTXT.Location = new System.Drawing.Point(507, 287);
            this.IntentoTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IntentoTXT.Name = "IntentoTXT";
            this.IntentoTXT.Size = new System.Drawing.Size(174, 24);
            this.IntentoTXT.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Intento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordTXT
            // 
            this.PasswordTXT.Location = new System.Drawing.Point(518, 259);
            this.PasswordTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTXT.Name = "PasswordTXT";
            this.PasswordTXT.Size = new System.Drawing.Size(163, 24);
            this.PasswordTXT.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 261);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsernameTXT
            // 
            this.UsernameTXT.Location = new System.Drawing.Point(523, 231);
            this.UsernameTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameTXT.Name = "UsernameTXT";
            this.UsernameTXT.Size = new System.Drawing.Size(158, 24);
            this.UsernameTXT.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(453, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Username";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmpleadoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 363);
            this.Controls.Add(this.UsernameTXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PasswordTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IntentoTXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FechaAltaDTP);
            this.Controls.Add(this.DNITXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PuestoCBX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DireccionTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelefonoTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModificacionBTN);
            this.Controls.Add(this.BajaBTN);
            this.Controls.Add(this.AltaBTN);
            this.Controls.Add(this.EmpleadosDGV);
            this.Controls.Add(this.NombreApellidoTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmpleadoABM";
            this.Text = "EmpleadoFRM";
            this.Load += new System.EventHandler(this.EmpleadoFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PuestoCBX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DireccionTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelefonoTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.DataGridView EmpleadosDGV;
        private System.Windows.Forms.TextBox NombreApellidoTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNITXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechaAltaDTP;
        private System.Windows.Forms.TextBox IntentoTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PasswordTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UsernameTXT;
        private System.Windows.Forms.Label label11;
    }
}