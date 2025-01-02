namespace GUI
{
    partial class RespaldoForm
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
            this.BitacorasDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TipoTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UsuarioTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FechaHoraTXT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DescribirTextbox = new System.Windows.Forms.TextBox();
            this.RespaldarBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BitacorasDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BitacorasDGV
            // 
            this.BitacorasDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.BitacorasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BitacorasDGV.Location = new System.Drawing.Point(12, 32);
            this.BitacorasDGV.MultiSelect = false;
            this.BitacorasDGV.Name = "BitacorasDGV";
            this.BitacorasDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BitacorasDGV.Size = new System.Drawing.Size(332, 148);
            this.BitacorasDGV.TabIndex = 0;
            this.BitacorasDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BitacorasDGV_CellClick);
            this.BitacorasDGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.BitacorasDGV_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bitácora";
            // 
            // IdTXT
            // 
            this.IdTXT.Location = new System.Drawing.Point(466, 31);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(220, 25);
            this.IdTXT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(350, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(350, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripción";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DescripcionTXT
            // 
            this.DescripcionTXT.Location = new System.Drawing.Point(466, 155);
            this.DescripcionTXT.Name = "DescripcionTXT";
            this.DescripcionTXT.Size = new System.Drawing.Size(220, 25);
            this.DescripcionTXT.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(350, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TipoTXT
            // 
            this.TipoTXT.Location = new System.Drawing.Point(466, 124);
            this.TipoTXT.Name = "TipoTXT";
            this.TipoTXT.Size = new System.Drawing.Size(220, 25);
            this.TipoTXT.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(350, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Usuario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsuarioTXT
            // 
            this.UsuarioTXT.Location = new System.Drawing.Point(466, 93);
            this.UsuarioTXT.Name = "UsuarioTXT";
            this.UsuarioTXT.Size = new System.Drawing.Size(220, 25);
            this.UsuarioTXT.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(350, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha/Hora";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaHoraTXT
            // 
            this.FechaHoraTXT.Location = new System.Drawing.Point(466, 62);
            this.FechaHoraTXT.Name = "FechaHoraTXT";
            this.FechaHoraTXT.Size = new System.Drawing.Size(220, 25);
            this.FechaHoraTXT.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RespaldarBTN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DescribirTextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hacer nuevo respaldo";
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
            // RespaldarBTN
            // 
            this.RespaldarBTN.AutoSize = true;
            this.RespaldarBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RespaldarBTN.Location = new System.Drawing.Point(568, 42);
            this.RespaldarBTN.Name = "RespaldarBTN";
            this.RespaldarBTN.Size = new System.Drawing.Size(100, 30);
            this.RespaldarBTN.TabIndex = 8;
            this.RespaldarBTN.Text = "Respaldar";
            this.RespaldarBTN.UseVisualStyleBackColor = true;
            this.RespaldarBTN.Click += new System.EventHandler(this.RespaldarBTN_Click);
            // 
            // RespaldoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 364);
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
            this.Controls.Add(this.BitacorasDGV);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "RespaldoForm";
            this.Text = "RespaldoForm";
            this.Load += new System.EventHandler(this.RespaldoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BitacorasDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BitacorasDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TipoTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsuarioTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FechaHoraTXT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RespaldarBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescribirTextbox;
    }
}