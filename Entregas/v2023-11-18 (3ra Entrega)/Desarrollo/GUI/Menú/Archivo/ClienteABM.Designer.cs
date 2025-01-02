namespace GUI
{
    partial class ClienteABM
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
            this.ModificacionBTN = new System.Windows.Forms.Button();
            this.BajaBTN = new System.Windows.Forms.Button();
            this.AltaBTN = new System.Windows.Forms.Button();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.DNI_o_CUIT_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TelefonoTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DireccionTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreApellido_o_RazonSocial_Textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CategoriaCBX = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ModificacionBTN
            // 
            this.ModificacionBTN.AutoSize = true;
            this.ModificacionBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificacionBTN.Location = new System.Drawing.Point(505, 337);
            this.ModificacionBTN.Name = "ModificacionBTN";
            this.ModificacionBTN.Size = new System.Drawing.Size(97, 28);
            this.ModificacionBTN.TabIndex = 19;
            this.ModificacionBTN.Text = "Modificación";
            this.ModificacionBTN.UseVisualStyleBackColor = true;
            this.ModificacionBTN.Click += new System.EventHandler(this.ModificacionBTN_Click);
            // 
            // BajaBTN
            // 
            this.BajaBTN.AutoSize = true;
            this.BajaBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BajaBTN.Location = new System.Drawing.Point(455, 337);
            this.BajaBTN.Name = "BajaBTN";
            this.BajaBTN.Size = new System.Drawing.Size(44, 28);
            this.BajaBTN.TabIndex = 18;
            this.BajaBTN.Text = "Baja";
            this.BajaBTN.UseVisualStyleBackColor = true;
            this.BajaBTN.Click += new System.EventHandler(this.BajaBTN_Click);
            // 
            // AltaBTN
            // 
            this.AltaBTN.AutoSize = true;
            this.AltaBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AltaBTN.Location = new System.Drawing.Point(406, 337);
            this.AltaBTN.Name = "AltaBTN";
            this.AltaBTN.Size = new System.Drawing.Size(43, 28);
            this.AltaBTN.TabIndex = 17;
            this.AltaBTN.Text = "Alta";
            this.AltaBTN.UseVisualStyleBackColor = true;
            this.AltaBTN.Click += new System.EventHandler(this.AltaBTN_Click);
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Location = new System.Drawing.Point(12, 12);
            this.ClientesDGV.MultiSelect = false;
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDGV.Size = new System.Drawing.Size(590, 158);
            this.ClientesDGV.TabIndex = 16;
            this.ClientesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDGV_CellClick);
            // 
            // DNI_o_CUIT_Textbox
            // 
            this.DNI_o_CUIT_Textbox.Location = new System.Drawing.Point(477, 194);
            this.DNI_o_CUIT_Textbox.Name = "DNI_o_CUIT_Textbox";
            this.DNI_o_CUIT_Textbox.Size = new System.Drawing.Size(125, 25);
            this.DNI_o_CUIT_Textbox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "DNI/CUIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Categoría";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IdTXT
            // 
            this.IdTXT.Enabled = false;
            this.IdTXT.Location = new System.Drawing.Point(215, 194);
            this.IdTXT.Name = "IdTXT";
            this.IdTXT.Size = new System.Drawing.Size(125, 25);
            this.IdTXT.TabIndex = 11;
            this.IdTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TelefonoTXT
            // 
            this.TelefonoTXT.Location = new System.Drawing.Point(215, 306);
            this.TelefonoTXT.Name = "TelefonoTXT";
            this.TelefonoTXT.Size = new System.Drawing.Size(125, 25);
            this.TelefonoTXT.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Teléfono";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(346, 306);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(256, 25);
            this.EmailTXT.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DireccionTXT
            // 
            this.DireccionTXT.Location = new System.Drawing.Point(215, 257);
            this.DireccionTXT.Name = "DireccionTXT";
            this.DireccionTXT.Size = new System.Drawing.Size(387, 25);
            this.DireccionTXT.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Dirección";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NombreApellido_o_RazonSocial_Textbox
            // 
            this.NombreApellido_o_RazonSocial_Textbox.Location = new System.Drawing.Point(215, 226);
            this.NombreApellido_o_RazonSocial_Textbox.Name = "NombreApellido_o_RazonSocial_Textbox";
            this.NombreApellido_o_RazonSocial_Textbox.Size = new System.Drawing.Size(387, 25);
            this.NombreApellido_o_RazonSocial_Textbox.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nombre Apellido/Razón Social";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoriaCBX
            // 
            this.CategoriaCBX.FormattingEnabled = true;
            this.CategoriaCBX.Items.AddRange(new object[] {
            "Corporativo",
            "Empresarial",
            "Gubernamental",
            "Particular"});
            this.CategoriaCBX.Location = new System.Drawing.Point(346, 194);
            this.CategoriaCBX.Name = "CategoriaCBX";
            this.CategoriaCBX.Size = new System.Drawing.Size(125, 26);
            this.CategoriaCBX.TabIndex = 28;
            // 
            // ClienteABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 382);
            this.Controls.Add(this.CategoriaCBX);
            this.Controls.Add(this.NombreApellido_o_RazonSocial_Textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DireccionTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TelefonoTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModificacionBTN);
            this.Controls.Add(this.BajaBTN);
            this.Controls.Add(this.AltaBTN);
            this.Controls.Add(this.ClientesDGV);
            this.Controls.Add(this.DNI_o_CUIT_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTXT);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "ClienteABM";
            this.Text = "ClienteFRM";
            this.Load += new System.EventHandler(this.ClienteFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModificacionBTN;
        private System.Windows.Forms.Button BajaBTN;
        private System.Windows.Forms.Button AltaBTN;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private System.Windows.Forms.TextBox DNI_o_CUIT_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TelefonoTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DireccionTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombreApellido_o_RazonSocial_Textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CategoriaCBX;
    }
}