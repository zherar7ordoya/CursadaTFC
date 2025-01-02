namespace GUI
{
    partial class ClienteForm
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
            this.DNI_o_CUIT_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoriaCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.DireccionTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TelefonoTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GrabarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI/CUIT";
            // 
            // DNI_o_CUIT_Textbox
            // 
            this.DNI_o_CUIT_Textbox.Location = new System.Drawing.Point(186, 14);
            this.DNI_o_CUIT_Textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DNI_o_CUIT_Textbox.Name = "DNI_o_CUIT_Textbox";
            this.DNI_o_CUIT_Textbox.Size = new System.Drawing.Size(114, 25);
            this.DNI_o_CUIT_Textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría";
            // 
            // CategoriaCombobox
            // 
            this.CategoriaCombobox.FormattingEnabled = true;
            this.CategoriaCombobox.Items.AddRange(new object[] {
            "Corporativo",
            "Empresarial",
            "Gubernamental",
            "Particular"});
            this.CategoriaCombobox.Location = new System.Drawing.Point(386, 14);
            this.CategoriaCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoriaCombobox.Name = "CategoriaCombobox";
            this.CategoriaCombobox.Size = new System.Drawing.Size(138, 26);
            this.CategoriaCombobox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre/Razón Social";
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Location = new System.Drawing.Point(186, 50);
            this.NombreTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(338, 25);
            this.NombreTextbox.TabIndex = 3;
            // 
            // DireccionTextbox
            // 
            this.DireccionTextbox.Location = new System.Drawing.Point(186, 86);
            this.DireccionTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DireccionTextbox.Name = "DireccionTextbox";
            this.DireccionTextbox.Size = new System.Drawing.Size(338, 25);
            this.DireccionTextbox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección";
            // 
            // TelefonoTextbox
            // 
            this.TelefonoTextbox.Location = new System.Drawing.Point(186, 122);
            this.TelefonoTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TelefonoTextbox.Name = "TelefonoTextbox";
            this.TelefonoTextbox.Size = new System.Drawing.Size(114, 25);
            this.TelefonoTextbox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(386, 122);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(138, 25);
            this.EmailTextbox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // GrabarButton
            // 
            this.GrabarButton.AutoSize = true;
            this.GrabarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GrabarButton.Location = new System.Drawing.Point(458, 181);
            this.GrabarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GrabarButton.Name = "GrabarButton";
            this.GrabarButton.Size = new System.Drawing.Size(59, 28);
            this.GrabarButton.TabIndex = 8;
            this.GrabarButton.Text = "Grabar";
            this.GrabarButton.UseVisualStyleBackColor = true;
            this.GrabarButton.Click += new System.EventHandler(this.GrabarButton_Click);
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 228);
            this.Controls.Add(this.GrabarButton);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelefonoTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DireccionTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CategoriaCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DNI_o_CUIT_Textbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNI_o_CUIT_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoriaCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.TextBox DireccionTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TelefonoTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GrabarButton;
    }
}