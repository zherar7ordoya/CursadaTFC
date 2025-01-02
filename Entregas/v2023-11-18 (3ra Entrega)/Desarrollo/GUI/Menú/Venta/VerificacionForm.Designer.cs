namespace GUI
{
    partial class VerificacionForm
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
            this.MontoTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FechaDatetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.VerificarButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.VerificacionTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MontoTextbox
            // 
            this.MontoTextbox.Location = new System.Drawing.Point(290, 46);
            this.MontoTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MontoTextbox.Name = "MontoTextbox";
            this.MontoTextbox.Size = new System.Drawing.Size(124, 32);
            this.MontoTextbox.TabIndex = 168;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 167;
            this.label9.Text = "Monto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FechaDatetimepicker
            // 
            this.FechaDatetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDatetimepicker.Location = new System.Drawing.Point(156, 46);
            this.FechaDatetimepicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaDatetimepicker.Name = "FechaDatetimepicker";
            this.FechaDatetimepicker.Size = new System.Drawing.Size(124, 32);
            this.FechaDatetimepicker.TabIndex = 166;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 165;
            this.label7.Text = "Fecha";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(21, 46);
            this.IdTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.Size = new System.Drawing.Size(124, 32);
            this.IdTextbox.TabIndex = 164;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 24);
            this.label13.TabIndex = 163;
            this.label13.Text = "Id";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VerificarButton
            // 
            this.VerificarButton.AutoSize = true;
            this.VerificarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VerificarButton.Location = new System.Drawing.Point(21, 94);
            this.VerificarButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VerificarButton.Name = "VerificarButton";
            this.VerificarButton.Size = new System.Drawing.Size(88, 34);
            this.VerificarButton.TabIndex = 169;
            this.VerificarButton.Text = "Verificar";
            this.VerificarButton.UseVisualStyleBackColor = true;
            this.VerificarButton.Click += new System.EventHandler(this.VerificarButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.AutoSize = true;
            this.VolverButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VolverButton.Location = new System.Drawing.Point(340, 142);
            this.VolverButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(72, 34);
            this.VolverButton.TabIndex = 170;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // VerificacionTextbox
            // 
            this.VerificacionTextbox.Location = new System.Drawing.Point(156, 94);
            this.VerificacionTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VerificacionTextbox.Name = "VerificacionTextbox";
            this.VerificacionTextbox.Size = new System.Drawing.Size(258, 32);
            this.VerificacionTextbox.TabIndex = 171;
            // 
            // VerificacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 218);
            this.Controls.Add(this.VerificacionTextbox);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.VerificarButton);
            this.Controls.Add(this.MontoTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FechaDatetimepicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IdTextbox);
            this.Controls.Add(this.label13);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "VerificacionForm";
            this.Text = "VerificacionForm";
            this.Load += new System.EventHandler(this.VerificacionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MontoTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker FechaDatetimepicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button VerificarButton;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.TextBox VerificacionTextbox;
    }
}