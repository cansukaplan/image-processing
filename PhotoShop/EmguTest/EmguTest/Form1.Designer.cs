using System; 

namespace PhotoShop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private static String version = "V1.5";


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDosyaAc = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnMirrorLeft = new System.Windows.Forms.Button();
            this.btnMirorRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnReOpen = new System.Windows.Forms.Button();
            this.btnGreyScalling = new System.Windows.Forms.Button();
            this.cbRedChannel = new System.Windows.Forms.CheckBox();
            this.cbGreenChannel = new System.Windows.Forms.CheckBox();
            this.cbBlueChannel = new System.Windows.Forms.CheckBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 291);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackgroundImage = global::PhotoShop.Properties.Resources.orange_background;
            this.flowLayoutPanel2.Controls.Add(this.btnDosyaAc);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Controls.Add(this.btnHistogram);
            this.flowLayoutPanel2.Controls.Add(this.btnInvert);
            this.flowLayoutPanel2.Controls.Add(this.btnMirrorLeft);
            this.flowLayoutPanel2.Controls.Add(this.btnMirorRight);
            this.flowLayoutPanel2.Controls.Add(this.btnRotateLeft);
            this.flowLayoutPanel2.Controls.Add(this.btnRotateRight);
            this.flowLayoutPanel2.Controls.Add(this.btnReOpen);
            this.flowLayoutPanel2.Controls.Add(this.btnGreyScalling);
            this.flowLayoutPanel2.Controls.Add(this.cbRedChannel);
            this.flowLayoutPanel2.Controls.Add(this.cbGreenChannel);
            this.flowLayoutPanel2.Controls.Add(this.cbBlueChannel);
            this.flowLayoutPanel2.Controls.Add(this.btnResize);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(899, 46);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.BackColor = System.Drawing.Color.White;
            this.btnDosyaAc.Image = global::PhotoShop.Properties.Resources.folder_open;
            this.btnDosyaAc.Location = new System.Drawing.Point(3, 3);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(40, 40);
            this.btnDosyaAc.TabIndex = 14;
            this.btnDosyaAc.Tag = "";
            this.btnDosyaAc.UseVisualStyleBackColor = false;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PhotoShop.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(49, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Tag = "";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHistogram
            // 
            this.btnHistogram.BackColor = System.Drawing.Color.White;
            this.btnHistogram.Image = global::PhotoShop.Properties.Resources.histogram;
            this.btnHistogram.Location = new System.Drawing.Point(95, 3);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(40, 40);
            this.btnHistogram.TabIndex = 0;
            this.btnHistogram.Tag = "";
            this.btnHistogram.UseVisualStyleBackColor = false;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.White;
            this.btnInvert.Image = global::PhotoShop.Properties.Resources.invert;
            this.btnInvert.Location = new System.Drawing.Point(141, 3);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(40, 40);
            this.btnInvert.TabIndex = 1;
            this.btnInvert.Tag = "";
            this.btnInvert.UseVisualStyleBackColor = false;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnMirrorLeft
            // 
            this.btnMirrorLeft.BackColor = System.Drawing.Color.White;
            this.btnMirrorLeft.Image = global::PhotoShop.Properties.Resources.miror;
            this.btnMirrorLeft.Location = new System.Drawing.Point(187, 3);
            this.btnMirrorLeft.Name = "btnMirrorLeft";
            this.btnMirrorLeft.Size = new System.Drawing.Size(40, 40);
            this.btnMirrorLeft.TabIndex = 2;
            this.btnMirrorLeft.Tag = "";
            this.btnMirrorLeft.UseVisualStyleBackColor = false;
            this.btnMirrorLeft.Click += new System.EventHandler(this.btnMirrorLeft_Click);
            // 
            // btnMirorRight
            // 
            this.btnMirorRight.BackColor = System.Drawing.Color.White;
            this.btnMirorRight.Image = global::PhotoShop.Properties.Resources.mirorRight;
            this.btnMirorRight.Location = new System.Drawing.Point(233, 3);
            this.btnMirorRight.Name = "btnMirorRight";
            this.btnMirorRight.Size = new System.Drawing.Size(40, 40);
            this.btnMirorRight.TabIndex = 3;
            this.btnMirorRight.Tag = "";
            this.btnMirorRight.UseVisualStyleBackColor = false;
            this.btnMirorRight.Click += new System.EventHandler(this.btnMirorRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.BackColor = System.Drawing.Color.White;
            this.btnRotateLeft.Image = global::PhotoShop.Properties.Resources.rotate_left;
            this.btnRotateLeft.Location = new System.Drawing.Point(279, 3);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(40, 40);
            this.btnRotateLeft.TabIndex = 4;
            this.btnRotateLeft.Tag = "";
            this.btnRotateLeft.UseVisualStyleBackColor = false;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.BackColor = System.Drawing.Color.White;
            this.btnRotateRight.Image = global::PhotoShop.Properties.Resources.rotate_right;
            this.btnRotateRight.Location = new System.Drawing.Point(325, 3);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(40, 40);
            this.btnRotateRight.TabIndex = 5;
            this.btnRotateRight.Tag = "";
            this.btnRotateRight.UseVisualStyleBackColor = false;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnReOpen
            // 
            this.btnReOpen.BackColor = System.Drawing.Color.White;
            this.btnReOpen.Image = global::PhotoShop.Properties.Resources.reopen;
            this.btnReOpen.Location = new System.Drawing.Point(371, 3);
            this.btnReOpen.Name = "btnReOpen";
            this.btnReOpen.Size = new System.Drawing.Size(40, 40);
            this.btnReOpen.TabIndex = 8;
            this.btnReOpen.Tag = "";
            this.btnReOpen.UseVisualStyleBackColor = false;
            this.btnReOpen.Click += new System.EventHandler(this.btnReOpen_Click);
            // 
            // btnGreyScalling
            // 
            this.btnGreyScalling.BackColor = System.Drawing.Color.White;
            this.btnGreyScalling.Image = global::PhotoShop.Properties.Resources.grayScale;
            this.btnGreyScalling.Location = new System.Drawing.Point(417, 3);
            this.btnGreyScalling.Name = "btnGreyScalling";
            this.btnGreyScalling.Size = new System.Drawing.Size(40, 40);
            this.btnGreyScalling.TabIndex = 9;
            this.btnGreyScalling.Tag = "";
            this.btnGreyScalling.UseVisualStyleBackColor = false;
            this.btnGreyScalling.Click += new System.EventHandler(this.btnGreyScalling_Click);
            // 
            // cbRedChannel
            // 
            this.cbRedChannel.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbRedChannel.BackgroundImage = global::PhotoShop.Properties.Resources.redChannel1;
            this.cbRedChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbRedChannel.Checked = true;
            this.cbRedChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRedChannel.Location = new System.Drawing.Point(463, 3);
            this.cbRedChannel.Name = "cbRedChannel";
            this.cbRedChannel.Size = new System.Drawing.Size(40, 40);
            this.cbRedChannel.TabIndex = 20;
            this.cbRedChannel.Text = "                               ";
            this.cbRedChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbRedChannel.UseVisualStyleBackColor = true;
            this.cbRedChannel.CheckedChanged += new System.EventHandler(this.cbRedChannel_CheckedChanged);
            // 
            // cbGreenChannel
            // 
            this.cbGreenChannel.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbGreenChannel.BackgroundImage = global::PhotoShop.Properties.Resources.greenChannel;
            this.cbGreenChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbGreenChannel.Checked = true;
            this.cbGreenChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGreenChannel.Location = new System.Drawing.Point(509, 3);
            this.cbGreenChannel.Name = "cbGreenChannel";
            this.cbGreenChannel.Size = new System.Drawing.Size(40, 40);
            this.cbGreenChannel.TabIndex = 18;
            this.cbGreenChannel.Text = "                               ";
            this.cbGreenChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbGreenChannel.UseVisualStyleBackColor = true;
            this.cbGreenChannel.CheckedChanged += new System.EventHandler(this.cbGreenChannel_CheckedChanged);
            // 
            // cbBlueChannel
            // 
            this.cbBlueChannel.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBlueChannel.BackgroundImage = global::PhotoShop.Properties.Resources.blueChannel;
            this.cbBlueChannel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cbBlueChannel.Checked = true;
            this.cbBlueChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBlueChannel.Location = new System.Drawing.Point(555, 3);
            this.cbBlueChannel.Name = "cbBlueChannel";
            this.cbBlueChannel.Size = new System.Drawing.Size(40, 40);
            this.cbBlueChannel.TabIndex = 17;
            this.cbBlueChannel.Text = "                               ";
            this.cbBlueChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbBlueChannel.UseVisualStyleBackColor = true;
            this.cbBlueChannel.CheckedChanged += new System.EventHandler(this.cbBlueChannel_CheckedChanged);
            // 
            // btnResize
            // 
            this.btnResize.BackColor = System.Drawing.Color.White;
            this.btnResize.Image = global::PhotoShop.Properties.Resources.resize;
            this.btnResize.Location = new System.Drawing.Point(601, 3);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(40, 40);
            this.btnResize.TabIndex = 16;
            this.btnResize.Tag = "";
            this.btnResize.UseVisualStyleBackColor = false;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::PhotoShop.Properties.Resources.orange_background;
            this.menuStrip1.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(899, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.kaydetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileToolStripMenuItem.Text = "Dosya";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Aç";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Çıkış";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(899, 361);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Görüntü İşleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void addToolTips()
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnHistogram, "Histogramı Göster");
            ToolTip1.SetToolTip(this.btnInvert , "Tersleme İşlemini Yap");

            ToolTip1.SetToolTip(this.btnMirrorLeft, "Sola Aynala");
            ToolTip1.SetToolTip(this.btnMirorRight, "Sağa Aynala");

            ToolTip1.SetToolTip(this.btnRotateLeft, "Sola Döndür");
            ToolTip1.SetToolTip(this.btnRotateRight, "Sağa Döndür");
 

            ToolTip1.SetToolTip(this.btnReOpen, "Resmin Orjinalini Aç");

            ToolTip1.SetToolTip(this.btnGreyScalling, "Gri Tonlama Yap");

            ToolTip1.SetToolTip(this.cbRedChannel, "Kırmızı Renk Kanallarını Göster");
            ToolTip1.SetToolTip(this.cbGreenChannel, "Yeşil Renk Kanallarını Göster");
            ToolTip1.SetToolTip(this.cbBlueChannel, "Mavi Renk Kanallarını Göster");
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnMirrorLeft;
        private System.Windows.Forms.Button btnMirorRight;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Button btnGreyScalling;
        private System.Windows.Forms.Button btnReOpen;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.CheckBox cbBlueChannel;
        private System.Windows.Forms.CheckBox cbGreenChannel;
        private System.Windows.Forms.CheckBox cbRedChannel;
    }
}

