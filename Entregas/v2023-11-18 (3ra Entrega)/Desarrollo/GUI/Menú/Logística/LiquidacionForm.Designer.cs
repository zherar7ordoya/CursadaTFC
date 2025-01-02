namespace GUI
{
    partial class LiquidacionForm
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
            this.OrdenDestinoTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdenOrigenTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OrdenFechaDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.LiquidacionIdTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ComprobantesDGV = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.LiquidacionReembolsoTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LiquidacionComisionTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LiquidacionTotalTextbox = new System.Windows.Forms.TextBox();
            this.LiquidacionMontoTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CompletadoCheckbox = new System.Windows.Forms.CheckBox();
            this.CancelarOrdenButton = new System.Windows.Forms.Button();
            this.GenerarNotaLiquidacionButton = new System.Windows.Forms.Button();
            this.LiquidacionFechaDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.OrdenIdTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OrdenMontoTextbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CalcularLiquidacionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ComprobantesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Órdenes en tránsito";
            // 
            // OrdenesTreeview
            // 
            this.OrdenesTreeview.Location = new System.Drawing.Point(14, 27);
            this.OrdenesTreeview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrdenesTreeview.Name = "OrdenesTreeview";
            this.OrdenesTreeview.Size = new System.Drawing.Size(116, 309);
            this.OrdenesTreeview.TabIndex = 1;
            // 
            // OrdenDistanciaTextbox
            // 
            this.OrdenDistanciaTextbox.Location = new System.Drawing.Point(153, 210);
            this.OrdenDistanciaTextbox.Name = "OrdenDistanciaTextbox";
            this.OrdenDistanciaTextbox.Size = new System.Drawing.Size(88, 24);
            this.OrdenDistanciaTextbox.TabIndex = 171;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(150, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 170;
            this.label11.Text = "Distancia";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenDestinoTextbox
            // 
            this.OrdenDestinoTextbox.Location = new System.Drawing.Point(153, 149);
            this.OrdenDestinoTextbox.Name = "OrdenDestinoTextbox";
            this.OrdenDestinoTextbox.Size = new System.Drawing.Size(278, 24);
            this.OrdenDestinoTextbox.TabIndex = 163;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 162;
            this.label3.Text = "Dirección de destino";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenOrigenTextbox
            // 
            this.OrdenOrigenTextbox.Location = new System.Drawing.Point(153, 92);
            this.OrdenOrigenTextbox.Name = "OrdenOrigenTextbox";
            this.OrdenOrigenTextbox.Size = new System.Drawing.Size(278, 24);
            this.OrdenOrigenTextbox.TabIndex = 161;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 17);
            this.label9.TabIndex = 160;
            this.label9.Text = "Dirección de origen";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenFechaDatetimepicker
            // 
            this.OrdenFechaDatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.OrdenFechaDatetimepicker.Location = new System.Drawing.Point(343, 27);
            this.OrdenFechaDatetimepicker.Name = "OrdenFechaDatetimepicker";
            this.OrdenFechaDatetimepicker.Size = new System.Drawing.Size(88, 24);
            this.OrdenFechaDatetimepicker.TabIndex = 155;
            // 
            // LiquidacionIdTextbox
            // 
            this.LiquidacionIdTextbox.Enabled = false;
            this.LiquidacionIdTextbox.Location = new System.Drawing.Point(681, 304);
            this.LiquidacionIdTextbox.Name = "LiquidacionIdTextbox";
            this.LiquidacionIdTextbox.Size = new System.Drawing.Size(88, 24);
            this.LiquidacionIdTextbox.TabIndex = 148;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(619, 284);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 17);
            this.label13.TabIndex = 147;
            this.label13.Text = "Id de Nota de Liquidación";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComprobantesDGV
            // 
            this.ComprobantesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ComprobantesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComprobantesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Detalle,
            this.Monto});
            this.ComprobantesDGV.Location = new System.Drawing.Point(479, 28);
            this.ComprobantesDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComprobantesDGV.MultiSelect = false;
            this.ComprobantesDGV.Name = "ComprobantesDGV";
            this.ComprobantesDGV.RowHeadersWidth = 62;
            this.ComprobantesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ComprobantesDGV.Size = new System.Drawing.Size(290, 118);
            this.ComprobantesDGV.TabIndex = 188;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 66;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.MinimumWidth = 8;
            this.Detalle.Name = "Detalle";
            this.Detalle.Width = 74;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 8;
            this.Monto.Name = "Monto";
            this.Monto.Width = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 187;
            this.label4.Text = "Comprobantes";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LiquidacionReembolsoTextbox
            // 
            this.LiquidacionReembolsoTextbox.Location = new System.Drawing.Point(658, 155);
            this.LiquidacionReembolsoTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LiquidacionReembolsoTextbox.Name = "LiquidacionReembolsoTextbox";
            this.LiquidacionReembolsoTextbox.Size = new System.Drawing.Size(111, 24);
            this.LiquidacionReembolsoTextbox.TabIndex = 185;
            this.LiquidacionReembolsoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(618, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 184;
            this.label8.Text = "Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LiquidacionComisionTextbox
            // 
            this.LiquidacionComisionTextbox.Location = new System.Drawing.Point(658, 210);
            this.LiquidacionComisionTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LiquidacionComisionTextbox.Name = "LiquidacionComisionTextbox";
            this.LiquidacionComisionTextbox.Size = new System.Drawing.Size(111, 24);
            this.LiquidacionComisionTextbox.TabIndex = 182;
            this.LiquidacionComisionTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 212);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 181;
            this.label6.Text = "Monto de la comisión";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LiquidacionTotalTextbox
            // 
            this.LiquidacionTotalTextbox.Location = new System.Drawing.Point(658, 238);
            this.LiquidacionTotalTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LiquidacionTotalTextbox.Name = "LiquidacionTotalTextbox";
            this.LiquidacionTotalTextbox.Size = new System.Drawing.Size(111, 24);
            this.LiquidacionTotalTextbox.TabIndex = 180;
            this.LiquidacionTotalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LiquidacionMontoTextbox
            // 
            this.LiquidacionMontoTextbox.Location = new System.Drawing.Point(658, 182);
            this.LiquidacionMontoTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LiquidacionMontoTextbox.Name = "LiquidacionMontoTextbox";
            this.LiquidacionMontoTextbox.Size = new System.Drawing.Size(111, 24);
            this.LiquidacionMontoTextbox.TabIndex = 179;
            this.LiquidacionMontoTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 178;
            this.label5.Text = "Monto de la orden";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(519, 157);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 177;
            this.label10.Text = "Monto del reembolso";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CompletadoCheckbox
            // 
            this.CompletadoCheckbox.AutoSize = true;
            this.CompletadoCheckbox.Location = new System.Drawing.Point(286, 283);
            this.CompletadoCheckbox.Name = "CompletadoCheckbox";
            this.CompletadoCheckbox.Size = new System.Drawing.Size(140, 21);
            this.CompletadoCheckbox.TabIndex = 189;
            this.CompletadoCheckbox.Text = "Servicio completado";
            this.CompletadoCheckbox.UseVisualStyleBackColor = true;
            // 
            // CancelarOrdenButton
            // 
            this.CancelarOrdenButton.AutoSize = true;
            this.CancelarOrdenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelarOrdenButton.Location = new System.Drawing.Point(475, 352);
            this.CancelarOrdenButton.Name = "CancelarOrdenButton";
            this.CancelarOrdenButton.Size = new System.Drawing.Size(105, 27);
            this.CancelarOrdenButton.TabIndex = 190;
            this.CancelarOrdenButton.Text = "Cancelar Orden";
            this.CancelarOrdenButton.UseVisualStyleBackColor = true;
            this.CancelarOrdenButton.Click += new System.EventHandler(this.CancelarOrdenButton_Click);
            // 
            // GenerarNotaLiquidacionButton
            // 
            this.GenerarNotaLiquidacionButton.AutoSize = true;
            this.GenerarNotaLiquidacionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerarNotaLiquidacionButton.Location = new System.Drawing.Point(590, 352);
            this.GenerarNotaLiquidacionButton.Name = "GenerarNotaLiquidacionButton";
            this.GenerarNotaLiquidacionButton.Size = new System.Drawing.Size(179, 27);
            this.GenerarNotaLiquidacionButton.TabIndex = 191;
            this.GenerarNotaLiquidacionButton.Text = "Generar Nota de Liquidación";
            this.GenerarNotaLiquidacionButton.UseVisualStyleBackColor = true;
            this.GenerarNotaLiquidacionButton.Click += new System.EventHandler(this.GenerarNotaLiquidacionButton_Click);
            // 
            // LiquidacionFechaDatetimepicker
            // 
            this.LiquidacionFechaDatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.LiquidacionFechaDatetimepicker.Location = new System.Drawing.Point(520, 304);
            this.LiquidacionFechaDatetimepicker.Name = "LiquidacionFechaDatetimepicker";
            this.LiquidacionFechaDatetimepicker.Size = new System.Drawing.Size(88, 24);
            this.LiquidacionFechaDatetimepicker.TabIndex = 192;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 193;
            this.label2.Text = "Fecha de Liquidación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrdenIdTextbox
            // 
            this.OrdenIdTextbox.Enabled = false;
            this.OrdenIdTextbox.Location = new System.Drawing.Point(153, 27);
            this.OrdenIdTextbox.Name = "OrdenIdTextbox";
            this.OrdenIdTextbox.Size = new System.Drawing.Size(88, 24);
            this.OrdenIdTextbox.TabIndex = 195;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 194;
            this.label12.Text = "Id Orden";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(340, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 17);
            this.label14.TabIndex = 196;
            this.label14.Text = "Fecha de Servicio";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdenMontoTextbox
            // 
            this.OrdenMontoTextbox.Location = new System.Drawing.Point(343, 210);
            this.OrdenMontoTextbox.Name = "OrdenMontoTextbox";
            this.OrdenMontoTextbox.Size = new System.Drawing.Size(88, 24);
            this.OrdenMontoTextbox.TabIndex = 198;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(340, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 17);
            this.label15.TabIndex = 197;
            this.label15.Text = "Monto";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalcularLiquidacionButton
            // 
            this.CalcularLiquidacionButton.AutoSize = true;
            this.CalcularLiquidacionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalcularLiquidacionButton.Location = new System.Drawing.Point(479, 237);
            this.CalcularLiquidacionButton.Name = "CalcularLiquidacionButton";
            this.CalcularLiquidacionButton.Size = new System.Drawing.Size(129, 27);
            this.CalcularLiquidacionButton.TabIndex = 199;
            this.CalcularLiquidacionButton.Text = "Calcular Liquidación";
            this.CalcularLiquidacionButton.UseVisualStyleBackColor = true;
            this.CalcularLiquidacionButton.Click += new System.EventHandler(this.CalcularLiquidacionButton_Click);
            // 
            // LiquidacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 391);
            this.Controls.Add(this.CalcularLiquidacionButton);
            this.Controls.Add(this.OrdenMontoTextbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.OrdenIdTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LiquidacionFechaDatetimepicker);
            this.Controls.Add(this.GenerarNotaLiquidacionButton);
            this.Controls.Add(this.CancelarOrdenButton);
            this.Controls.Add(this.CompletadoCheckbox);
            this.Controls.Add(this.ComprobantesDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LiquidacionReembolsoTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LiquidacionComisionTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LiquidacionTotalTextbox);
            this.Controls.Add(this.LiquidacionMontoTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OrdenesTreeview);
            this.Controls.Add(this.OrdenDistanciaTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.OrdenDestinoTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrdenOrigenTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.OrdenFechaDatetimepicker);
            this.Controls.Add(this.LiquidacionIdTextbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LiquidacionForm";
            this.Text = "LiquidacionForm";
            this.Load += new System.EventHandler(this.LiquidacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprobantesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView OrdenesTreeview;
        private System.Windows.Forms.TextBox OrdenDistanciaTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox OrdenDestinoTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrdenOrigenTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker OrdenFechaDatetimepicker;
        private System.Windows.Forms.TextBox LiquidacionIdTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView ComprobantesDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LiquidacionReembolsoTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LiquidacionComisionTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LiquidacionTotalTextbox;
        private System.Windows.Forms.TextBox LiquidacionMontoTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CompletadoCheckbox;
        private System.Windows.Forms.Button CancelarOrdenButton;
        private System.Windows.Forms.Button GenerarNotaLiquidacionButton;
        private System.Windows.Forms.DateTimePicker LiquidacionFechaDatetimepicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrdenIdTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox OrdenMontoTextbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button CalcularLiquidacionButton;
    }
}