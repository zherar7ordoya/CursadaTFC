namespace GUI
{
    partial class MudanzaABM
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
            this.FechaDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.OrdenIDTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EstibadoresDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.InsumosDGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MarcaTXT = new System.Windows.Forms.TextBox();
            this.PatenteTXT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NombreApellidoTXT = new System.Windows.Forms.TextBox();
            this.DNITXT = new System.Windows.Forms.TextBox();
            this.MudanzasTreeview = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.EstibadoresDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FechaDTP
            // 
            this.FechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDTP.Location = new System.Drawing.Point(1106, 48);
            this.FechaDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaDTP.Name = "FechaDTP";
            this.FechaDTP.Size = new System.Drawing.Size(148, 31);
            this.FechaDTP.TabIndex = 103;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1101, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 100;
            this.label7.Text = "Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenIDTXT
            // 
            this.OrdenIDTXT.Location = new System.Drawing.Point(452, 48);
            this.OrdenIDTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OrdenIDTXT.Name = "OrdenIDTXT";
            this.OrdenIDTXT.Size = new System.Drawing.Size(148, 31);
            this.OrdenIDTXT.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 98;
            this.label6.Text = "OrdenID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.AutoSize = true;
            this.ModificacionBTN.Location = new System.Drawing.Point(236, 665);
            this.ModificacionBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(171, 44);
            this.ModificacionBTN.TabIndex = 96;
            this.ModificacionBTN.Text = "Modificación";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.AutoSize = true;
            this.BajaBTN.Location = new System.Drawing.Point(128, 665);
            this.BajaBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(100, 44);
            this.BajaBTN.TabIndex = 95;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.AutoSize = true;
            this.AltaBTN.Location = new System.Drawing.Point(20, 665);
            this.AltaBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(100, 44);
            this.AltaBTN.TabIndex = 94;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // IdTXT
            // 
            this.IdTXT.Enabled = false;
            this.IdTXT.Location = new System.Drawing.Point(864, 52);
            this.IdTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(148, 31);
            this.IdTXT.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(860, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 27);
            this.label1.TabIndex = 88;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EstibadoresDGV
            // 
            this.EstibadoresDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EstibadoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstibadoresDGV.Location = new System.Drawing.Point(453, 292);
            this.EstibadoresDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EstibadoresDGV.MultiSelect = false;
            this.EstibadoresDGV.Name = "EstibadoresDGV";
            this.EstibadoresDGV.RowHeadersWidth = 62;
            this.EstibadoresDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstibadoresDGV.Size = new System.Drawing.Size(802, 152);
            this.EstibadoresDGV.TabIndex = 109;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 27);
            this.label3.TabIndex = 108;
            this.label3.Text = "Estibadores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InsumosDGV
            // 
            this.InsumosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InsumosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InsumosDGV.Location = new System.Drawing.Point(452, 481);
            this.InsumosDGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InsumosDGV.MultiSelect = false;
            this.InsumosDGV.Name = "InsumosDGV";
            this.InsumosDGV.RowHeadersWidth = 62;
            this.InsumosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InsumosDGV.Size = new System.Drawing.Size(804, 229);
            this.InsumosDGV.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 27);
            this.label5.TabIndex = 110;
            this.label5.Text = "Insumos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MarcaTXT);
            this.groupBox1.Controls.Add(this.PatenteTXT);
            this.groupBox1.Location = new System.Drawing.Point(453, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 129);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patente";
            // 
            // MarcaTXT
            // 
            this.MarcaTXT.Location = new System.Drawing.Point(114, 70);
            this.MarcaTXT.Name = "MarcaTXT";
            this.MarcaTXT.Size = new System.Drawing.Size(271, 31);
            this.MarcaTXT.TabIndex = 1;
            // 
            // PatenteTXT
            // 
            this.PatenteTXT.Location = new System.Drawing.Point(10, 70);
            this.PatenteTXT.Name = "PatenteTXT";
            this.PatenteTXT.Size = new System.Drawing.Size(100, 31);
            this.PatenteTXT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NombreApellidoTXT);
            this.groupBox2.Controls.Add(this.DNITXT);
            this.groupBox2.Location = new System.Drawing.Point(864, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 129);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chofer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 27);
            this.label9.TabIndex = 5;
            this.label9.Text = "Nombre y Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 27);
            this.label8.TabIndex = 4;
            this.label8.Text = "DNI";
            // 
            // NombreApellidoTXT
            // 
            this.NombreApellidoTXT.Location = new System.Drawing.Point(118, 70);
            this.NombreApellidoTXT.Name = "NombreApellidoTXT";
            this.NombreApellidoTXT.Size = new System.Drawing.Size(265, 31);
            this.NombreApellidoTXT.TabIndex = 3;
            // 
            // DNITXT
            // 
            this.DNITXT.Location = new System.Drawing.Point(10, 70);
            this.DNITXT.Name = "DNITXT";
            this.DNITXT.Size = new System.Drawing.Size(100, 31);
            this.DNITXT.TabIndex = 2;
            // 
            // MudanzasTreeview
            // 
            this.MudanzasTreeview.Location = new System.Drawing.Point(20, 14);
            this.MudanzasTreeview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MudanzasTreeview.Name = "MudanzasTreeview";
            this.MudanzasTreeview.Size = new System.Drawing.Size(385, 639);
            this.MudanzasTreeview.TabIndex = 114;
            // 
            // MudanzaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 778);
            this.Controls.Add(this.MudanzasTreeview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InsumosDGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EstibadoresDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaDTP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrdenIDTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModificacionBTN);
            this.Controls.Add(this.BajaBTN);
            this.Controls.Add(this.AltaBTN);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MudanzaABM";
            this.Text = "MudanzaFRM";
            this.Load += new System.EventHandler(this.MudanzaABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstibadoresDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker FechaDTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OrdenIDTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EstibadoresDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView InsumosDGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MarcaTXT;
        private System.Windows.Forms.TextBox PatenteTXT;
        private System.Windows.Forms.TextBox NombreApellidoTXT;
        private System.Windows.Forms.TextBox DNITXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TreeView MudanzasTreeview;
    }
}