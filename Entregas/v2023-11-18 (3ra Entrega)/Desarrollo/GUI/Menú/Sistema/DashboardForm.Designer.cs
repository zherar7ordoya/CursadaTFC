namespace GUI
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.VentasChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TipoCBX = new System.Windows.Forms.ComboBox();
            this.ColorCBX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportarBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FormatoCBX = new System.Windows.Forms.ComboBox();
            this.NombreTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VentasChart)).BeginInit();
            this.SuspendLayout();
            // 
            // VentasChart
            // 
            chartArea4.Name = "ChartArea1";
            this.VentasChart.ChartAreas.Add(chartArea4);
            this.VentasChart.Dock = System.Windows.Forms.DockStyle.Left;
            legend4.Name = "Legend1";
            this.VentasChart.Legends.Add(legend4);
            this.VentasChart.Location = new System.Drawing.Point(0, 0);
            this.VentasChart.Name = "VentasChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.VentasChart.Series.Add(series4);
            this.VentasChart.Size = new System.Drawing.Size(750, 450);
            this.VentasChart.TabIndex = 0;
            this.VentasChart.Text = "Ventas";
            // 
            // TipoCBX
            // 
            this.TipoCBX.FormattingEnabled = true;
            this.TipoCBX.Items.AddRange(new object[] {
            "Bar",
            "BoxPlot",
            "Bubble",
            "Candlestick",
            "Column",
            "Doughnut",
            "ErrorBar",
            "FastLine",
            "FastPoint",
            "Funnel",
            "Kagi",
            "Line",
            "Pie",
            "Point",
            "PointAndFigure",
            "Polar",
            "Pyramid",
            "Radar",
            "Range",
            "RangeBar",
            "RangeColumn",
            "Renko",
            "Spline",
            "SplineArea",
            "SplineRange",
            "StackedArea",
            "StackedArea100",
            "StackedBar",
            "StackedBar100",
            "StackedColumn",
            "StackedColumn100",
            "StepLine",
            "Stock",
            "ThreeLineBreak"});
            this.TipoCBX.Location = new System.Drawing.Point(760, 32);
            this.TipoCBX.Name = "TipoCBX";
            this.TipoCBX.Size = new System.Drawing.Size(173, 28);
            this.TipoCBX.TabIndex = 1;
            this.TipoCBX.SelectedIndexChanged += new System.EventHandler(this.TipoCBX_SelectedIndexChanged);
            // 
            // ColorCBX
            // 
            this.ColorCBX.FormattingEnabled = true;
            this.ColorCBX.Items.AddRange(new object[] {
            "Berry",
            "Bright",
            "BrightPastel",
            "Chocolate",
            "EarthTones",
            "Excel",
            "Fire",
            "Grayscale",
            "Light",
            "None",
            "Pastel",
            "SeaGreen"});
            this.ColorCBX.Location = new System.Drawing.Point(760, 86);
            this.ColorCBX.Name = "ColorCBX";
            this.ColorCBX.Size = new System.Drawing.Size(173, 28);
            this.ColorCBX.TabIndex = 2;
            this.ColorCBX.SelectedIndexChanged += new System.EventHandler(this.ColorCBX_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(756, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color";
            // 
            // ExportarBTN
            // 
            this.ExportarBTN.AutoSize = true;
            this.ExportarBTN.Location = new System.Drawing.Point(842, 408);
            this.ExportarBTN.Name = "ExportarBTN";
            this.ExportarBTN.Size = new System.Drawing.Size(91, 30);
            this.ExportarBTN.TabIndex = 5;
            this.ExportarBTN.Text = "Exportar";
            this.ExportarBTN.UseVisualStyleBackColor = true;
            this.ExportarBTN.Click += new System.EventHandler(this.ExportarBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(756, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Formato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(756, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre";
            // 
            // FormatoCBX
            // 
            this.FormatoCBX.FormattingEnabled = true;
            this.FormatoCBX.Items.AddRange(new object[] {
            "Bmp",
            "Gif",
            "Jpeg",
            "Png",
            "Tiff"});
            this.FormatoCBX.Location = new System.Drawing.Point(760, 359);
            this.FormatoCBX.Name = "FormatoCBX";
            this.FormatoCBX.Size = new System.Drawing.Size(173, 28);
            this.FormatoCBX.TabIndex = 7;
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(760, 308);
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(173, 25);
            this.NombreTXT.TabIndex = 10;
            // 
            // VentaChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.NombreTXT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FormatoCBX);
            this.Controls.Add(this.ExportarBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorCBX);
            this.Controls.Add(this.TipoCBX);
            this.Controls.Add(this.VentasChart);
            this.Name = "VentaChart";
            this.Text = "VentasChart";
            this.Load += new System.EventHandler(this.VentaChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart VentasChart;
        private System.Windows.Forms.ComboBox TipoCBX;
        private System.Windows.Forms.ComboBox ColorCBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExportarBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FormatoCBX;
        private System.Windows.Forms.TextBox NombreTXT;
    }
}