namespace GUI
{
    partial class FacturaABM
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
            this.ImpuestoTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrdenIDTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalTXT = new System.Windows.Forms.TextBox();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.FacturasDGV = new System.Windows.Forms.DataGridView();
            this.MontoOrdenTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDTP
            // 
            this.FechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDTP.Location = new System.Drawing.Point(849, 41);
            this.FechaDTP.Name = "FechaDTP";
            this.FechaDTP.Size = new System.Drawing.Size(150, 25);
            this.FechaDTP.TabIndex = 69;
            // 
            // ImpuestoTXT
            // 
            this.ImpuestoTXT.Location = new System.Drawing.Point(849, 99);
            this.ImpuestoTXT.Name = "ImpuestoTXT";
            this.ImpuestoTXT.Size = new System.Drawing.Size(150, 25);
            this.ImpuestoTXT.TabIndex = 68;
            this.ImpuestoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(678, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 25);
            this.label8.TabIndex = 67;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(678, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrdenIDTXT
            // 
            this.OrdenIDTXT.Location = new System.Drawing.Point(849, 160);
            this.OrdenIDTXT.Name = "OrdenIDTXT";
            this.OrdenIDTXT.Size = new System.Drawing.Size(150, 25);
            this.OrdenIDTXT.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(678, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "OrdenID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalTXT
            // 
            this.TotalTXT.Location = new System.Drawing.Point(849, 129);
            this.TotalTXT.Name = "TotalTXT";
            this.TotalTXT.Size = new System.Drawing.Size(150, 25);
            this.TotalTXT.TabIndex = 60;
            this.TotalTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.AutoSize = true;
            this.ModificacionBTN.Location = new System.Drawing.Point(544, 191);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(128, 30);
            this.ModificacionBTN.TabIndex = 58;
            this.ModificacionBTN.Text = "Modificación";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.AutoSize = true;
            this.BajaBTN.Location = new System.Drawing.Point(463, 191);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(75, 30);
            this.BajaBTN.TabIndex = 57;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.AutoSize = true;
            this.AltaBTN.Location = new System.Drawing.Point(382, 191);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(75, 30);
            this.AltaBTN.TabIndex = 56;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // FacturasDGV
            // 
            this.FacturasDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.FacturasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturasDGV.Location = new System.Drawing.Point(12, 11);
            this.FacturasDGV.MultiSelect = false;
            this.FacturasDGV.Name = "FacturasDGV";
            this.FacturasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FacturasDGV.Size = new System.Drawing.Size(660, 174);
            this.FacturasDGV.TabIndex = 1;
            this.FacturasDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FacturasDGV_CellClick);
            this.FacturasDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.FacturasDGV_CellFormatting);
            // 
            // MontoOrdenTXT
            // 
            this.MontoOrdenTXT.Location = new System.Drawing.Point(849, 71);
            this.MontoOrdenTXT.Name = "MontoOrdenTXT";
            this.MontoOrdenTXT.Size = new System.Drawing.Size(150, 25);
            this.MontoOrdenTXT.TabIndex = 54;
            this.MontoOrdenTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(678, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Monto de la Orden";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(678, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Impuesto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdTXT
            // 
            this.IdTXT.Enabled = false;
            this.IdTXT.Location = new System.Drawing.Point(849, 10);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(150, 25);
            this.IdTXT.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(678, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FacturaFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 230);
            this.Controls.Add(this.FechaDTP);
            this.Controls.Add(this.ImpuestoTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrdenIDTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalTXT);
            this.Controls.Add(this.ModificacionBTN);
            this.Controls.Add(this.BajaBTN);
            this.Controls.Add(this.AltaBTN);
            this.Controls.Add(this.FacturasDGV);
            this.Controls.Add(this.MontoOrdenTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Name = "FacturaFRM";
            this.Text = "FacturaFRM";
            this.Load += new System.EventHandler(this.FacturaFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturasDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDTP;
        private System.Windows.Forms.TextBox ImpuestoTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OrdenIDTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalTXT;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.DataGridView FacturasDGV;
        private System.Windows.Forms.TextBox MontoOrdenTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label1;
    }
}