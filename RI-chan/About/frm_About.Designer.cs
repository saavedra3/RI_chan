namespace RI_chan.About
{
    partial class frm_About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_About));
            btn_Exit = new CuoreUI.Controls.cuiButton();
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tx_version = new Label();
            lb_at1 = new Label();
            lb_at2 = new Label();
            label1 = new Label();
            llb_pld = new LinkLabel();
            lb_oc = new Label();
            linkLabel1 = new LinkLabel();
            btn_telegram = new PictureBox();
            btn_github = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_telegram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_github).BeginInit();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.Transparent;
            btn_Exit.CheckButton = false;
            btn_Exit.Checked = false;
            btn_Exit.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_Exit.CheckedForeColor = Color.White;
            btn_Exit.CheckedImageTint = Color.White;
            btn_Exit.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_Exit.Content = "X";
            btn_Exit.DialogResult = DialogResult.None;
            btn_Exit.Font = new Font("Comic Sans MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Exit.ForeColor = Color.WhiteSmoke;
            btn_Exit.HoverBackground = Color.FromArgb(113, 107, 184);
            btn_Exit.HoverForeColor = Color.White;
            btn_Exit.HoverImageTint = Color.White;
            btn_Exit.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_Exit.Image = null;
            btn_Exit.ImageAutoCenter = true;
            btn_Exit.ImageExpand = new Point(0, 0);
            btn_Exit.ImageOffset = new Point(0, 0);
            btn_Exit.Location = new Point(609, 12);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.NormalBackground = Color.FromArgb(133, 117, 191);
            btn_Exit.NormalForeColor = Color.WhiteSmoke;
            btn_Exit.NormalImageTint = Color.White;
            btn_Exit.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_Exit.OutlineThickness = 1F;
            btn_Exit.PressedBackground = Color.FromArgb(133, 117, 191);
            btn_Exit.PressedForeColor = Color.Gray;
            btn_Exit.PressedImageTint = Color.White;
            btn_Exit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_Exit.Rounding = new Padding(8);
            btn_Exit.Size = new Size(50, 50);
            btn_Exit.TabIndex = 5;
            btn_Exit.TextAlignment = StringAlignment.Center;
            btn_Exit.TextOffset = new Point(0, 0);
            btn_Exit.Click += btn_Exit_Click;
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 20;
            cuiFormRounder1.TargetForm = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ri1;
            pictureBox1.Location = new Point(-23, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 497);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ri_chan_titulo;
            pictureBox2.Location = new Point(420, 442);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(178, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // tx_version
            // 
            tx_version.AutoSize = true;
            tx_version.Font = new Font("Comic Sans MS", 14F);
            tx_version.ForeColor = Color.MediumPurple;
            tx_version.Location = new Point(557, 450);
            tx_version.Name = "tx_version";
            tx_version.Size = new Size(56, 26);
            tx_version.TabIndex = 8;
            tx_version.Text = "V - 0";
            tx_version.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lb_at1
            // 
            lb_at1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_at1.ForeColor = Color.DarkOrchid;
            lb_at1.Location = new Point(336, 68);
            lb_at1.Name = "lb_at1";
            lb_at1.Size = new Size(323, 130);
            lb_at1.TabIndex = 9;
            lb_at1.Text = "No puedo hacerlo todo por ti.\r\nDebes colocar el dispositivo en modo\r\nADB Sideload\r\n\r\nY no voy a continuar hasta que lo hagas.";
            lb_at1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_at2
            // 
            lb_at2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            lb_at2.ForeColor = Color.Thistle;
            lb_at2.Location = new Point(336, 198);
            lb_at2.Name = "lb_at2";
            lb_at2.Size = new Size(323, 130);
            lb_at2.TabIndex = 10;
            lb_at2.Text = "No puedo hacerlo todo por ti.\r\nDebes colocar el dispositivo en modo\r\nADB Sideload\r\n\r\nY no voy a continuar hasta que lo hagas.";
            lb_at2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(484, 30);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 11;
            label1.Text = "Saavedra3";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // llb_pld
            // 
            llb_pld.Font = new Font("Segoe UI", 12F);
            llb_pld.LinkColor = Color.FromArgb(128, 128, 255);
            llb_pld.Location = new Point(418, 377);
            llb_pld.Name = "llb_pld";
            llb_pld.Size = new Size(149, 20);
            llb_pld.TabIndex = 13;
            llb_pld.TabStop = true;
            llb_pld.Text = "Payload Dumper Go";
            llb_pld.TextAlign = ContentAlignment.MiddleCenter;
            llb_pld.LinkClicked += llb_pld_LinkClicked;
            // 
            // lb_oc
            // 
            lb_oc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_oc.ForeColor = Color.FromArgb(128, 128, 255);
            lb_oc.Location = new Point(418, 341);
            lb_oc.Name = "lb_oc";
            lb_oc.Size = new Size(149, 39);
            lb_oc.TabIndex = 14;
            lb_oc.Text = "Otros Creditos:";
            lb_oc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(418, 401);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(149, 20);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Platform Tools";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btn_telegram
            // 
            btn_telegram.Cursor = Cursors.Hand;
            btn_telegram.Image = Properties.Resources.Telegram_logo_icon_svg;
            btn_telegram.Location = new Point(446, 26);
            btn_telegram.Name = "btn_telegram";
            btn_telegram.Size = new Size(37, 27);
            btn_telegram.SizeMode = PictureBoxSizeMode.Zoom;
            btn_telegram.TabIndex = 12;
            btn_telegram.TabStop = false;
            btn_telegram.Click += btn_telegram_Click;
            // 
            // btn_github
            // 
            btn_github.Cursor = Cursors.Hand;
            btn_github.Image = Properties.Resources._25231;
            btn_github.Location = new Point(403, 26);
            btn_github.Name = "btn_github";
            btn_github.Size = new Size(37, 27);
            btn_github.SizeMode = PictureBoxSizeMode.Zoom;
            btn_github.TabIndex = 16;
            btn_github.TabStop = false;
            btn_github.Click += btn_github_Click;
            // 
            // frm_About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(671, 482);
            Controls.Add(btn_github);
            Controls.Add(linkLabel1);
            Controls.Add(lb_oc);
            Controls.Add(llb_pld);
            Controls.Add(btn_telegram);
            Controls.Add(label1);
            Controls.Add(lb_at2);
            Controls.Add(lb_at1);
            Controls.Add(tx_version);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Exit);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            Load += frm_About_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_telegram).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_github).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.Controls.cuiButton btn_Exit;
        private PictureBox pictureBox1;
        private Label tx_version;
        private PictureBox pictureBox2;
        private Label label1;
        private Label lb_at2;
        private Label lb_at1;
        private LinkLabel llb_pld;
        private LinkLabel linkLabel1;
        private Label lb_oc;
        private PictureBox btn_telegram;
        private PictureBox btn_github;
    }
}