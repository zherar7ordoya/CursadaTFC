namespace GUI
{
    partial class TarifaABM
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
            this.MontoKilometroTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CoeficientesDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DesdeDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HastaDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TarifasTreeview = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.CoeficientesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MontoKilometroTXT
            // 
            this.MontoKilometroTXT.Location = new System.Drawing.Point(461, 228);
            this.MontoKilometroTXT.Margin = new System.Windows.Forms.Padding(4);
            this.MontoKilometroTXT.Name = "MontoKilometroTXT";
            this.MontoKilometroTXT.Size = new System.Drawing.Size(148, 31);
            this.MontoKilometroTXT.TabIndex = 159;
            this.MontoKilometroTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 27);
            this.label8.TabIndex = 158;
            this.label8.Text = "Monto kilómetro";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CoeficientesDGV
            // 
            this.CoeficientesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CoeficientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoeficientesDGV.Location = new System.Drawing.Point(461, 316);
            this.CoeficientesDGV.Margin = new System.Windows.Forms.Padding(4);
            this.CoeficientesDGV.MultiSelect = false;
            this.CoeficientesDGV.Name = "CoeficientesDGV";
            this.CoeficientesDGV.RowHeadersWidth = 62;
            this.CoeficientesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CoeficientesDGV.Size = new System.Drawing.Size(388, 248);
            this.CoeficientesDGV.TabIndex = 157;
            this.CoeficientesDGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.CoeficientesDGV_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 156;
            this.label2.Text = "Coeficientes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DesdeDTP
            // 
            this.DesdeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDTP.Location = new System.Drawing.Point(536, 96);
            this.DesdeDTP.Margin = new System.Windows.Forms.Padding(4);
            this.DesdeDTP.Name = "DesdeDTP";
            this.DesdeDTP.Size = new System.Drawing.Size(148, 31);
            this.DesdeDTP.TabIndex = 155;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 154;
            this.label7.Text = "Desde";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.AutoSize = true;
            this.ModificacionBTN.Location = new System.Drawing.Point(229, 524);
            this.ModificacionBTN.Margin = new System.Windows.Forms.Padding(4);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(171, 40);
            this.ModificacionBTN.TabIndex = 151;
            this.ModificacionBTN.Text = "Modificación";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.AutoSize = true;
            this.BajaBTN.Location = new System.Drawing.Point(121, 524);
            this.BajaBTN.Margin = new System.Windows.Forms.Padding(4);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(100, 40);
            this.BajaBTN.TabIndex = 150;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.AutoSize = true;
            this.AltaBTN.Location = new System.Drawing.Point(13, 524);
            this.AltaBTN.Margin = new System.Windows.Forms.Padding(4);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(100, 40);
            this.AltaBTN.TabIndex = 149;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // IdTXT
            // 
            this.IdTXT.Enabled = false;
            this.IdTXT.Location = new System.Drawing.Point(461, 40);
            this.IdTXT.Margin = new System.Windows.Forms.Padding(4);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(148, 31);
            this.IdTXT.TabIndex = 147;
            this.IdTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 27);
            this.label1.TabIndex = 146;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HastaDTP
            // 
            this.HastaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDTP.Location = new System.Drawing.Point(536, 141);
            this.HastaDTP.Margin = new System.Windows.Forms.Padding(4);
            this.HastaDTP.Name = "HastaDTP";
            this.HastaDTP.Size = new System.Drawing.Size(148, 31);
            this.HastaDTP.TabIndex = 175;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 174;
            this.label3.Text = "Hasta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TarifasTreeview
            // 
            this.TarifasTreeview.Location = new System.Drawing.Point(12, 12);
            this.TarifasTreeview.Name = "TarifasTreeview";
            this.TarifasTreeview.Size = new System.Drawing.Size(388, 505);
            this.TarifasTreeview.TabIndex = 176;
            // 
            // TarifaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 612);
            this.Controls.Add(this.TarifasTreeview);
            this.Controls.Add(this.HastaDTP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MontoKilometroTXT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CoeficientesDGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DesdeDTP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ModificacionBTN);
            this.Controls.Add(this.BajaBTN);
            this.Controls.Add(this.AltaBTN);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TarifaABM";
            this.Text = "TarifaFRM";
            this.Load += new System.EventHandler(this.TarifaFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CoeficientesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MontoKilometroTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView CoeficientesDGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DesdeDTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HastaDTP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView TarifasTreeview;
    }
}