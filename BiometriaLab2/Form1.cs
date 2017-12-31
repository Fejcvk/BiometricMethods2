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
    }
}
