
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoShop
{
    public partial class FormHistogram : Form
    {
        public FormHistogram()
        {

        }
        public FormHistogram(Image[] histogramResimleri)
        {
            InitializeComponent();

            pictureBox1.Image = histogramResimleri[0];
            pictureBox2.Image = histogramResimleri[1];
            pictureBox3.Image = histogramResimleri[2];
            pictureBox4.Image = histogramResimleri[3];
            pictureBox5.Image = histogramResimleri[4];

        }
    }
}
