namespace GUI
{
    partial class RestauracionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RestaurarBTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DescribirTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaHoraTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UsuarioTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RespaldosDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RespaldosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RestaurarBTN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DescribirTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hacer una restauración";
            // 
            // RestaurarBTN
            // 
            this.RestaurarBTN.AutoSize = true;
            this.RestaurarBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RestaurarBTN.Location = new System.Drawing.Point(568, 42);
            this.RestaurarBTN.Name = "RestaurarBTN";
            this.RestaurarBTN.Size = new System.Drawing.Size(100, 30);
            this.RestaurarBTN.TabIndex = 8;
            this.RestaurarBTN.Text = "Restaurar";
            this.RestaurarBTN.UseVisualStyleBackColor = true;
            this.RestaurarBTN.Click += new System.EventHandler(this.RespaldarBTN_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripción";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescribirTextbox
            // 
            this.DescribirTextbox.Location = new System.Drawing.Point(122, 44);
            this.DescribirTextbox.Name = "DescribirTextbox";
            this.DescribirTextbox.Size = new System.Drawing.Size(440, 25);
            this.DescribirTextbox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(350, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Fecha/Hora";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaHoraTXT
            // 
            this.FechaHoraTXT.Location = new System.Drawing.Point(466, 62);
            this.FechaHoraTXT.Name = "FechaHoraTXT";
            this.FechaHoraTXT.Size = new System.Drawing.Size(220, 25);
            this.FechaHoraTXT.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(350, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Usuario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsuarioTXT
            // 
            this.UsuarioTXT.Location = new System.Drawing.Point(466, 93);
            this.UsuarioTXT.Name = "UsuarioTXT";
            this.UsuarioTXT.Size = new System.Drawing.Size(220, 25);
            this.UsuarioTXT.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(350, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TipoTXT
            // 
            this.TipoTXT.Location = new System.Drawing.Point(466, 124);
            this.TipoTXT.Name = "TipoTXT";
            this.TipoTXT.Size = new System.Drawing.Size(220, 25);
            this.TipoTXT.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(350, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descripción";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescripcionTXT
            // 
            this.DescripcionTXT.Location = new System.Drawing.Point(466, 155);
            this.DescripcionTXT.Name = "DescripcionTXT";
            this.DescripcionTXT.Size = new System.Drawing.Size(220, 25);
            this.DescripcionTXT.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(350, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdTXT
            // 
            this.IdTXT.Location = new System.Drawing.Point(466, 31);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(220, 25);
            this.IdTXT.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Copias de seguridad";
            // 
            // RespaldosDGV
            // 
            this.RespaldosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.RespaldosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RespaldosDGV.Location = new System.Drawing.Point(12, 32);
            this.RespaldosDGV.MultiSelect = false;
            this.RespaldosDGV.Name = "RespaldosDGV";
            this.RespaldosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RespaldosDGV.Size = new System.Drawing.Size(332, 148);
            this.RespaldosDGV.TabIndex = 13;
            this.RespaldosDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RespaldosDGV_CellClick);
            this.RespaldosDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RespaldosDGV_RowEnter);
            // 
            // RestauracionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 376);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FechaHoraTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UsuarioTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TipoTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionTXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RespaldosDGV);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "RestauracionForm";
            this.Text = "RestauracionForm";
            this.Load += new System.EventHandler(this.RestauracionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RespaldosDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RestaurarBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescribirTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FechaHoraTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsuarioTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TipoTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RespaldosDGV;
    }
}