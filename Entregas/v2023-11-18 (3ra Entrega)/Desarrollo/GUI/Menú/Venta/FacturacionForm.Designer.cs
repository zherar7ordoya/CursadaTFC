namespace GUI
{
    partial class FacturacionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrdenFechaDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.OrdenIdTextbox = new System.Windows.Forms.TextBox();
            this.OrdenOrigenTextbox = new System.Windows.Forms.TextBox();
            this.OrdenMontoTextbox = new System.Windows.Forms.TextBox();
            this.OrdenDestinoTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdenDistanciaTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FacturaFechaDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.FacturaIdTextbox = new System.Windows.Forms.TextBox();
            this.FacturaDetalleTextbox = new System.Windows.Forms.TextBox();
            this.FacturaTotalTextbox = new System.Windows.Forms.TextBox();
            this.FacturaSubtotalTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FacturaImpuestoTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cliente_DNI_o_CUIT_Textbox = new System.Windows.Forms.TextBox();
            this.ClienteNombreTextbox = new System.Windows.Forms.TextBox();
            this.ClienteDireccionTextbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TransferenciaRadiobutton = new System.Windows.Forms.RadioButton();
            this.ContadoRadiobutton = new System.Windows.Forms.RadioButton();
            this.CancelarOrdenButton = new System.Windows.Forms.Button();
            this.GenerarFacturaButton = new System.Windows.Forms.Button();
            this.PagoVerificadoCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Órdenes facturables";
            // 
            // OrdenesTreeview
            // 
            this.OrdenesTreeview.Location = new System.Drawing.Point(14, 34);
            this.OrdenesTreeview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdenesTreeview.Name = "OrdenesTreeview";
            this.OrdenesTreeview.Size = new System.Drawing.Size(281, 436);
            this.OrdenesTreeview.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrdenFechaDatetimepicker);
            this.groupBox1.Controls.Add(this.OrdenIdTextbox);
            this.groupBox1.Controls.Add(this.OrdenOrigenTextbox);
            this.groupBox1.Controls.Add(this.OrdenMontoTextbox);
            this.groupBox1.Controls.Add(this.OrdenDestinoTextbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.OrdenDistanciaTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(335, 214);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(210, 258);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // OrdenFechaDatetimepicker
            // 
            this.OrdenFechaDatetimepicker.Enabled = false;
            this.OrdenFechaDatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrdenFechaDatetimepicker.Location = new System.Drawing.Point(89, 62);
            this.OrdenFechaDatetimepicker.Margin = new System.Windows.Forms.Padding(2);
            this.OrdenFechaDatetimepicker.Name = "OrdenFechaDatetimepicker";
            this.OrdenFechaDatetimepicker.Size = new System.Drawing.Size(114, 25);
            this.OrdenFechaDatetimepicker.TabIndex = 9;
            // 
            // OrdenIdTextbox
            // 
            this.OrdenIdTextbox.Location = new System.Drawing.Point(89, 28);
            this.OrdenIdTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdenIdTextbox.Name = "OrdenIdTextbox";
            this.OrdenIdTextbox.Size = new System.Drawing.Size(114, 25);
            this.OrdenIdTextbox.TabIndex = 11;
            // 
            // OrdenOrigenTextbox
            // 
            this.OrdenOrigenTextbox.Location = new System.Drawing.Point(89, 100);
            this.OrdenOrigenTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdenOrigenTextbox.Name = "OrdenOrigenTextbox";
            this.OrdenOrigenTextbox.Size = new System.Drawing.Size(114, 25);
            this.OrdenOrigenTextbox.TabIndex = 9;
            // 
            // OrdenMontoTextbox
            // 
            this.OrdenMontoTextbox.Location = new System.Drawing.Point(89, 208);
            this.OrdenMontoTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdenMontoTextbox.Name = "OrdenMontoTextbox";
            this.OrdenMontoTextbox.Size = new System.Drawing.Size(114, 25);
            this.OrdenMontoTextbox.TabIndex = 8;
            // 
            // OrdenDestinoTextbox
            // 
            this.OrdenDestinoTextbox.Location = new System.Drawing.Point(89, 136);
            this.OrdenDestinoTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdenDestinoTextbox.Name = "OrdenDestinoTextbox";
            this.OrdenDestinoTextbox.Size = new System.Drawing.Size(114, 25);
            this.OrdenDestinoTextbox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Distancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // OrdenDistanciaTextbox
            // 
            this.OrdenDistanciaTextbox.Location = new System.Drawing.Point(89, 172);
            this.OrdenDistanciaTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrdenDistanciaTextbox.Name = "OrdenDistanciaTextbox";
            this.OrdenDistanciaTextbox.Size = new System.Drawing.Size(114, 25);
            this.OrdenDistanciaTextbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FacturaFechaDatetimepicker);
            this.groupBox2.Controls.Add(this.FacturaIdTextbox);
            this.groupBox2.Controls.Add(this.FacturaDetalleTextbox);
            this.groupBox2.Controls.Add(this.FacturaTotalTextbox);
            this.groupBox2.Controls.Add(this.FacturaSubtotalTextbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.FacturaImpuestoTextbox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(577, 214);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(210, 258);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Factura";
            // 
            // FacturaFechaDatetimepicker
            // 
            this.FacturaFechaDatetimepicker.Enabled = false;
            this.FacturaFechaDatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FacturaFechaDatetimepicker.Location = new System.Drawing.Point(89, 62);
            this.FacturaFechaDatetimepicker.Margin = new System.Windows.Forms.Padding(2);
            this.FacturaFechaDatetimepicker.Name = "FacturaFechaDatetimepicker";
            this.FacturaFechaDatetimepicker.Size = new System.Drawing.Size(114, 25);
            this.FacturaFechaDatetimepicker.TabIndex = 8;
            // 
            // FacturaIdTextbox
            // 
            this.FacturaIdTextbox.Location = new System.Drawing.Point(89, 28);
            this.FacturaIdTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FacturaIdTextbox.Name = "FacturaIdTextbox";
            this.FacturaIdTextbox.Size = new System.Drawing.Size(114, 25);
            this.FacturaIdTextbox.TabIndex = 11;
            // 
            // FacturaDetalleTextbox
            // 
            this.FacturaDetalleTextbox.Location = new System.Drawing.Point(89, 100);
            this.FacturaDetalleTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FacturaDetalleTextbox.Name = "FacturaDetalleTextbox";
            this.FacturaDetalleTextbox.Size = new System.Drawing.Size(114, 25);
            this.FacturaDetalleTextbox.TabIndex = 9;
            // 
            // FacturaTotalTextbox
            // 
            this.FacturaTotalTextbox.Location = new System.Drawing.Point(89, 208);
            this.FacturaTotalTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FacturaTotalTextbox.Name = "FacturaTotalTextbox";
            this.FacturaTotalTextbox.Size = new System.Drawing.Size(114, 25);
            this.FacturaTotalTextbox.TabIndex = 8;
            // 
            // FacturaSubtotalTextbox
            // 
            this.FacturaSubtotalTextbox.Location = new System.Drawing.Point(89, 136);
            this.FacturaSubtotalTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FacturaSubtotalTextbox.Name = "FacturaSubtotalTextbox";
            this.FacturaSubtotalTextbox.Size = new System.Drawing.Size(114, 25);
            this.FacturaSubtotalTextbox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 5;
            this.label9.Text = "Impuesto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Subtotal";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 18);
            this.label11.TabIndex = 3;
            this.label11.Text = "Detalle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Fecha";
            // 
            // FacturaImpuestoTextbox
            // 
            this.FacturaImpuestoTextbox.Location = new System.Drawing.Point(89, 172);
            this.FacturaImpuestoTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FacturaImpuestoTextbox.Name = "FacturaImpuestoTextbox";
            this.FacturaImpuestoTextbox.Size = new System.Drawing.Size(114, 25);
            this.FacturaImpuestoTextbox.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "Id";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cliente_DNI_o_CUIT_Textbox);
            this.groupBox3.Controls.Add(this.ClienteNombreTextbox);
            this.groupBox3.Controls.Add(this.ClienteDireccionTextbox);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(335, 34);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(453, 152);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente";
            // 
            // Cliente_DNI_o_CUIT_Textbox
            // 
            this.Cliente_DNI_o_CUIT_Textbox.Location = new System.Drawing.Point(331, 28);
            this.Cliente_DNI_o_CUIT_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cliente_DNI_o_CUIT_Textbox.Name = "Cliente_DNI_o_CUIT_Textbox";
            this.Cliente_DNI_o_CUIT_Textbox.Size = new System.Drawing.Size(114, 25);
            this.Cliente_DNI_o_CUIT_Textbox.TabIndex = 11;
            // 
            // ClienteNombreTextbox
            // 
            this.ClienteNombreTextbox.Location = new System.Drawing.Point(89, 64);
            this.ClienteNombreTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClienteNombreTextbox.Name = "ClienteNombreTextbox";
            this.ClienteNombreTextbox.Size = new System.Drawing.Size(356, 25);
            this.ClienteNombreTextbox.TabIndex = 10;
            // 
            // ClienteDireccionTextbox
            // 
            this.ClienteDireccionTextbox.Location = new System.Drawing.Point(89, 100);
            this.ClienteDireccionTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClienteDireccionTextbox.Name = "ClienteDireccionTextbox";
            this.ClienteDireccionTextbox.Size = new System.Drawing.Size(356, 25);
            this.ClienteDireccionTextbox.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "Dirección";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 18);
            this.label18.TabIndex = 2;
            this.label18.Text = "Nombre";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 32);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 18);
            this.label19.TabIndex = 0;
            this.label19.Text = "DNI/CUIT";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TransferenciaRadiobutton);
            this.groupBox4.Controls.Add(this.ContadoRadiobutton);
            this.groupBox4.Location = new System.Drawing.Point(794, 218);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(135, 118);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pago";
            // 
            // TransferenciaRadiobutton
            // 
            this.TransferenciaRadiobutton.AutoSize = true;
            this.TransferenciaRadiobutton.Location = new System.Drawing.Point(8, 74);
            this.TransferenciaRadiobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TransferenciaRadiobutton.Name = "TransferenciaRadiobutton";
            this.TransferenciaRadiobutton.Size = new System.Drawing.Size(109, 22);
            this.TransferenciaRadiobutton.TabIndex = 1;
            this.TransferenciaRadiobutton.TabStop = true;
            this.TransferenciaRadiobutton.Text = "Transferencia";
            this.TransferenciaRadiobutton.UseVisualStyleBackColor = true;
            // 
            // ContadoRadiobutton
            // 
            this.ContadoRadiobutton.AutoSize = true;
            this.ContadoRadiobutton.Location = new System.Drawing.Point(7, 40);
            this.ContadoRadiobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContadoRadiobutton.Name = "ContadoRadiobutton";
            this.ContadoRadiobutton.Size = new System.Drawing.Size(78, 22);
            this.ContadoRadiobutton.TabIndex = 0;
            this.ContadoRadiobutton.TabStop = true;
            this.ContadoRadiobutton.Text = "Contado";
            this.ContadoRadiobutton.UseVisualStyleBackColor = true;
            // 
            // CancelarOrdenButton
            // 
            this.CancelarOrdenButton.AutoSize = true;
            this.CancelarOrdenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarOrdenButton.Location = new System.Drawing.Point(809, 388);
            this.CancelarOrdenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelarOrdenButton.Name = "CancelarOrdenButton";
            this.CancelarOrdenButton.Size = new System.Drawing.Size(113, 28);
            this.CancelarOrdenButton.TabIndex = 6;
            this.CancelarOrdenButton.Text = "Cancelar Orden";
            this.CancelarOrdenButton.UseVisualStyleBackColor = true;
            this.CancelarOrdenButton.Click += new System.EventHandler(this.CancelarOrdenButton_Click);
            // 
            // GenerarFacturaButton
            // 
            this.GenerarFacturaButton.AutoSize = true;
            this.GenerarFacturaButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerarFacturaButton.Enabled = false;
            this.GenerarFacturaButton.Location = new System.Drawing.Point(802, 440);
            this.GenerarFacturaButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GenerarFacturaButton.Name = "GenerarFacturaButton";
            this.GenerarFacturaButton.Size = new System.Drawing.Size(116, 28);
            this.GenerarFacturaButton.TabIndex = 7;
            this.GenerarFacturaButton.Text = "Generar Factura";
            this.GenerarFacturaButton.UseVisualStyleBackColor = true;
            this.GenerarFacturaButton.Click += new System.EventHandler(this.GenerarFacturaButton_Click);
            // 
            // PagoVerificadoCheckbox
            // 
            this.PagoVerificadoCheckbox.AutoSize = true;
            this.PagoVerificadoCheckbox.Location = new System.Drawing.Point(802, 348);
            this.PagoVerificadoCheckbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PagoVerificadoCheckbox.Name = "PagoVerificadoCheckbox";
            this.PagoVerificadoCheckbox.Size = new System.Drawing.Size(121, 22);
            this.PagoVerificadoCheckbox.TabIndex = 3;
            this.PagoVerificadoCheckbox.Text = "Pago verificado";
            this.PagoVerificadoCheckbox.UseVisualStyleBackColor = true;
            this.PagoVerificadoCheckbox.CheckedChanged += new System.EventHandler(this.PagoVerificadoCheckbox_CheckedChanged);
            // 
            // FacturacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 492);
            this.Controls.Add(this.PagoVerificadoCheckbox);
            this.Controls.Add(this.GenerarFacturaButton);
            this.Controls.Add(this.CancelarOrdenButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OrdenesTreeview);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FacturacionForm";
            this.Text = "FacturacionForm";
            this.Load += new System.EventHandler(this.FacturacionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView OrdenesTreeview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OrdenDistanciaTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrdenIdTextbox;
        private System.Windows.Forms.TextBox OrdenOrigenTextbox;
        private System.Windows.Forms.TextBox OrdenMontoTextbox;
        private System.Windows.Forms.TextBox OrdenDestinoTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FacturaIdTextbox;
        private System.Windows.Forms.TextBox FacturaDetalleTextbox;
        private System.Windows.Forms.TextBox FacturaTotalTextbox;
        private System.Windows.Forms.TextBox FacturaSubtotalTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FacturaImpuestoTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Cliente_DNI_o_CUIT_Textbox;
        private System.Windows.Forms.TextBox ClienteNombreTextbox;
        private System.Windows.Forms.TextBox ClienteDireccionTextbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton TransferenciaRadiobutton;
        private System.Windows.Forms.RadioButton ContadoRadiobutton;
        private System.Windows.Forms.Button CancelarOrdenButton;
        private System.Windows.Forms.Button GenerarFacturaButton;
        private System.Windows.Forms.CheckBox PagoVerificadoCheckbox;
        private System.Windows.Forms.DateTimePicker FacturaFechaDatetimepicker;
        private System.Windows.Forms.DateTimePicker OrdenFechaDatetimepicker;
    }
}