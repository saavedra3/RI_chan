namespace RI_chan.Main
{
    partial class frm_Lang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Lang));
            btn_EN = new Label();
            label1 = new Label();
            cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            btn_HI = new Label();
            btn_PT1 = new Label();
            SuspendLayout();
            // 
            // btn_EN
            // 
            btn_EN.Cursor = Cursors.Hand;
            btn_EN.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            btn_EN.ForeColor = Color.MediumPurple;
            btn_EN.Location = new Point(74, 38);
            btn_EN.Name = "btn_EN";
            btn_EN.Size = new Size(107, 38);
            btn_EN.TabIndex = 9;
            btn_EN.Text = "en-US";
            btn_EN.TextAlign = ContentAlignment.MiddleRight;
            btn_EN.Click += btn_EN_Click;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(74, 91);
            label1.Name = "label1";
            label1.Size = new Size(107, 38);
            label1.TabIndex = 10;
            label1.Text = "es-ES";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 20;
            cuiFormRounder1.TargetForm = this;
            // 
            // btn_HI
            // 
            btn_HI.Cursor = Cursors.Hand;
            btn_HI.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            btn_HI.ForeColor = Color.MediumPurple;
            btn_HI.Location = new Point(74, 148);
            btn_HI.Name = "btn_HI";
            btn_HI.Size = new Size(107, 38);
            btn_HI.TabIndex = 11;
            btn_HI.Text = "hi-IN";
            btn_HI.TextAlign = ContentAlignment.MiddleRight;
            btn_HI.Click += btn_HI_Click;
            // 
            // btn_PT1
            // 
            btn_PT1.Cursor = Cursors.Hand;
            btn_PT1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            btn_PT1.ForeColor = Color.MediumPurple;
            btn_PT1.Location = new Point(74, 198);
            btn_PT1.Name = "btn_PT1";
            btn_PT1.Size = new Size(107, 38);
            btn_PT1.TabIndex = 12;
            btn_PT1.Text = "pt-BR";
            btn_PT1.TextAlign = ContentAlignment.MiddleRight;
            btn_PT1.Click += btn_PT1_Click;
            // 
            // frm_Lang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 269);
            Controls.Add(btn_PT1);
            Controls.Add(btn_HI);
            Controls.Add(label1);
            Controls.Add(btn_EN);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Lang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Langs";
            ResumeLayout(false);
        }

        #endregion

        private Label btn_EN;
        private Label label1;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private Label btn_HI;
        private Label btn_PT1;
    }
}