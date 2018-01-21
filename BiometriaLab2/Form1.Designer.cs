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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.strechingButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.equalisationButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 791);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // rChart
            // 
            chartArea7.Name = "ChartArea1";
            this.rChart.ChartAreas.Add(chartArea7);
            this.rChart.Location = new System.Drawing.Point(1166, 18);
            this.rChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rChart.Name = "rChart";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.Red;
            series7.Name = "redPixels";
            this.rChart.Series.Add(series7);
            this.rChart.Size = new System.Drawing.Size(612, 360);
            this.rChart.TabIndex = 1;
            this.rChart.Text = "chart1";
            // 
            // gChart
            // 
            chartArea8.Name = "ChartArea1";
            this.gChart.ChartAreas.Add(chartArea8);
            this.gChart.Location = new System.Drawing.Point(1166, 408);
            this.gChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gChart.Name = "gChart";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Lime;
            series8.Name = "greenPixels";
            this.gChart.Series.Add(series8);
            this.gChart.Size = new System.Drawing.Size(612, 360);
            this.gChart.TabIndex = 2;
            this.gChart.Text = "chart2";
            // 
            // bChart
            // 
            chartArea9.Name = "ChartArea1";
            this.bChart.ChartAreas.Add(chartArea9);
            this.bChart.Location = new System.Drawing.Point(1166, 788);
            this.bChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bChart.Name = "bChart";
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.Blue;
            series9.MarkerColor = System.Drawing.Color.White;
            series9.Name = "bluePixels";
            this.bChart.Series.Add(series9);
            this.bChart.Size = new System.Drawing.Size(612, 360);
            this.bChart.TabIndex = 3;
            // 
            // strechingButton
            // 
            this.strechingButton.Location = new System.Drawing.Point(18, 817);
            this.strechingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.strechingButton.Name = "strechingButton";
            this.strechingButton.Size = new System.Drawing.Size(112, 35);
            this.strechingButton.TabIndex = 4;
            this.strechingButton.Text = "Streching";
            this.strechingButton.UseVisualStyleBackColor = true;
            this.strechingButton.Click += new System.EventHandler(this.strechingButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(141, 817);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 35);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset Image";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // equalisationButton
            // 
            this.equalisationButton.Location = new System.Drawing.Point(262, 817);
            this.equalisationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.equalisationButton.Name = "equalisationButton";
            this.equalisationButton.Size = new System.Drawing.Size(112, 35);
            this.equalisationButton.TabIndex = 7;
            this.equalisationButton.Text = "Equalisation";
            this.equalisationButton.UseVisualStyleBackColor = true;
            this.equalisationButton.Click += new System.EventHandler(this.equalisationButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 817);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Averaging filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(541, 818);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Gaussian filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(700, 817);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Shapening filter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 1166);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.equalisationButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.strechingButton);
            this.Controls.Add(this.bChart);
            this.Controls.Add(this.gChart);
            this.Controls.Add(this.rChart);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

