namespace GUI
{
    partial class CapturaForm
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
            this.MudanzaMontoTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MudanzaKilometrosTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MudanzaObservacionesTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MudanzaLugarDescargaTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MudanzaLugarCargaTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MudanzaDestinoTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MudanzaOrigenTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MueblesDatagridview = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.MudanzaFechaDTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.GrabarButton = new System.Windows.Forms.Button();
            this.MudanzaCategoriaTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cliente_DNI_o_CUIT_Textbox = new System.Windows.Forms.TextBox();
            this.ClienteNombreTextbox = new System.Windows.Forms.TextBox();
            this.ClienteDireccionTextbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ClienteIdTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MueblesDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // MudanzaMontoTextbox
            // 
            this.MudanzaMontoTextbox.Location = new System.Drawing.Point(506, 492);
            this.MudanzaMontoTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaMontoTextbox.Name = "MudanzaMontoTextbox";
            this.MudanzaMontoTextbox.Size = new System.Drawing.Size(100, 25);
            this.MudanzaMontoTextbox.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 469);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 168;
            this.label12.Text = "Monto";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MudanzaKilometrosTextbox
            // 
            this.MudanzaKilometrosTextbox.Location = new System.Drawing.Point(178, 492);
            this.MudanzaKilometrosTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaKilometrosTextbox.Name = "MudanzaKilometrosTextbox";
            this.MudanzaKilometrosTextbox.Size = new System.Drawing.Size(100, 25);
            this.MudanzaKilometrosTextbox.TabIndex = 9;
            this.MudanzaKilometrosTextbox.Leave += new System.EventHandler(this.KilometrosDistanciaTextbox_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(175, 469);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 18);
            this.label11.TabIndex = 166;
            this.label11.Text = "Distancia kilómetros";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MudanzaObservacionesTextbox
            // 
            this.MudanzaObservacionesTextbox.Location = new System.Drawing.Point(24, 422);
            this.MudanzaObservacionesTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaObservacionesTextbox.Name = "MudanzaObservacionesTextbox";
            this.MudanzaObservacionesTextbox.Size = new System.Drawing.Size(435, 25);
            this.MudanzaObservacionesTextbox.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 400);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 18);
            this.label10.TabIndex = 164;
            this.label10.Text = "Observaciones";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MudanzaLugarDescargaTextbox
            // 
            this.MudanzaLugarDescargaTextbox.Location = new System.Drawing.Point(24, 365);
            this.MudanzaLugarDescargaTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaLugarDescargaTextbox.Name = "MudanzaLugarDescargaTextbox";
            this.MudanzaLugarDescargaTextbox.Size = new System.Drawing.Size(435, 25);
            this.MudanzaLugarDescargaTextbox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 18);
            this.label5.TabIndex = 162;
            this.label5.Text = "Descripción del lugar de descarga";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MudanzaLugarCargaTextbox
            // 
            this.MudanzaLugarCargaTextbox.Location = new System.Drawing.Point(24, 256);
            this.MudanzaLugarCargaTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaLugarCargaTextbox.Name = "MudanzaLugarCargaTextbox";
            this.MudanzaLugarCargaTextbox.Size = new System.Drawing.Size(435, 25);
            this.MudanzaLugarCargaTextbox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 18);
            this.label4.TabIndex = 160;
            this.label4.Text = "Descripción del lugar de carga";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MudanzaDestinoTextbox
            // 
            this.MudanzaDestinoTextbox.Location = new System.Drawing.Point(24, 308);
            this.MudanzaDestinoTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaDestinoTextbox.Name = "MudanzaDestinoTextbox";
            this.MudanzaDestinoTextbox.Size = new System.Drawing.Size(435, 25);
            this.MudanzaDestinoTextbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 158;
            this.label3.Text = "Dirección de Destino";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MudanzaOrigenTextbox
            // 
            this.MudanzaOrigenTextbox.Location = new System.Drawing.Point(24, 202);
            this.MudanzaOrigenTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaOrigenTextbox.Name = "MudanzaOrigenTextbox";
            this.MudanzaOrigenTextbox.Size = new System.Drawing.Size(435, 25);
            this.MudanzaOrigenTextbox.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 18);
            this.label9.TabIndex = 156;
            this.label9.Text = "Dirección de Origen";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MueblesDatagridview
            // 
            this.MueblesDatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MueblesDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MueblesDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion});
            this.MueblesDatagridview.Location = new System.Drawing.Point(506, 35);
            this.MueblesDatagridview.Margin = new System.Windows.Forms.Padding(2);
            this.MueblesDatagridview.MultiSelect = false;
            this.MueblesDatagridview.Name = "MueblesDatagridview";
            this.MueblesDatagridview.RowHeadersWidth = 62;
            this.MueblesDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MueblesDatagridview.Size = new System.Drawing.Size(432, 416);
            this.MueblesDatagridview.TabIndex = 7;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 87;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 152;
            this.label2.Text = "Muebles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MudanzaFechaDTP
            // 
            this.MudanzaFechaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MudanzaFechaDTP.Location = new System.Drawing.Point(24, 492);
            this.MudanzaFechaDTP.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaFechaDTP.Name = "MudanzaFechaDTP";
            this.MudanzaFechaDTP.Size = new System.Drawing.Size(125, 25);
            this.MudanzaFechaDTP.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 469);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 18);
            this.label7.TabIndex = 150;
            this.label7.Text = "Fecha mudanza";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrabarButton
            // 
            this.GrabarButton.AutoSize = true;
            this.GrabarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrabarButton.Location = new System.Drawing.Point(872, 488);
            this.GrabarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrabarButton.Name = "GrabarButton";
            this.GrabarButton.Size = new System.Drawing.Size(59, 28);
            this.GrabarButton.TabIndex = 12;
            this.GrabarButton.Text = "Grabar";
            this.GrabarButton.UseVisualStyleBackColor = true;
            this.GrabarButton.Click += new System.EventHandler(this.GrabarButton_Click);
            // 
            // MudanzaCategoriaTextbox
            // 
            this.MudanzaCategoriaTextbox.Enabled = false;
            this.MudanzaCategoriaTextbox.Location = new System.Drawing.Point(359, 492);
            this.MudanzaCategoriaTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaCategoriaTextbox.Name = "MudanzaCategoriaTextbox";
            this.MudanzaCategoriaTextbox.Size = new System.Drawing.Size(100, 25);
            this.MudanzaCategoriaTextbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 469);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 170;
            this.label1.Text = "Categoria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClienteDNI_o_CUIT_Textbox
            // 
            this.Cliente_DNI_o_CUIT_Textbox.Location = new System.Drawing.Point(119, 46);
            this.Cliente_DNI_o_CUIT_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cliente_DNI_o_CUIT_Textbox.Name = "ClienteDNI_o_CUIT_Textbox";
            this.Cliente_DNI_o_CUIT_Textbox.Size = new System.Drawing.Size(114, 25);
            this.Cliente_DNI_o_CUIT_Textbox.TabIndex = 1;
            this.Cliente_DNI_o_CUIT_Textbox.Leave += new System.EventHandler(this.Cliente_DNI_o_CUIT_Textbox_Leave);
            // 
            // ClienteNombreTextbox
            // 
            this.ClienteNombreTextbox.Enabled = false;
            this.ClienteNombreTextbox.Location = new System.Drawing.Point(119, 82);
            this.ClienteNombreTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClienteNombreTextbox.Name = "ClienteNombreTextbox";
            this.ClienteNombreTextbox.Size = new System.Drawing.Size(340, 25);
            this.ClienteNombreTextbox.TabIndex = 176;
            // 
            // ClienteDireccionTextbox
            // 
            this.ClienteDireccionTextbox.Enabled = false;
            this.ClienteDireccionTextbox.Location = new System.Drawing.Point(119, 118);
            this.ClienteDireccionTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClienteDireccionTextbox.Name = "ClienteDireccionTextbox";
            this.ClienteDireccionTextbox.Size = new System.Drawing.Size(340, 25);
            this.ClienteDireccionTextbox.TabIndex = 175;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 18);
            this.label17.TabIndex = 174;
            this.label17.Text = "Dirección";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 18);
            this.label18.TabIndex = 173;
            this.label18.Text = "Nombre";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 18);
            this.label19.TabIndex = 171;
            this.label19.Text = "DNI/CUIT";
            // 
            // ClienteIdTextbox
            // 
            this.ClienteIdTextbox.Enabled = false;
            this.ClienteIdTextbox.Location = new System.Drawing.Point(359, 47);
            this.ClienteIdTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ClienteIdTextbox.Name = "ClienteIdTextbox";
            this.ClienteIdTextbox.Size = new System.Drawing.Size(100, 25);
            this.ClienteIdTextbox.TabIndex = 178;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 177;
            this.label6.Text = "ClienteID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 179;
            this.label8.Text = "Cliente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 180;
            this.label13.Text = "Mudanza";
            // 
            // CapturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 544);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cliente_DNI_o_CUIT_Textbox);
            this.Controls.Add(this.ClienteNombreTextbox);
            this.Controls.Add(this.ClienteDireccionTextbox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ClienteIdTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MudanzaCategoriaTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrabarButton);
            this.Controls.Add(this.MudanzaMontoTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MudanzaKilometrosTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MudanzaObservacionesTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MudanzaLugarDescargaTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MudanzaLugarCargaTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MudanzaDestinoTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MudanzaOrigenTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MueblesDatagridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MudanzaFechaDTP);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CapturaForm";
            this.Text = "CapturaForm";
            this.Load += new System.EventHandler(this.CapturaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MueblesDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox MudanzaMontoTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox MudanzaKilometrosTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MudanzaObservacionesTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MudanzaLugarDescargaTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MudanzaLugarCargaTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MudanzaDestinoTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MudanzaOrigenTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView MueblesDatagridview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker MudanzaFechaDTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button GrabarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TextBox MudanzaCategoriaTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cliente_DNI_o_CUIT_Textbox;
        private System.Windows.Forms.TextBox ClienteNombreTextbox;
        private System.Windows.Forms.TextBox ClienteDireccionTextbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ClienteIdTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
    }
}