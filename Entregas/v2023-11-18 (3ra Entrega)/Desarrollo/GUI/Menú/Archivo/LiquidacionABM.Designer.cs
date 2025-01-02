namespace GUI
{
    partial class LiquidacionABM
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
            this.MontoReembolsoTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrdenIDTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalTXT = new System.Windows.Forms.TextBox();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.MontoOrdenTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComprobantesDGV = new System.Windows.Forms.DataGridView();
            this.LiquidacionesTreeview = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.ComprobantesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDTP
            // 
            this.FechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDTP.Location = new System.Drawing.Point(879, 40);
            this.FechaDTP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FechaDTP.Name = "FechaDTP";
            this.FechaDTP.Size = new System.Drawing.Size(148, 31);
            this.FechaDTP.TabIndex = 85;
            // 
            // MontoReembolsoTXT
            // 
            this.MontoReembolsoTXT.Location = new System.Drawing.Point(720, 358);
            this.MontoReembolsoTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MontoReembolsoTXT.Name = "MontoReembolsoTXT";
            this.MontoReembolsoTXT.Size = new System.Drawing.Size(307, 31);
            this.MontoReembolsoTXT.TabIndex = 84;
            this.MontoReembolsoTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 402);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 27);
            this.label8.TabIndex = 83;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(873, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 82;
            this.label7.Text = "Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenIDTXT
            // 
            this.OrdenIDTXT.Location = new System.Drawing.Point(720, 440);
            this.OrdenIDTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrdenIDTXT.Name = "OrdenIDTXT";
            this.OrdenIDTXT.Size = new System.Drawing.Size(307, 31);
            this.OrdenIDTXT.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 444);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 27);
            this.label6.TabIndex = 80;
            this.label6.Text = "OrdenID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalTXT
            // 
            this.TotalTXT.Location = new System.Drawing.Point(720, 398);
            this.TotalTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalTXT.Name = "TotalTXT";
            this.TotalTXT.Size = new System.Drawing.Size(307, 31);
            this.TotalTXT.TabIndex = 79;
            this.TotalTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.AutoSize = true;
            this.ModificacionBTN.Location = new System.Drawing.Point(229, 488);
            this.ModificacionBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(171, 40);
            this.ModificacionBTN.TabIndex = 78;
            this.ModificacionBTN.Text = "Modificación";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.AutoSize = true;
            this.BajaBTN.Location = new System.Drawing.Point(121, 488);
            this.BajaBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(100, 40);
            this.BajaBTN.TabIndex = 77;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.AutoSize = true;
            this.AltaBTN.Location = new System.Drawing.Point(13, 488);
            this.AltaBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(100, 40);
            this.AltaBTN.TabIndex = 76;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // MontoOrdenTXT
            // 
            this.MontoOrdenTXT.Location = new System.Drawing.Point(720, 316);
            this.MontoOrdenTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MontoOrdenTXT.Name = "MontoOrdenTXT";
            this.MontoOrdenTXT.Size = new System.Drawing.Size(307, 31);
            this.MontoOrdenTXT.TabIndex = 74;
            this.MontoOrdenTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 27);
            this.label3.TabIndex = 73;
            this.label3.Text = "Monto de la Orden";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 27);
            this.label2.TabIndex = 72;
            this.label2.Text = "Monto del Reembolso";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdTXT
            // 
            this.IdTXT.Enabled = false;
            this.IdTXT.Location = new System.Drawing.Point(471, 40);
            this.IdTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(148, 31);
            this.IdTXT.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 27);
            this.label1.TabIndex = 70;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 27);
            this.label4.TabIndex = 86;
            this.label4.Text = "Comprobantes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComprobantesDGV
            // 
            this.ComprobantesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ComprobantesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComprobantesDGV.Location = new System.Drawing.Point(465, 115);
            this.ComprobantesDGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComprobantesDGV.MultiSelect = false;
            this.ComprobantesDGV.Name = "ComprobantesDGV";
            this.ComprobantesDGV.RowHeadersWidth = 62;
            this.ComprobantesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComprobantesDGV.Size = new System.Drawing.Size(563, 193);
            this.ComprobantesDGV.TabIndex = 87;
            this.ComprobantesDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ComprobantesDGV_CellFormatting);
            // 
            // LiquidacionesTreeview
            // 
            this.LiquidacionesTreeview.Location = new System.Drawing.Point(12, 12);
            this.LiquidacionesTreeview.Name = "LiquidacionesTreeview";
            this.LiquidacionesTreeview.Size = new System.Drawing.Size(388, 469);
            this.LiquidacionesTreeview.TabIndex = 88;
            // 
            // LiquidacionABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 541);
            this.Controls.Add(this.LiquidacionesTreeview);
            this.Controls.Add(this.ComprobantesDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaDTP);
            this.Controls.Add(this.MontoReembolsoTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrdenIDTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalTXT);
            this.Controls.Add(this.ModificacionBTN);
            this.Controls.Add(this.BajaBTN);
            this.Controls.Add(this.AltaBTN);
            this.Controls.Add(this.MontoOrdenTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LiquidacionABM";
            this.Text = "LiquidacionFRM";
            this.Load += new System.EventHandler(this.LiquidacionFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprobantesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDTP;
        private System.Windows.Forms.TextBox MontoReembolsoTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OrdenIDTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalTXT;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.TextBox MontoOrdenTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ComprobantesDGV;
        private System.Windows.Forms.TreeView LiquidacionesTreeview;
    }
}