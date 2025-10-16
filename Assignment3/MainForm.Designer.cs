namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnDeal = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            pb1 = new PictureBox();
            pb2 = new PictureBox();
            pb3 = new PictureBox();
            pb4 = new PictureBox();
            pb5 = new PictureBox();
            chkKeep1 = new CheckBox();
            chkKeep2 = new CheckBox();
            chkKeep3 = new CheckBox();
            chkKeep4 = new CheckBox();
            chkKeep5 = new CheckBox();
            imglstCards = new ImageList(components);
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb5).BeginInit();
            SuspendLayout();
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(95, 88);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(152, 93);
            btnDeal.TabIndex = 0;
            btnDeal.Text = "&Deal";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += btnDeal_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(796, 88);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 93);
            btnSave.TabIndex = 1;
            btnSave.Text = "&Save Hand";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(1025, 88);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(152, 93);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "&Load Hand";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // pb1
            // 
            pb1.Location = new Point(97, 443);
            pb1.MaximumSize = new Size(150, 250);
            pb1.MinimumSize = new Size(150, 250);
            pb1.Name = "pb1";
            pb1.Size = new Size(150, 250);
            pb1.TabIndex = 3;
            pb1.TabStop = false;
            // 
            // pb2
            // 
            pb2.Location = new Point(316, 443);
            pb2.MaximumSize = new Size(150, 250);
            pb2.MinimumSize = new Size(150, 250);
            pb2.Name = "pb2";
            pb2.Size = new Size(150, 250);
            pb2.SizeMode = PictureBoxSizeMode.AutoSize;
            pb2.TabIndex = 4;
            pb2.TabStop = false;
            // 
            // pb3
            // 
            pb3.Location = new Point(556, 443);
            pb3.MaximumSize = new Size(150, 250);
            pb3.MinimumSize = new Size(150, 250);
            pb3.Name = "pb3";
            pb3.Size = new Size(150, 250);
            pb3.SizeMode = PictureBoxSizeMode.AutoSize;
            pb3.TabIndex = 5;
            pb3.TabStop = false;
            // 
            // pb4
            // 
            pb4.Location = new Point(810, 443);
            pb4.MaximumSize = new Size(150, 250);
            pb4.MinimumSize = new Size(150, 250);
            pb4.Name = "pb4";
            pb4.Size = new Size(150, 250);
            pb4.SizeMode = PictureBoxSizeMode.AutoSize;
            pb4.TabIndex = 6;
            pb4.TabStop = false;
            // 
            // pb5
            // 
            pb5.Location = new Point(1040, 443);
            pb5.MaximumSize = new Size(150, 250);
            pb5.MinimumSize = new Size(150, 250);
            pb5.Name = "pb5";
            pb5.Size = new Size(150, 250);
            pb5.SizeMode = PictureBoxSizeMode.AutoSize;
            pb5.TabIndex = 7;
            pb5.TabStop = false;
            // 
            // chkKeep1
            // 
            chkKeep1.AutoSize = true;
            chkKeep1.Location = new Point(142, 348);
            chkKeep1.Name = "chkKeep1";
            chkKeep1.Size = new Size(92, 29);
            chkKeep1.TabIndex = 8;
            chkKeep1.Text = "Keep &1";
            chkKeep1.UseVisualStyleBackColor = true;
            // 
            // chkKeep2
            // 
            chkKeep2.AutoSize = true;
            chkKeep2.Location = new Point(353, 347);
            chkKeep2.Name = "chkKeep2";
            chkKeep2.Size = new Size(92, 29);
            chkKeep2.TabIndex = 9;
            chkKeep2.Text = "Keep &2";
            chkKeep2.UseVisualStyleBackColor = true;
            // 
            // chkKeep3
            // 
            chkKeep3.AutoSize = true;
            chkKeep3.Location = new Point(593, 348);
            chkKeep3.Name = "chkKeep3";
            chkKeep3.Size = new Size(92, 29);
            chkKeep3.TabIndex = 10;
            chkKeep3.Text = "Keep &3";
            chkKeep3.UseVisualStyleBackColor = true;
            // 
            // chkKeep4
            // 
            chkKeep4.AutoSize = true;
            chkKeep4.Location = new Point(844, 348);
            chkKeep4.Name = "chkKeep4";
            chkKeep4.Size = new Size(92, 29);
            chkKeep4.TabIndex = 11;
            chkKeep4.Text = "Keep &4";
            chkKeep4.UseVisualStyleBackColor = true;
            // 
            // chkKeep5
            // 
            chkKeep5.AutoSize = true;
            chkKeep5.Location = new Point(1063, 347);
            chkKeep5.Name = "chkKeep5";
            chkKeep5.Size = new Size(92, 29);
            chkKeep5.TabIndex = 12;
            chkKeep5.Text = "Keep &5";
            chkKeep5.UseVisualStyleBackColor = true;
            // 
            // imglstCards
            // 
            imglstCards.ColorDepth = ColorDepth.Depth32Bit;
            imglstCards.ImageStream = (ImageListStreamer)resources.GetObject("imglstCards.ImageStream");
            imglstCards.TransparentColor = Color.Transparent;
            imglstCards.Images.SetKeyName(0, "p0.png");
            imglstCards.Images.SetKeyName(1, "p1.png");
            imglstCards.Images.SetKeyName(2, "p2.png");
            imglstCards.Images.SetKeyName(3, "p3.png");
            imglstCards.Images.SetKeyName(4, "p4.png");
            imglstCards.Images.SetKeyName(5, "p5.png");
            imglstCards.Images.SetKeyName(6, "p6.png");
            imglstCards.Images.SetKeyName(7, "p7.png");
            imglstCards.Images.SetKeyName(8, "p8.png");
            imglstCards.Images.SetKeyName(9, "p9.png");
            imglstCards.Images.SetKeyName(10, "p10.png");
            imglstCards.Images.SetKeyName(11, "p11.png");
            imglstCards.Images.SetKeyName(12, "p12.png");
            imglstCards.Images.SetKeyName(13, "p13.png");
            imglstCards.Images.SetKeyName(14, "p14.png");
            imglstCards.Images.SetKeyName(15, "p15.png");
            imglstCards.Images.SetKeyName(16, "p16.png");
            imglstCards.Images.SetKeyName(17, "p17.png");
            imglstCards.Images.SetKeyName(18, "p18.png");
            imglstCards.Images.SetKeyName(19, "p19.png");
            imglstCards.Images.SetKeyName(20, "p20.png");
            imglstCards.Images.SetKeyName(21, "p21.png");
            imglstCards.Images.SetKeyName(22, "p22.png");
            imglstCards.Images.SetKeyName(23, "p23.png");
            imglstCards.Images.SetKeyName(24, "p24.png");
            imglstCards.Images.SetKeyName(25, "p25.png");
            imglstCards.Images.SetKeyName(26, "p26.png");
            imglstCards.Images.SetKeyName(27, "p27.png");
            imglstCards.Images.SetKeyName(28, "p28.png");
            imglstCards.Images.SetKeyName(29, "p29.png");
            imglstCards.Images.SetKeyName(30, "p30.png");
            imglstCards.Images.SetKeyName(31, "p31.png");
            imglstCards.Images.SetKeyName(32, "p32.png");
            imglstCards.Images.SetKeyName(33, "p33.png");
            imglstCards.Images.SetKeyName(34, "p34.png");
            imglstCards.Images.SetKeyName(35, "p35.png");
            imglstCards.Images.SetKeyName(36, "p36.png");
            imglstCards.Images.SetKeyName(37, "p37.png");
            imglstCards.Images.SetKeyName(38, "p38.png");
            imglstCards.Images.SetKeyName(39, "p39.png");
            imglstCards.Images.SetKeyName(40, "p40.png");
            imglstCards.Images.SetKeyName(41, "p41.png");
            imglstCards.Images.SetKeyName(42, "p42.png");
            imglstCards.Images.SetKeyName(43, "p43.png");
            imglstCards.Images.SetKeyName(44, "p44.png");
            imglstCards.Images.SetKeyName(45, "p45.png");
            imglstCards.Images.SetKeyName(46, "p46.png");
            imglstCards.Images.SetKeyName(47, "p47.png");
            imglstCards.Images.SetKeyName(48, "p48.png");
            imglstCards.Images.SetKeyName(49, "p49.png");
            imglstCards.Images.SetKeyName(50, "p50.png");
            imglstCards.Images.SetKeyName(51, "p51.png");
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 744);
            Controls.Add(chkKeep5);
            Controls.Add(chkKeep4);
            Controls.Add(chkKeep3);
            Controls.Add(chkKeep2);
            Controls.Add(chkKeep1);
            Controls.Add(pb5);
            Controls.Add(pb4);
            Controls.Add(pb3);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnDeal);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1300, 800);
            MinimumSize = new Size(1300, 800);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeal;
        private Button btnSave;
        private Button btnLoad;
        private PictureBox pb1;
        private PictureBox pb2;
        private PictureBox pb3;
        private PictureBox pb4;
        private PictureBox pb5;
        private CheckBox chkKeep1;
        private CheckBox chkKeep2;
        private CheckBox chkKeep3;
        private CheckBox chkKeep4;
        private CheckBox chkKeep5;
        private ImageList imglstCards;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
