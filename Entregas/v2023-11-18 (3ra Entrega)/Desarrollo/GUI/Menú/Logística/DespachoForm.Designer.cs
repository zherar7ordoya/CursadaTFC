namespace GUI
{
    partial class DespachoForm
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
            this.OrdenesTreeview = new System.Windows.Forms.TreeView();
            this.OrdenDistanciaTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.OrdenObservacionesTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.OrdenLugarDescargaTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.OrdenLugarCargaTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OrdenDestinoTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdenOrigenTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MueblesDGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.OrdenFechaDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.OrdenIdTextbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.InsumosDGV = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label18 = new System.Windows.Forms.Label();
            this.EstibadoresDGV = new System.Windows.Forms.DataGridView();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NombreApellidoTextbox = new System.Windows.Forms.TextBox();
            this.DNITextbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MarcaTextbox = new System.Windows.Forms.TextBox();
            this.PatenteTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelarOrdenButton = new System.Windows.Forms.Button();
            this.GenerarNotaMudanzaButton = new System.Windows.Forms.Button();
            this.MudanzaFechaDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.MudanzaIdTextbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MueblesDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstibadoresDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Órdenes pendientes de servicio";
            // 
            // OrdenesTreeview
            // 
            this.OrdenesTreeview.Location = new System.Drawing.Point(12, 29);
            this.OrdenesTreeview.Name = "OrdenesTreeview";
            this.OrdenesTreeview.Size = new System.Drawing.Size(179, 164);
            this.OrdenesTreeview.TabIndex = 1;
            // 
            // OrdenDistanciaTextbox
            // 
            this.OrdenDistanciaTextbox.Location = new System.Drawing.Point(385, 198);
            this.OrdenDistanciaTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenDistanciaTextbox.Name = "OrdenDistanciaTextbox";
            this.OrdenDistanciaTextbox.Size = new System.Drawing.Size(89, 24);
            this.OrdenDistanciaTextbox.TabIndex = 167;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(234, 200);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 166;
            this.label11.Text = "Distancia (en kilómetros)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenObservacionesTextbox
            // 
            this.OrdenObservacionesTextbox.Location = new System.Drawing.Point(294, 170);
            this.OrdenObservacionesTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenObservacionesTextbox.Name = "OrdenObservacionesTextbox";
            this.OrdenObservacionesTextbox.Size = new System.Drawing.Size(179, 24);
            this.OrdenObservacionesTextbox.TabIndex = 165;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 164;
            this.label10.Text = "Observaciones";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenLugarDescargaTextbox
            // 
            this.OrdenLugarDescargaTextbox.Location = new System.Drawing.Point(293, 142);
            this.OrdenLugarDescargaTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenLugarDescargaTextbox.Name = "OrdenLugarDescargaTextbox";
            this.OrdenLugarDescargaTextbox.Size = new System.Drawing.Size(180, 24);
            this.OrdenLugarDescargaTextbox.TabIndex = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 162;
            this.label5.Text = "Lugar descarga";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenLugarCargaTextbox
            // 
            this.OrdenLugarCargaTextbox.Location = new System.Drawing.Point(294, 86);
            this.OrdenLugarCargaTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenLugarCargaTextbox.Name = "OrdenLugarCargaTextbox";
            this.OrdenLugarCargaTextbox.Size = new System.Drawing.Size(180, 24);
            this.OrdenLugarCargaTextbox.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 160;
            this.label4.Text = "Lugar carga";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenDestinoTextbox
            // 
            this.OrdenDestinoTextbox.Location = new System.Drawing.Point(293, 114);
            this.OrdenDestinoTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenDestinoTextbox.Name = "OrdenDestinoTextbox";
            this.OrdenDestinoTextbox.Size = new System.Drawing.Size(180, 24);
            this.OrdenDestinoTextbox.TabIndex = 159;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 158;
            this.label3.Text = "Destino";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenOrigenTextbox
            // 
            this.OrdenOrigenTextbox.Location = new System.Drawing.Point(294, 58);
            this.OrdenOrigenTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenOrigenTextbox.Name = "OrdenOrigenTextbox";
            this.OrdenOrigenTextbox.Size = new System.Drawing.Size(180, 24);
            this.OrdenOrigenTextbox.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 156;
            this.label9.Text = "Origen";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MueblesDGV
            // 
            this.MueblesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.MueblesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MueblesDGV.Location = new System.Drawing.Point(12, 225);
            this.MueblesDGV.Margin = new System.Windows.Forms.Padding(2);
            this.MueblesDGV.MultiSelect = false;
            this.MueblesDGV.Name = "MueblesDGV";
            this.MueblesDGV.RowHeadersWidth = 62;
            this.MueblesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MueblesDGV.Size = new System.Drawing.Size(462, 231);
            this.MueblesDGV.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 152;
            this.label6.Text = "Muebles";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenFechaDatetimepicker
            // 
            this.OrdenFechaDatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrdenFechaDatetimepicker.Location = new System.Drawing.Point(385, 30);
            this.OrdenFechaDatetimepicker.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenFechaDatetimepicker.Name = "OrdenFechaDatetimepicker";
            this.OrdenFechaDatetimepicker.Size = new System.Drawing.Size(88, 24);
            this.OrdenFechaDatetimepicker.TabIndex = 151;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 150;
            this.label7.Text = "Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenIdTextbox
            // 
            this.OrdenIdTextbox.Enabled = false;
            this.OrdenIdTextbox.Location = new System.Drawing.Point(201, 30);
            this.OrdenIdTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenIdTextbox.Name = "OrdenIdTextbox";
            this.OrdenIdTextbox.Size = new System.Drawing.Size(88, 24);
            this.OrdenIdTextbox.TabIndex = 147;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(198, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 17);
            this.label14.TabIndex = 146;
            this.label14.Text = "Id";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.InsumosDGV);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.EstibadoresDGV);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.NombreApellidoTextbox);
            this.groupBox1.Controls.Add(this.DNITextbox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.MarcaTextbox);
            this.groupBox1.Controls.Add(this.PatenteTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(499, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 444);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asignaciones";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 301);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 17);
            this.label19.TabIndex = 13;
            this.label19.Text = "Insumos";
            // 
            // InsumosDGV
            // 
            this.InsumosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.InsumosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InsumosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Descripcion});
            this.InsumosDGV.Location = new System.Drawing.Point(90, 301);
            this.InsumosDGV.Name = "InsumosDGV";
            this.InsumosDGV.RowHeadersWidth = 62;
            this.InsumosDGV.Size = new System.Drawing.Size(366, 137);
            this.InsumosDGV.TabIndex = 12;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 83;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 98;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 17);
            this.label18.TabIndex = 11;
            this.label18.Text = "Estibadores";
            // 
            // EstibadoresDGV
            // 
            this.EstibadoresDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EstibadoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstibadoresDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NombreApellido});
            this.EstibadoresDGV.Location = new System.Drawing.Point(90, 158);
            this.EstibadoresDGV.Name = "EstibadoresDGV";
            this.EstibadoresDGV.RowHeadersWidth = 62;
            this.EstibadoresDGV.Size = new System.Drawing.Size(366, 137);
            this.EstibadoresDGV.TabIndex = 10;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.Width = 55;
            // 
            // NombreApellido
            // 
            this.NombreApellido.HeaderText = "Nombre";
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.Width = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(87, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 17);
            this.label15.TabIndex = 9;
            this.label15.Text = "DNI";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(193, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Nombre y Apellido";
            // 
            // NombreApellidoTextbox
            // 
            this.NombreApellidoTextbox.Location = new System.Drawing.Point(196, 102);
            this.NombreApellidoTextbox.Name = "NombreApellidoTextbox";
            this.NombreApellidoTextbox.Size = new System.Drawing.Size(260, 24);
            this.NombreApellidoTextbox.TabIndex = 7;
            // 
            // DNITextbox
            // 
            this.DNITextbox.Location = new System.Drawing.Point(90, 102);
            this.DNITextbox.Name = "DNITextbox";
            this.DNITextbox.Size = new System.Drawing.Size(100, 24);
            this.DNITextbox.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 17);
            this.label17.TabIndex = 5;
            this.label17.Text = "Chofer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Patente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(193, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 3;
            this.label12.Text = "Marca";
            // 
            // MarcaTextbox
            // 
            this.MarcaTextbox.Location = new System.Drawing.Point(196, 46);
            this.MarcaTextbox.Name = "MarcaTextbox";
            this.MarcaTextbox.Size = new System.Drawing.Size(260, 24);
            this.MarcaTextbox.TabIndex = 2;
            // 
            // PatenteTextbox
            // 
            this.PatenteTextbox.Location = new System.Drawing.Point(90, 46);
            this.PatenteTextbox.Name = "PatenteTextbox";
            this.PatenteTextbox.Size = new System.Drawing.Size(100, 24);
            this.PatenteTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Camión";
            // 
            // CancelarOrdenButton
            // 
            this.CancelarOrdenButton.AutoSize = true;
            this.CancelarOrdenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarOrdenButton.Location = new System.Drawing.Point(681, 467);
            this.CancelarOrdenButton.Name = "CancelarOrdenButton";
            this.CancelarOrdenButton.Size = new System.Drawing.Size(105, 27);
            this.CancelarOrdenButton.TabIndex = 169;
            this.CancelarOrdenButton.Text = "Cancelar Orden";
            this.CancelarOrdenButton.UseVisualStyleBackColor = true;
            this.CancelarOrdenButton.Click += new System.EventHandler(this.CancelarOrdenButton_Click);
            // 
            // GenerarNotaMudanzaButton
            // 
            this.GenerarNotaMudanzaButton.AutoSize = true;
            this.GenerarNotaMudanzaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerarNotaMudanzaButton.Location = new System.Drawing.Point(792, 467);
            this.GenerarNotaMudanzaButton.Name = "GenerarNotaMudanzaButton";
            this.GenerarNotaMudanzaButton.Size = new System.Drawing.Size(169, 27);
            this.GenerarNotaMudanzaButton.TabIndex = 170;
            this.GenerarNotaMudanzaButton.Text = "Generar Nota de Mudanza";
            this.GenerarNotaMudanzaButton.UseVisualStyleBackColor = true;
            this.GenerarNotaMudanzaButton.Click += new System.EventHandler(this.GenerarNotaMudanzaButton_Click);
            // 
            // MudanzaFechaDatetimepicker
            // 
            this.MudanzaFechaDatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.MudanzaFechaDatetimepicker.Location = new System.Drawing.Point(143, 469);
            this.MudanzaFechaDatetimepicker.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaFechaDatetimepicker.Name = "MudanzaFechaDatetimepicker";
            this.MudanzaFechaDatetimepicker.Size = new System.Drawing.Size(88, 24);
            this.MudanzaFechaDatetimepicker.TabIndex = 172;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 472);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 17);
            this.label20.TabIndex = 171;
            this.label20.Text = "Fecha Nota Mudanza";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MudanzaIdTextbox
            // 
            this.MudanzaIdTextbox.Enabled = false;
            this.MudanzaIdTextbox.Location = new System.Drawing.Point(476, 469);
            this.MudanzaIdTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.MudanzaIdTextbox.Name = "MudanzaIdTextbox";
            this.MudanzaIdTextbox.Size = new System.Drawing.Size(88, 24);
            this.MudanzaIdTextbox.TabIndex = 174;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(366, 472);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 17);
            this.label21.TabIndex = 173;
            this.label21.Text = "Id Nota Mudanza";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DespachoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 516);
            this.Controls.Add(this.MudanzaIdTextbox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.MudanzaFechaDatetimepicker);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.GenerarNotaMudanzaButton);
            this.Controls.Add(this.CancelarOrdenButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrdenDistanciaTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.OrdenObservacionesTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OrdenLugarDescargaTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrdenLugarCargaTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrdenDestinoTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrdenOrigenTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MueblesDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrdenFechaDatetimepicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OrdenIdTextbox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.OrdenesTreeview);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DespachoForm";
            this.Text = "DespachoForm";
            this.Load += new System.EventHandler(this.DespachoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MueblesDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstibadoresDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView OrdenesTreeview;
        private System.Windows.Forms.TextBox OrdenDistanciaTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OrdenObservacionesTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox OrdenLugarDescargaTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OrdenLugarCargaTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrdenDestinoTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrdenOrigenTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView MueblesDGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker OrdenFechaDatetimepicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OrdenIdTextbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MarcaTextbox;
        private System.Windows.Forms.TextBox PatenteTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView EstibadoresDGV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox NombreApellidoTextbox;
        private System.Windows.Forms.TextBox DNITextbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView InsumosDGV;
        private System.Windows.Forms.Button CancelarOrdenButton;
        private System.Windows.Forms.Button GenerarNotaMudanzaButton;
        private System.Windows.Forms.DateTimePicker MudanzaFechaDatetimepicker;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox MudanzaIdTextbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
    }
}