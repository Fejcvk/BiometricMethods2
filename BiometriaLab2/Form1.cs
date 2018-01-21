using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BiometriaLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // fillCharts(new Bitmap(BiometriaLab2.Properties.Resources.Lenna));
            pictureBox1.Image = BiometriaLab2.Properties.Resources.img01;
            fillCharts(new Bitmap(BiometriaLab2.Properties.Resources.img01));
        }
        private void histogramStreching(Bitmap bitmap)
        {
            var height = bitmap.Height;
            var width = bitmap.Width;
            var smallestValue = 256;
            var maxValue = -1;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var currRgb = bitmap.GetPixel(x, y);
                    var avgRbg = (currRgb.R + currRgb.G + currRgb.B) / 3;
                    if (maxValue < avgRbg)
                        maxValue = avgRbg;
                    if (smallestValue > avgRbg)
                        smallestValue = avgRbg;
                    bitmap.SetPixel(x, y, Color.FromArgb(currRgb.A, avgRbg, avgRbg, avgRbg));
                }
            }
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var currRGB = bitmap.GetPixel(x, y);
                    double newR = (double)(currRGB.R - smallestValue) / (double)(maxValue - smallestValue) * 255.0d;

                    double newG = (double)(currRGB.G - smallestValue) / (double)(maxValue - smallestValue) * 255.0d;

                    double newB = (double)(currRGB.B - smallestValue) / (double)(maxValue - smallestValue) * 255.0d;

                    bitmap.SetPixel(x, y, Color.FromArgb(currRGB.A, (int)newR, (int)newG, (int)newB));
                }
            }
            pictureBox1.Image = bitmap;
            fillCharts(bitmap);
        }

        private void strechingButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            histogramStreching(bitmap);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //    Bitmap bitmap = new Bitmap(BiometriaLab2.Properties.Resources.Lenna);
            //  pictureBox1.Image = BiometriaLab2.Properties.Resources.Lenna;
            //fillCharts(bitmap);
            pictureBox1.Image = BiometriaLab2.Properties.Resources.img01;
            fillCharts(new Bitmap(BiometriaLab2.Properties.Resources.img01));
        }
        private void clearCharts()
        {
            foreach (var series in rChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in gChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in bChart.Series)
            {
                series.Points.Clear();
            }
        }
        private void fillCharts(Bitmap bitmap)
        {
            clearCharts();
            var redOccuranceList = new List<int>();
            var blueOccuranceList = new List<int>();
            var greenOccuranceList = new List<int>();
            for (int i = 0; i < 256; i++)
            {
                redOccuranceList.Insert(i, 0);
                greenOccuranceList.Insert(i, 0);
                blueOccuranceList.Insert(i, 0);
            }
            var height = bitmap.Height;
            var width = bitmap.Width;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    var currRGB = bitmap.GetPixel(j, i);
                    var redCounter = redOccuranceList.ElementAt(currRGB.R);
                    redOccuranceList.RemoveAt(currRGB.R);
                    redOccuranceList.Insert(currRGB.R, redCounter + 1);
                    var greenCounter = greenOccuranceList.ElementAt(currRGB.G);
                    greenOccuranceList.RemoveAt(currRGB.G);
                    greenOccuranceList.Insert(currRGB.G, greenCounter + 1);
                    var blueCounter = redOccuranceList.ElementAt(currRGB.B);
                    blueOccuranceList.RemoveAt(currRGB.B);
                    blueOccuranceList.Insert(currRGB.B, blueCounter + 1);
                }
            }
            for (int i = 0; i < 256; i++)
            {
                this.rChart.Series["redPixels"].Points.AddXY(i, redOccuranceList.ElementAt(i));
                this.gChart.Series["greenPixels"].Points.AddXY(i, greenOccuranceList.ElementAt(i));
                this.bChart.Series["bluePixels"].Points.AddXY(i, blueOccuranceList.ElementAt(i));
            }
        }

        private void equalisationButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Image);
            histogramEqualisation(bitmap);
        }

        private void histogramEqualisation(Bitmap bitmap)
        {
            int[] LUT = new int[256];
            double[] Distribiuty = new double[256];

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var currRgb = bitmap.GetPixel(x, y);
                    var avrRgb = (currRgb.R + currRgb.G + currRgb.B) / 3;
                    bitmap.SetPixel(x, y, Color.FromArgb(currRgb.A, avrRgb, avrRgb, avrRgb));
                }
            }
            pictureBox1.Image = bitmap;
            fillCharts(bitmap);
            for (int y = 0; y <= 255; y++)
            {
                for (int x = 0; x <= y; x++)
                {
                    Distribiuty[y] += rChart.Series[0].Points[x].YValues[0];
                }
                Distribiuty[y] /= bitmap.Width * bitmap.Height;

                LUT[y] = (int)((Distribiuty[y] - Distribiuty[0]) / (1 - Distribiuty[0]) * 255);
            }
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    var currRgb = bitmap.GetPixel(x, y);
                    var avgR = currRgb.R;
                    bitmap.SetPixel(x, y, Color.FromArgb(currRgb.A, LUT[avgR], LUT[avgR], LUT[avgR]));
                }
            }
            pictureBox1.Image = bitmap;
            fillCharts(bitmap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filterType = "avg";
            applyFilter(filterType);
        }

        private void applyFilter(string _type)
        {
            double[,] matrix = new double[3, 3];
            if (_type.Equals("avg"))
            {
                matrix = new double[,] { { 1 / 9.0d, 1 / 9.0d, 1 / 9.0d }, { 1 / 9.0d, 1 / 9.0d, 1 / 9.0d }, { 1 / 9.0d, 1 / 9.0d, 1 / 9.0d } };
            }
            else if (_type.Equals("gauss"))
            {
                matrix = new double[,] { { 1 / 16.0d, 1 / 8.0d, 1 / 16.0d }, { 1 / 8.0d, 1 / 4.0d, 1 / 8.0d }, { 1 / 16.0d, 1 / 8.0d, 1 / 16.0d } };
            }
            else if (_type.Equals("sharp"))
            {
                matrix = new double[,] { { 0, -1.0d / 4.0d, 0 }, { -1.0d / 4.0d, 2.0d, -1.0d / 4.0d }, { 0, -1.0d / 4.0d, 0 } };
            }
            Bitmap temp;
            var bitmap = new Bitmap(pictureBox1.Image);
            Color color;
            double sumR = 0.0;
            double sumG = 0.0;
            double sumB = 0.0;
            temp = bitmap;
            for (int i = 0; i <= bitmap.Width - 3; i++)
            {
                for (int j = 0; j <= bitmap.Height - 3; j++)
                {
                    for (int x = i; x <= i + 2; x++)
                    {
                        for (int y = j; y <= j + 2; y++)
                        {
                            color = bitmap.GetPixel(x, y);
                            sumR += color.R * matrix[x - i, y - j];
                            sumG += color.G * matrix[x - i, y - j];
                            sumB += color.B * matrix[x - i, y - j];
                        }
                    }
                   sumR = sumR > 0 ? (int)Math.Round(sumR, 10) : 0;
                   sumG = sumG > 0 ? (int)Math.Round(sumG, 10) : 0;
                   sumB = sumB > 0 ? (int)Math.Round(sumB, 10) : 0;

                   temp.SetPixel(i + 1, j + 1, Color.FromArgb(
                            sumR < 255 ? (int)Math.Round(sumR, 10) : 255,
                            sumG < 255 ? (int)Math.Round(sumG, 10) : 255,
                            sumB < 255 ? (int)Math.Round(sumB, 10) : 255));
                    sumR = 0;
                    sumG = 0;
                    sumB = 0;
                }
            }
            bitmap = temp;
            pictureBox1.Image = bitmap;
            fillCharts(bitmap);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String filterType = "gauss";
            applyFilter(filterType);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String filterType = "sharp";
            applyFilter(filterType);
        }
    }
}
