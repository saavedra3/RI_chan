namespace RI_chan.Main
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            dropper = new CuoreUI.Controls.cuiFileDropper();
            pictureBox1 = new PictureBox();
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            pictureBox2 = new PictureBox();
            btn_Exit = new CuoreUI.Controls.cuiButton();
            lb_intro = new Label();
            pnl_load = new Panel();
            cuiSpinner1 = new CuoreUI.Controls.cuiSpinner();
            btn_help = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnl_load.SuspendLayout();
            SuspendLayout();
            // 
            // dropper
            // 
            dropper.AllowDrop = true;
            dropper.BackColor = Color.White;
            dropper.DashedOutline = true;
            dropper.DashedOutlineColor = Color.FromArgb(128, 128, 255);
            dropper.DashLength = 8;
            dropper.Filter = "";
            dropper.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dropper.ForeColor = Color.FromArgb(64, 64, 64);
            dropper.HoverContent = "Release to drop";
            dropper.HoverForeColor = Color.FromArgb(128, 128, 128, 128);
            dropper.HoverUploadForeColor = Color.FromArgb(255, 106, 0);
            dropper.Image = Properties.Resources.archivo_zip1;
            dropper.ImagePadding = 2;
            dropper.ImageSize = new Size(50, 40);
            dropper.ImageTint = Color.Gray;
            dropper.Location = new Point(318, 161);
            dropper.Multiselect = false;
            dropper.Name = "dropper";
            dropper.NormalContent = "Drop file here";
            dropper.NormalForeColor = Color.FromArgb(64, 64, 64);
            dropper.NormalUploadForeColor = Color.FromArgb(192, 192, 255);
            dropper.OutlineThickness = 1F;
            dropper.PanelColor = Color.FromArgb(16, 255, 255, 255);
            dropper.Rounding = new Padding(15);
            dropper.Size = new Size(335, 309);
            dropper.TabIndex = 0;
            dropper.Text = "FileDropper";
            dropper.UploadContent = "Click to upload";
            dropper.UploadWithClick = true;
            dropper.FileDropped += dropper_FileDropped;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ri2;
            pictureBox1.Location = new Point(-80, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 415);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 20;
            cuiFormRounder1.TargetForm = this;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ri_chan_titulo;
            pictureBox2.Location = new Point(-16, -21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 131);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
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
            btn_Exit.TabIndex = 4;
            btn_Exit.TextAlignment = StringAlignment.Center;
            btn_Exit.TextOffset = new Point(0, 0);
            btn_Exit.Click += btn_Exit_Click;
            // 
            // lb_intro
            // 
            lb_intro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lb_intro.Location = new Point(332, 73);
            lb_intro.Name = "lb_intro";
            lb_intro.Size = new Size(308, 78);
            lb_intro.TabIndex = 5;
            lb_intro.Text = "...";
            lb_intro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_load
            // 
            pnl_load.Controls.Add(cuiSpinner1);
            pnl_load.Location = new Point(331, 174);
            pnl_load.Name = "pnl_load";
            pnl_load.Size = new Size(310, 283);
            pnl_load.TabIndex = 6;
            // 
            // cuiSpinner1
            // 
            cuiSpinner1.ArcColor = Color.FromArgb(91, 110, 166);
            cuiSpinner1.Location = new Point(77, 64);
            cuiSpinner1.Name = "cuiSpinner1";
            cuiSpinner1.RingColor = Color.FromArgb(64, 128, 128, 128);
            cuiSpinner1.RotateSpeed = 5F;
            cuiSpinner1.Rotation = 352.3146F;
            cuiSpinner1.Size = new Size(167, 163);
            cuiSpinner1.TabIndex = 0;
            cuiSpinner1.Text = "cuiSpinner1";
            cuiSpinner1.Thickness = 10F;
            // 
            // btn_help
            // 
            btn_help.AutoSize = true;
            btn_help.Cursor = Cursors.Hand;
            btn_help.Font = new Font("Microsoft Sans Serif", 20F);
            btn_help.ForeColor = Color.LightSteelBlue;
            btn_help.Location = new Point(572, 22);
            btn_help.Name = "btn_help";
            btn_help.Size = new Size(29, 31);
            btn_help.TabIndex = 7;
            btn_help.Text = "?";
            btn_help.Click += btn_help_Click;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(671, 482);
            Controls.Add(btn_help);
            Controls.Add(pnl_load);
            Controls.Add(lb_intro);
            Controls.Add(dropper);
            Controls.Add(btn_Exit);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Main";
            Load += frm_Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnl_load.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiFileDropper dropper;
        private PictureBox pictureBox1;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private PictureBox pictureBox2;
        private CuoreUI.Controls.cuiButton btn_Exit;
        private Label lb_intro;
        private Panel pnl_load;
        private CuoreUI.Controls.cuiSpinner cuiSpinner1;
        private Label btn_help;
    }
}