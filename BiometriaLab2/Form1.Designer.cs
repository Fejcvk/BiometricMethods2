namespace BiometriaLab2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.strechingButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 514);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rChart
            // 
            chartArea1.Name = "ChartArea1";
            this.rChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.rChart.Legends.Add(legend1);
            this.rChart.Location = new System.Drawing.Point(777, 12);
            this.rChart.Name = "rChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.rChart.Series.Add(series1);
            this.rChart.Size = new System.Drawing.Size(408, 234);
            this.rChart.TabIndex = 1;
            this.rChart.Text = "chart1";
            // 
            // gChart
            // 
            chartArea2.Name = "ChartArea1";
            this.gChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.gChart.Legends.Add(legend2);
            this.gChart.Location = new System.Drawing.Point(777, 265);
            this.gChart.Name = "gChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.gChart.Series.Add(series2);
            this.gChart.Size = new System.Drawing.Size(408, 234);
            this.gChart.TabIndex = 2;
            this.gChart.Text = "chart2";
            // 
            // bChart
            // 
            chartArea3.Name = "ChartArea1";
            this.bChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.bChart.Legends.Add(legend3);
            this.bChart.Location = new System.Drawing.Point(777, 512);
            this.bChart.Name = "bChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.bChart.Series.Add(series3);
            this.bChart.Size = new System.Drawing.Size(408, 234);
            this.bChart.TabIndex = 3;
            this.bChart.Text = "chart3";
            // 
            // strechingButton
            // 
            this.strechingButton.Location = new System.Drawing.Point(12, 532);
            this.strechingButton.Name = "strechingButton";
            this.strechingButton.Size = new System.Drawing.Size(75, 23);
            this.strechingButton.TabIndex = 4;
            this.strechingButton.Text = "Streching";
            this.strechingButton.UseVisualStyleBackColor = true;
            this.strechingButton.Click += new System.EventHandler(this.strechingButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(94, 531);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset Image";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 758);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.strechingButton);
            this.Controls.Add(this.bChart);
            this.Controls.Add(this.gChart);
            this.Controls.Add(this.rChart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart rChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart gChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart bChart;
        private System.Windows.Forms.Button strechingButton;
        private System.Windows.Forms.Button resetButton;
    }
}

