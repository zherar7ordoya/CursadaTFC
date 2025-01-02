namespace GUI
{
    partial class CamionABM
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
            this.label1 = new System.Windows.Forms.Label();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.PatenteTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MarcaTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CamionesDGV = new System.Windows.Forms.DataGridView();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.ModificacionBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CamionesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(654, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdTXT
            // 
            this.IdTXT.Enabled = false;
            this.IdTXT.Location = new System.Drawing.Point(807, 14);
            this.IdTXT.Margin = new System.Windows.Forms.Padding(4);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(336, 33);
            this.IdTXT.TabIndex = 2;
            // 
            // PatenteTXT
            // 
            this.PatenteTXT.Location = new System.Drawing.Point(807, 59);
            this.PatenteTXT.Margin = new System.Windows.Forms.Padding(4);
            this.PatenteTXT.Name = "PatenteTXT";
            this.PatenteTXT.Size = new System.Drawing.Size(336, 33);
            this.PatenteTXT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(654, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MarcaTXT
            // 
            this.MarcaTXT.Location = new System.Drawing.Point(807, 104);
            this.MarcaTXT.Margin = new System.Windows.Forms.Padding(4);
            this.MarcaTXT.Name = "MarcaTXT";
            this.MarcaTXT.Size = new System.Drawing.Size(336, 33);
            this.MarcaTXT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(654, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CamionesDGV
            // 
            this.CamionesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CamionesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CamionesDGV.Location = new System.Drawing.Point(14, 14);
            this.CamionesDGV.Margin = new System.Windows.Forms.Padding(4);
            this.CamionesDGV.MultiSelect = false;
            this.CamionesDGV.Name = "CamionesDGV";
            this.CamionesDGV.RowHeadersWidth = 51;
            this.CamionesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CamionesDGV.Size = new System.Drawing.Size(631, 207);
            this.CamionesDGV.TabIndex = 1;
            this.CamionesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CamionesDGV_CellClick);
            this.CamionesDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CamionesDGV_RowEnter);
            // 
            // AltaBTN
            // 
            this.AltaBTN.AutoSize = true;
            this.AltaBTN.Location = new System.Drawing.Point(227, 229);
            this.AltaBTN.Margin = new System.Windows.Forms.Padding(4);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(108, 43);
            this.AltaBTN.TabIndex = 5;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.AutoSize = true;
            this.BajaBTN.Location = new System.Drawing.Point(344, 229);
            this.BajaBTN.Margin = new System.Windows.Forms.Padding(4);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(108, 43);
            this.BajaBTN.TabIndex = 6;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.AutoSize = true;
            this.ModificacionBTN.Location = new System.Drawing.Point(461, 229);
            this.ModificacionBTN.Margin = new System.Windows.Forms.Padding(4);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(185, 43);
            this.ModificacionBTN.TabIndex = 7;
            this.ModificacionBTN.Text = "Modificación";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // CamionFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 318);
            this.Controls.Add(this.ModificacionBTN);
            this.Controls.Add(this.BajaBTN);
            this.Controls.Add(this.AltaBTN);
            this.Controls.Add(this.CamionesDGV);
            this.Controls.Add(this.MarcaTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatenteTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "CamionFRM";
            this.Text = "CamionFRM";
            this.Load += new System.EventHandler(this.CamionFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamionesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.TextBox PatenteTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MarcaTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView CamionesDGV;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button ModificacionBTN;
    }
}