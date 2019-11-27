using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace PhotoShop
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> imgInput;
        private Image<Bgr, byte> imgInputBackup;
        private Image imageOriginal;
        public Form1()
        {
            InitializeComponent();
            addToolTips();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaAc();
        }
        private void dosyaAc()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                   
                    imgInput = new Image<Bgr, byte>(ofd.FileName);
                   
                    imgInputBackup = imgInput.Clone();

                    pictureBox1.Image = imgInput.Bitmap;
                    imageOriginal = pictureBox1.Image;
                    this.Text = "PhotoShop " + version + " " + ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            histogramHesapla();
            /********************************************/
            /* EMGU NUN KENDİ VERDİĞİ */
            Form frm = new Form();
            var img = imgInput;

            HistogramBox histo = new HistogramBox();

            histo.ClearHistogram();
            histo.GenerateHistograms(img, 256);
            histo.Dock = DockStyle.Fill;
            histo.Refresh();

            frm.Controls.Add(histo);

            frm.ShowDialog();

            /******************************************/
        }

        private void histogramHesapla()
        {

            Bitmap bmp = imgInput.Bitmap;
            int[] renkYogunluguK = new int[256];
            int[] renkYogunluguY = new int[256];
            int[] renkYogunluguM = new int[256];
            int[] renkYogunluguG = new int[256];
            float maxKirmizi = 0, maxYesil = 0, maxMavi = 0, maxGri = 0;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int RenkDegeriKirmizi = bmp.GetPixel(i, j).R;
                    int RenkDegeriYesil = bmp.GetPixel(i, j).G;
                    int RenkDegeriMavi = bmp.GetPixel(i, j).B;
                    int RenkDegeriGri = (bmp.GetPixel(i, j).R + bmp.GetPixel(i, j).G + bmp.GetPixel(i, j).B) / 3;


                    
                    renkYogunluguK[RenkDegeriKirmizi]++;
                    renkYogunluguY[RenkDegeriYesil]++;
                    renkYogunluguM[RenkDegeriMavi]++;
                    renkYogunluguG[RenkDegeriGri]++;
                    
                    if (maxKirmizi < renkYogunluguK[RenkDegeriKirmizi])
                        maxKirmizi = renkYogunluguK[RenkDegeriKirmizi];

                    if (maxYesil < renkYogunluguY[RenkDegeriYesil])
                        maxYesil = renkYogunluguY[RenkDegeriYesil];

                    if (maxMavi < renkYogunluguM[RenkDegeriMavi])
                        maxMavi = renkYogunluguM[RenkDegeriMavi];

                    if (maxGri < renkYogunluguG[RenkDegeriGri])
                        maxGri = renkYogunluguG[RenkDegeriGri];
                }
            }

            int histogramBoyutu = 128;
            Bitmap resimKirmizi = new Bitmap(256, histogramBoyutu + 10);
            using (Graphics g = Graphics.FromImage(resimKirmizi))
            {
                for (int i = 0; i < renkYogunluguK.Length; i++)
                {
                    float yuzde = renkYogunluguK[i] / maxKirmizi;
                    g.DrawLine(Pens.Red,
                        new Point(i, resimKirmizi.Height - 5),
                        new Point(i, resimKirmizi.Height - 5 - (int)(yuzde * histogramBoyutu))
                        );
                }
            }

            Bitmap resimYesil = new Bitmap(256, histogramBoyutu + 10);
            using (Graphics g = Graphics.FromImage(resimYesil))
            {
                for (int i = 0; i < renkYogunluguY.Length; i++)
                {
                    float yuzde = renkYogunluguY[i] / maxYesil;
                    g.DrawLine(Pens.Green,
                        new Point(i, resimYesil.Height - 5),
                        new Point(i, resimYesil.Height - 5 - (int)(yuzde * histogramBoyutu))
                        );
                }
            }

            Bitmap resimMavi = new Bitmap(256, histogramBoyutu + 10);
            using (Graphics g = Graphics.FromImage(resimMavi))
            {
                for (int i = 0; i < renkYogunluguM.Length; i++)
                {
                    float yuzde = renkYogunluguM[i] / maxMavi;
                    g.DrawLine(Pens.Blue,
                        new Point(i, resimMavi.Height - 5),
                        new Point(i, resimMavi.Height - 5 - (int)(yuzde * histogramBoyutu))
                        );
                }
            }

            Bitmap resimGri = new Bitmap(256, histogramBoyutu + 10);
            using (Graphics g = Graphics.FromImage(resimGri))
            {
                for (int i = 0; i < renkYogunluguG.Length; i++)
                {
                    float yuzde = renkYogunluguG[i] / maxGri;
                    g.DrawLine(Pens.Gray,
                        new Point(i, resimGri.Height - 5),
                        new Point(i, resimGri.Height - 5 - (int)(yuzde * histogramBoyutu))
                        );
                }
            }

            Bitmap resimKarisik = new Bitmap(256, histogramBoyutu + 10);
            using (Graphics g = Graphics.FromImage(resimKarisik))
            {
                for (int i = 0; i < renkYogunluguK.Length; i++)
                {
                    float yuzdeK = renkYogunluguK[i] / maxKirmizi;
                    
                    g.DrawLine(new Pen(Color.FromArgb(70, 255, 100, 100)),
                        new Point(i, resimKarisik.Height - 5),
                        new Point(i, resimKarisik.Height - 5 - (int)(yuzdeK * histogramBoyutu))
                        );
                    //----------------------------------

                    float yuzdeY = renkYogunluguY[i] / maxYesil;
                    g.DrawLine(new Pen(Color.FromArgb(70, 100, 255, 100)),
                        new Point(i, resimKarisik.Height - 5),
                        new Point(i, resimKarisik.Height - 5 - (int)(yuzdeY * histogramBoyutu))
                        );
                    //----------------------------------

                    float yuzdeM = renkYogunluguM[i] / maxMavi;
                    g.DrawLine(new Pen(Color.FromArgb(70, 100, 100, 255)),
                        new Point(i, resimKarisik.Height - 5),
                        new Point(i, resimKarisik.Height - 5 - (int)(yuzdeM * histogramBoyutu))
                        );
                    //----------------------------------

                    float yuzdeG = renkYogunluguG[i] / maxGri;
                    g.DrawLine(new Pen(Color.FromArgb(70, 100, 100, 100)),
                        new Point(i, resimKarisik.Height - 5),
                        new Point(i, resimKarisik.Height - 5 - (int)(yuzdeG * histogramBoyutu))
                        );

                }
            }
           
            FormHistogram formHistogram = new FormHistogram(new Image[] { resimKirmizi, resimYesil, resimMavi, resimGri, resimKarisik });
            formHistogram.Show();
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap temp = new Bitmap(pictureBox1.Image);
                Bitmap image = new Bitmap(temp, temp.Height, temp.Width);

                for (int i = 0; i < temp.Height; i++)
                {
                    for (int j = temp.Width - 1; j >= 0; j--)
                    {
                        Color renk = rengiOlustur(temp.Width - j - 1, i, temp);
                        image.SetPixel(i, j, renk);
                    }
                }
                pictureBox1.Image = image;
                imgInput.Bitmap = image;
            }
        }

        private Color rengiOlustur(int x, int y, Bitmap resim)
        {
            Color renk = Color.FromArgb(resim.GetPixel(x, y).R, resim.GetPixel(x, y).G, resim.GetPixel(x, y).B);
            return renk;
        }

        

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap temp = new Bitmap(pictureBox1.Image);
                Bitmap image = new Bitmap(temp, temp.Height, temp.Width);

                int kirmizi, yesil, mavi;
                int genislik = pictureBox1.Image.Width;
                int uzunluk = pictureBox1.Image.Height;

                for (int i = 0; i < genislik; i++)
                    for (int j = 0; j < uzunluk; j++)
                    {
                        kirmizi = temp.GetPixel(i, j).R;
                        yesil = temp.GetPixel(i, j).G;
                        mavi = temp.GetPixel(i, j).B;
                        Color renk;
                        renk = Color.FromArgb(kirmizi, yesil, mavi);
                        image.SetPixel(uzunluk - 1 - j, i, renk);
                    }

                pictureBox1.Image = image;
            }
        }

        private void btnReOpen_Click(object sender, EventArgs e)
        {
            imgInput = imgInputBackup.Clone();
            pictureBox1.Image = imgInput.Bitmap;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dosyaKaydet();
        }
        private void dosyaKaydet()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgInput.Save(dialog.FileName);
            }
        }
        private void btnGreyScalling_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = imgInput.Bitmap;
                int genislik = bmp.Width;
                int uzunluk = bmp.Height;

                Color piksel;

                for (int i = 0; i < uzunluk; i++)
                {
                    for (int j = 0; j < genislik; j++)
                    {
                        piksel = bmp.GetPixel(j, i);

                        int alpha = piksel.A;
                        int kirmizi = piksel.R;
                        int yesil = piksel.G;
                        int mavi = piksel.B;

                        int renkOrtalamasi = (kirmizi + yesil + mavi) / 3;

                        bmp.SetPixel(j, i, Color.FromArgb(alpha, renkOrtalamasi, renkOrtalamasi, renkOrtalamasi));
                    }
                }
                pictureBox1.Image = bmp;
                imgInput.Bitmap = bmp;
            }
        }

        private void btnMirrorLeft_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                Bitmap simg = imgInput.Bitmap;

                int width = simg.Width;
                int height = simg.Height;
               
                Bitmap aynalanmisResim = new Bitmap(width * 2, height);

                for (int y = 0; y < height; y++)
                {
                    for (int i = width, j = width, k = 0; k < width; k++, i--, j++)
                    {
                        Color p = simg.GetPixel(k, y);

                        aynalanmisResim.SetPixel(i, y, p);
                        aynalanmisResim.SetPixel(j, y, p);
                    }
                }

                pictureBox1.Image = aynalanmisResim;
                imgInput.Bitmap = aynalanmisResim;
            }
        }

        private void btnMirorRight_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                Bitmap simg = imgInput.Bitmap;

                int width = simg.Width;
                int height = simg.Height;

               
                Bitmap mimg = new Bitmap(width * 2, height);

                for (int y = 0; y < height; y++)
                {
                    for (int lx = 0, rx = width * 2 - 1; lx < width; lx++, rx--)
                    {
                        Color p = simg.GetPixel(lx, y);

                        mimg.SetPixel(lx, y, p);
                        mimg.SetPixel(rx, y, p);
                    }
                }

                pictureBox1.Image = mimg;
                imgInput.Bitmap = mimg;
            }
        }

        private void renkleriTersineCevir()
        {
            Bitmap pic = new Bitmap(pictureBox1.Image);
            for (int y = 0; (y <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic.SetPixel(x, y, inv);
                }
            }
            pictureBox1.Image = pic;
            imgInput.Bitmap = pic;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Dispose();
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            Bitmap bmp = imgInput.Bitmap;

            int width = bmp.Width;
            int height = bmp.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

            pictureBox1.Image = bmp;
            imgInput.Bitmap = bmp;

        }

        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            dosyaAc();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dosyaKaydet();
        }

        private void rengiDegistir()
        {
            if (pictureBox1.Image != null)
            {
                Bitmap bmp = imgInput.Bitmap;

                int width = bmp.Width;
                int height = bmp.Height;

                Bitmap yeniResim = new Bitmap(bmp);

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Color p = bmp.GetPixel(x, y);
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        if (!cbRedChannel.Checked)
                        {
                            r = 0;
                        }
                        if (!cbGreenChannel.Checked)
                        {
                            g = 0;
                        }
                        if (!cbBlueChannel.Checked)
                        {
                            b = 0;
                        }
                        yeniResim.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    }
                }
                if (cbRedChannel.Checked)
                {
                    
                    cbRedChannel.BackgroundImage = global::PhotoShop.Properties.Resources.redChannel1;
                    cbRedChannel.BackColor = Color.White;
                    cbRedChannel.Text = "";
                }
                else
                {
                    cbRedChannel.BackgroundImage = null;
                    cbRedChannel.BackColor = Color.Red;
                    cbRedChannel.Text = "X";
                }

                if (cbGreenChannel.Checked)
                {
                    cbGreenChannel.BackgroundImage = global::PhotoShop.Properties.Resources.greenChannel;
                    cbGreenChannel.BackColor = Color.White;
                    cbGreenChannel.Text = "";
                }
                else
                {
                    cbGreenChannel.BackgroundImage = null;
                    cbGreenChannel.BackColor = Color.Green;
                    cbGreenChannel.Text = "X";
                }

                if (cbBlueChannel.Checked)
                {
                    cbBlueChannel.BackgroundImage = global::PhotoShop.Properties.Resources.blueChannel;
                    cbBlueChannel.BackColor = Color.White;
                    cbBlueChannel.Text = "";
                }
                else
                {
                    cbBlueChannel.BackgroundImage = null;
                    cbBlueChannel.BackColor = Color.Blue;
                    cbBlueChannel.Text = "X";
                }

                pictureBox1.Image = yeniResim;
            }
        }

        private void btnRedChannel_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> blue = imgInput.Copy();
            Image<Bgr, Byte> green = imgInput.Copy();
            Image<Bgr, Byte> red = imgInput.Copy();
            Bgr tmp;
            double saveGreen;
            double saveRed;

            for (int ii = 0; ii < imgInput.Height; ii++)
            {
                for (int jj = 0; jj < imgInput.Width; jj++)
                {
                    tmp = imgInput[ii, jj];
                    saveGreen = tmp.Green;
                    saveRed = tmp.Red;

                    // Blue
                    tmp.Green = 0;
                    tmp.Red = 0;
                    blue[ii, jj] = tmp;

                    // Green
                    tmp.Green = saveGreen;
                    tmp.Blue = 0;
                    green[ii, jj] = tmp;

                    // Red
                    tmp.Red = saveRed;
                    tmp.Green = 0;
                    red[ii, jj] = tmp;
                }
            }

            pictureBox1.Image = red.Bitmap;
        }

        private void btnResize_Click(object sender1, EventArgs e1)
        {
            if (pictureBox1.Image != null)
            {
                Form formm = new Form();
                formm.Width = 280;
                formm.Height = 160;
                formm.Text = "Resmi Boyutlandır";
                Label textLabel = new Label() { Left = 1, Top = 20, Width = 75, Text = "Genişlik: " };
                TextBox textBox = new TextBox() { Left = 92, Top = 20, Width = 75, TabIndex = 0, TabStop = true };
                Label textLabel2 = new Label() { Left = 1, Top = 40, Width = 75, Text = "Uzunluk: " };
                TextBox textBox2 = new TextBox() { Left = 92, Top = 40, Width = 75, TabIndex = 1, TabStop = true };
                Button confirmation = new Button() { Text = "Tamam", Left = 16, Width = 80, Top = 88, TabIndex = 2, TabStop = true };

                textBox.Text = pictureBox1.Width + "";
                textBox2.Text = pictureBox1.Height + "";

                confirmation.Click += (sender, e) => { formm.Close(); };
                formm.Controls.Add(textLabel);
                formm.Controls.Add(textBox);
                formm.Controls.Add(textLabel2);
                formm.Controls.Add(textBox2);
                formm.Controls.Add(confirmation);
                formm.AcceptButton = confirmation;
                formm.StartPosition = FormStartPosition.CenterScreen;
                formm.ShowDialog();


                Bitmap yenidenBoyutlandirilmisResim = ResizeImage(pictureBox1.Image, Int32.Parse(textBox.Text), Int32.Parse(textBox2.Text));
                pictureBox1.Image = yenidenBoyutlandirilmisResim;
                imgInput.Bitmap = yenidenBoyutlandirilmisResim;

            }
        }

        private void resmiDondur()
        {
            int uzunluk = pictureBox1.Image.Height;
            int genislik = pictureBox1.Image.Width;

            var dondurululmusHali = new Bitmap(uzunluk, genislik);

            for (int i = 0; i < uzunluk; i++)
            {
                for (int j = 0; j < genislik; j++)
                {
                    Color p = imgInput.Bitmap.GetPixel(j, i);
                    dondurululmusHali.SetPixel(i, j, p);
                }
            }
            pictureBox1.Image = dondurululmusHali;
            imgInput.Bitmap = dondurululmusHali;
        }
        public Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void cbRedChannel_CheckedChanged(object sender, EventArgs e)
        {
            rengiDegistir();
        }

        private void cbGreenChannel_CheckedChanged(object sender, EventArgs e)
        {
            rengiDegistir();
        }

        private void cbBlueChannel_CheckedChanged(object sender, EventArgs e)
        {
            rengiDegistir();
        }
    }
}
