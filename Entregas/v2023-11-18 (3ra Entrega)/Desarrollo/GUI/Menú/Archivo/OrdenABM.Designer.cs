namespace GUI
{
    partial class OrdenABM
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
            this.MueblesDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ClienteIDTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EstadoTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DireccionOrigenTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DireccionDestinoTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LugarCargaTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LugarDescargaTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ObservacionesTXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.KilometrosDistanciaTXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MontoTXT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.OrdenesTreeview = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.MueblesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MueblesDGV
            // 
            this.MueblesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MueblesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MueblesDGV.Location = new System.Drawing.Point(545, 33);
            this.MueblesDGV.MultiSelect = false;
            this.MueblesDGV.Name = "MueblesDGV";
            this.MueblesDGV.RowHeadersWidth = 25;
            this.MueblesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MueblesDGV.Size = new System.Drawing.Size(312, 319);
            this.MueblesDGV.TabIndex = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 124;
            this.label2.Text = "Muebles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaDTP
            // 
            this.FechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDTP.Location = new System.Drawing.Point(439, 33);
            this.FechaDTP.Name = "FechaDTP";
            this.FechaDTP.Size = new System.Drawing.Size(100, 25);
            this.FechaDTP.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 120;
            this.label7.Text = "Fecha servicio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClienteIDTXT
            // 
            this.ClienteIDTXT.Location = new System.Drawing.Point(439, 327);
            this.ClienteIDTXT.Name = "ClienteIDTXT";
            this.ClienteIDTXT.Size = new System.Drawing.Size(100, 25);
            this.ClienteIDTXT.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 118;
            this.label6.Text = "ClienteID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.AutoSize = true;
            this.ModificacionBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificacionBTN.Location = new System.Drawing.Point(760, 358);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(97, 28);
            this.ModificacionBTN.TabIndex = 117;
            this.ModificacionBTN.Text = "Modificación";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.AutoSize = true;
            this.BajaBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BajaBTN.Location = new System.Drawing.Point(710, 358);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(44, 28);
            this.BajaBTN.TabIndex = 116;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.AutoSize = true;
            this.AltaBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AltaBTN.Location = new System.Drawing.Point(661, 358);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(43, 28);
            this.AltaBTN.TabIndex = 115;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // IdTXT
            // 
            this.IdTXT.Enabled = false;
            this.IdTXT.Location = new System.Drawing.Point(227, 33);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(100, 25);
            this.IdTXT.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 112;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EstadoTXT
            // 
            this.EstadoTXT.Location = new System.Drawing.Point(333, 33);
            this.EstadoTXT.Name = "EstadoTXT";
            this.EstadoTXT.Size = new System.Drawing.Size(100, 25);
            this.EstadoTXT.TabIndex = 131;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 18);
            this.label8.TabIndex = 130;
            this.label8.Text = "Estado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DireccionOrigenTXT
            // 
            this.DireccionOrigenTXT.Location = new System.Drawing.Point(226, 82);
            this.DireccionOrigenTXT.Name = "DireccionOrigenTXT";
            this.DireccionOrigenTXT.Size = new System.Drawing.Size(313, 25);
            this.DireccionOrigenTXT.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(223, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 18);
            this.label9.TabIndex = 132;
            this.label9.Text = "Dirección de Origen";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DireccionDestinoTXT
            // 
            this.DireccionDestinoTXT.Location = new System.Drawing.Point(226, 180);
            this.DireccionDestinoTXT.Name = "DireccionDestinoTXT";
            this.DireccionDestinoTXT.Size = new System.Drawing.Size(313, 25);
            this.DireccionDestinoTXT.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 134;
            this.label3.Text = "Dirección de Destino";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LugarCargaTXT
            // 
            this.LugarCargaTXT.Location = new System.Drawing.Point(226, 131);
            this.LugarCargaTXT.Name = "LugarCargaTXT";
            this.LugarCargaTXT.Size = new System.Drawing.Size(313, 25);
            this.LugarCargaTXT.TabIndex = 137;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 18);
            this.label4.TabIndex = 136;
            this.label4.Text = "Descripción del lugar de carga";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LugarDescargaTXT
            // 
            this.LugarDescargaTXT.Location = new System.Drawing.Point(226, 229);
            this.LugarDescargaTXT.Name = "LugarDescargaTXT";
            this.LugarDescargaTXT.Size = new System.Drawing.Size(313, 25);
            this.LugarDescargaTXT.TabIndex = 139;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 18);
            this.label5.TabIndex = 138;
            this.label5.Text = "Descripción del lugar de descarga";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ObservacionesTXT
            // 
            this.ObservacionesTXT.Location = new System.Drawing.Point(227, 278);
            this.ObservacionesTXT.Name = "ObservacionesTXT";
            this.ObservacionesTXT.Size = new System.Drawing.Size(312, 25);
            this.ObservacionesTXT.TabIndex = 141;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 140;
            this.label10.Text = "Observaciones";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KilometrosDistanciaTXT
            // 
            this.KilometrosDistanciaTXT.Location = new System.Drawing.Point(227, 327);
            this.KilometrosDistanciaTXT.Name = "KilometrosDistanciaTXT";
            this.KilometrosDistanciaTXT.Size = new System.Drawing.Size(100, 25);
            this.KilometrosDistanciaTXT.TabIndex = 143;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(223, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 142;
            this.label11.Text = "Distancia";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MontoTXT
            // 
            this.MontoTXT.Location = new System.Drawing.Point(333, 327);
            this.MontoTXT.Name = "MontoTXT";
            this.MontoTXT.Size = new System.Drawing.Size(100, 25);
            this.MontoTXT.TabIndex = 145;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 306);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 144;
            this.label12.Text = "Monto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenesTreeview
            // 
            this.OrdenesTreeview.Location = new System.Drawing.Point(11, 11);
            this.OrdenesTreeview.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenesTreeview.Name = "OrdenesTreeview";
            this.OrdenesTreeview.Size = new System.Drawing.Size(207, 343);
            this.OrdenesTreeview.TabIndex = 146;
            // 
            // OrdenABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 401);
            this.Controls.Add(this.OrdenesTreeview);
            this.Controls.Add(this.MontoTXT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.KilometrosDistanciaTXT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ObservacionesTXT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LugarDescargaTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LugarCargaTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DireccionDestinoTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DireccionOrigenTXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EstadoTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MueblesDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaDTP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClienteIDTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModificacionBTN);
            this.Controls.Add(this.BajaBTN);
            this.Controls.Add(this.AltaBTN);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "OrdenABM";
            this.Text = "OrdenFRM";
            this.Load += new System.EventHandler(this.OrdenFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MueblesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView MueblesDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ClienteIDTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EstadoTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DireccionOrigenTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DireccionDestinoTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LugarCargaTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LugarDescargaTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ObservacionesTXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox KilometrosDistanciaTXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MontoTXT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TreeView OrdenesTreeview;
    }
}