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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.strechingButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.equalisationButton = new System.Windows.Forms.Button();
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
            chartArea4.Name = "ChartArea1";
            this.rChart.ChartAreas.Add(chartArea4);
            this.rChart.Location = new System.Drawing.Point(777, 12);
            this.rChart.Name = "rChart";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Name = "redPixels";
            this.rChart.Series.Add(series4);
            this.rChart.Size = new System.Drawing.Size(408, 234);
            this.rChart.TabIndex = 1;
            this.rChart.Text = "chart1";
            // 
            // gChart
            // 
            chartArea5.Name = "ChartArea1";
            this.gChart.ChartAreas.Add(chartArea5);
            this.gChart.Location = new System.Drawing.Point(777, 265);
            this.gChart.Name = "gChart";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Lime;
            series5.Name = "greenPixels";
            this.gChart.Series.Add(series5);
            this.gChart.Size = new System.Drawing.Size(408, 234);
            this.gChart.TabIndex = 2;
            this.gChart.Text = "chart2";
            // 
            // bChart
            // 
            chartArea6.Name = "ChartArea1";
            this.bChart.ChartAreas.Add(chartArea6);
            this.bChart.Location = new System.Drawing.Point(777, 512);
            this.bChart.Name = "bChart";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Blue;
            series6.MarkerColor = System.Drawing.Color.White;
            series6.Name = "bluePixels";
            this.bChart.Series.Add(series6);
            this.bChart.Size = new System.Drawing.Size(408, 234);
            this.bChart.TabIndex = 3;
            // 
            // strechingButton
            // 
            this.strechingButton.Location = new System.Drawing.Point(12, 531);
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
            // equalisationButton
            // 
            this.equalisationButton.Location = new System.Drawing.Point(175, 531);
            this.equalisationButton.Name = "equalisationButton";
            this.equalisationButton.Size = new System.Drawing.Size(75, 23);
            this.equalisationButton.TabIndex = 7;
            this.equalisationButton.Text = "Equalisation";
            this.equalisationButton.UseVisualStyleBackColor = true;
            this.equalisationButton.Click += new System.EventHandler(this.equalisationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 758);
            this.Controls.Add(this.equalisationButton);
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
        private System.Windows.Forms.Button equalisationButton;
    }
}

