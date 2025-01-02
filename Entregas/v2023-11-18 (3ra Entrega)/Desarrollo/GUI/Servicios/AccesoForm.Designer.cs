
namespace GUI
{
    partial class AccesoForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.UsuarioTextbox = new System.Windows.Forms.TextBox();
            this.AccederButton = new System.Windows.Forms.Button();
            this.ContraseñaTextbox = new System.Windows.Forms.TextBox();
            this.ContraseñaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.Location = new System.Drawing.Point(11, 9);
            this.UsuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(100, 25);
            this.UsuarioLabel.TabIndex = 0;
            this.UsuarioLabel.Text = "Usuario";
            // 
            // UsuarioTextbox
            // 
            this.UsuarioTextbox.Location = new System.Drawing.Point(115, 6);
            this.UsuarioTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.UsuarioTextbox.Name = "UsuarioTextbox";
            this.UsuarioTextbox.Size = new System.Drawing.Size(100, 25);
            this.UsuarioTextbox.TabIndex = 1;
            // 
            // AccederButton
            // 
            this.AccederButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AccederButton.Location = new System.Drawing.Point(61, 65);
            this.AccederButton.Margin = new System.Windows.Forms.Padding(2);
            this.AccederButton.Name = "AccederButton";
            this.AccederButton.Size = new System.Drawing.Size(100, 25);
            this.AccederButton.TabIndex = 3;
            this.AccederButton.Text = "Acceder";
            this.AccederButton.UseVisualStyleBackColor = true;
            this.AccederButton.Click += new System.EventHandler(this.AccederBTN_Click);
            // 
            // ContraseñaTextbox
            // 
            this.ContraseñaTextbox.Location = new System.Drawing.Point(115, 35);
            this.ContraseñaTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.ContraseñaTextbox.Name = "ContraseñaTextbox";
            this.ContraseñaTextbox.PasswordChar = '●';
            this.ContraseñaTextbox.Size = new System.Drawing.Size(100, 25);
            this.ContraseñaTextbox.TabIndex = 2;
            // 
            // ContraseñaLabel
            // 
            this.ContraseñaLabel.Location = new System.Drawing.Point(11, 38);
            this.ContraseñaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContraseñaLabel.Name = "ContraseñaLabel";
            this.ContraseñaLabel.Size = new System.Drawing.Size(100, 25);
            this.ContraseñaLabel.TabIndex = 3;
            this.ContraseñaLabel.Text = "Contraseña";
            // 
            // AccesoForm
            // 
            this.AcceptButton = this.AccederButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 98);
            this.Controls.Add(this.ContraseñaTextbox);
            this.Controls.Add(this.ContraseñaLabel);
            this.Controls.Add(this.AccederButton);
            this.Controls.Add(this.UsuarioTextbox);
            this.Controls.Add(this.UsuarioLabel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AccesoForm";
            this.Text = "Acceso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AccesoFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.TextBox UsuarioTextbox;
        private System.Windows.Forms.Button AccederButton;
        private System.Windows.Forms.TextBox ContraseñaTextbox;
        private System.Windows.Forms.Label ContraseñaLabel;
    }
}

