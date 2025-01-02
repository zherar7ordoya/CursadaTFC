namespace GUI
{
    partial class FacturaForm
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
            this.FacturaReportviewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // FacturaReportviewer
            // 
            this.FacturaReportviewer.LocalReport.ReportEmbeddedResource = "GUI.Menú.Venta.Facturación.FacturaReport.rdlc";
            this.FacturaReportviewer.Location = new System.Drawing.Point(12, 12);
            this.FacturaReportviewer.Name = "FacturaReportviewer";
            this.FacturaReportviewer.ServerReport.BearerToken = null;
            this.FacturaReportviewer.Size = new System.Drawing.Size(660, 277);
            this.FacturaReportviewer.TabIndex = 10;
            // 
            // FacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 301);
            this.Controls.Add(this.FacturaReportviewer);
            this.Name = "FacturaForm";
            this.Text = "FacturaForm";
            this.Load += new System.EventHandler(this.FacturaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer FacturaReportviewer;
    }
}