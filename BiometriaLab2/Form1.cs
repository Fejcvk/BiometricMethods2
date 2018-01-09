using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometriaLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           fillCharts(new Bitmap(BiometriaLab2.Properties.Resources.Lenna));
        }
        private void histogramStreching(Bitmap bitmap)
        {
            List<int> minVals = minAndMxChannelValue(bitmap);
            var minR = minVals.ElementAt(0);
            var minG = minVals.ElementAt(1);
            var minB = minVals.ElementAt(2);
            var maxR = minVals.ElementAt(3);
            var maxG = minVals.ElementAt(4);
            var maxB = minVals.ElementAt(5);
            var height = bitmap.Height;
            var width = bitmap.Width;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var currRGB = bitmap.GetPixel(x, y);
                    var currR = currRGB.R;
                    var currG = currRGB.G;
                    var currB = currRGB.B;
                    var newR = lutTransformation(currR, maxR, minR);
                    var newG = lutTransformation(currG, maxG, minG);
                    var newB = lutTransformation(currB, maxB, minB);
                    var newColour = Color.FromArgb(currRGB.A, (int)newR, (int)newG, (int)newB);
                    bitmap.SetPixel(x, y, newColour);
                }
            }
            pictureBox1.Image = bitmap;
            fillCharts(bitmap);
        }
        private List<int> minAndMxChannelValue(Bitmap bitmap)
        {
            var height = bitmap.Height;
            var width = bitmap.Width;
            var smallestRValue = 255;
            var smallestGValue = 255;
            var smallestBValue = 255;
            var biggestRval = 0;
            var biggestGval = 0;
            var biggestBval = 0;
            var minMaxChannelVal = new List<int>();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var currRGB = bitmap.GetPixel(x, y);
                    var R = currRGB.R;
                    var G = currRGB.G;
                    var B = currRGB.B;
                    if (R < smallestRValue)
                        smallestRValue = R;
                    if (B < smallestBValue)
                        smallestBValue = B;
                    if (G < smallestGValue)
                        smallestGValue = G;
                    if (R > biggestBval)
                        biggestRval = R;
                    if (G > biggestGval)
                        biggestGval = G;
                    if (B > biggestBval)
                        biggestBval = B;
                }
            }
            minMaxChannelVal.Add(smallestRValue);
            minMaxChannelVal.Add(smallestGValue);
            minMaxChannelVal.Add(smallestBValue);
            minMaxChannelVal.Add(biggestBval);
            minMaxChannelVal.Add(biggestGval);
            minMaxChannelVal.Add(biggestBval);
            return minMaxChannelVal;
        }
        private int lutTransformation(int currVal, int maxVal, int minVal)
        {
            int transformedVal = 255 / (maxVal - minVal) * (currVal - minVal);
            return transformedVal;
        }

        private void strechingButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(BiometriaLab2.Properties.Resources.Lenna);
            histogramStreching(bitmap);

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = BiometriaLab2.Properties.Resources.Lenna;
        }
        private void fillCharts(Bitmap bitmap)
        {
            var redOccuranceList = new List<int>();
            var blueOccuranceList = new List<int>();
            var greenOccuranceList = new List<int>();
            for (int i = 0; i<256;i++)
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
            for(int i = 0; i < 256; i++)
            {
                this.rChart.Series["redPixels"].Points.AddXY(i, redOccuranceList.ElementAt(i));
                this.gChart.Series["greenPixels"].Points.AddXY(i, greenOccuranceList.ElementAt(i));
                this.bChart.Series["bluePixels"].Points.AddXY(i, blueOccuranceList.ElementAt(i));
            }
        }

        private void equalisationButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(BiometriaLab2.Properties.Resources.Lenna);
            histogramEqualisation(bitmap);
        }

        private void histogramEqualisation(Bitmap bitmap)
        {
            var height = bitmap.Height;
            var width = bitmap.Width;
            //TODO:EQUALISATION
        }
        private int equalisationLut(int currDistr, int zeroIdxDistr)
        {
            return ((currDistr - zeroIdxDistr) / (1 - zeroIdxDistr) ) * 255;
        }

    }
}
