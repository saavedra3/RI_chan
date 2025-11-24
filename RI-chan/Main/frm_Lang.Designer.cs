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
            SuspendLayout();
            // 
            // btn_EN
            // 
            btn_EN.AutoSize = true;
            btn_EN.Cursor = Cursors.Hand;
            btn_EN.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            btn_EN.ForeColor = Color.MediumPurple;
            btn_EN.Location = new Point(53, 50);
            btn_EN.Name = "btn_EN";
            btn_EN.Size = new Size(56, 38);
            btn_EN.TabIndex = 9;
            btn_EN.Text = "EN";
            btn_EN.TextAlign = ContentAlignment.MiddleRight;
            btn_EN.Click += btn_EN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold);
            label1.ForeColor = Color.MediumPurple;
            label1.Location = new Point(149, 50);
            label1.Name = "label1";
            label1.Size = new Size(53, 38);
            label1.TabIndex = 10;
            label1.Text = "ES";
            label1.TextAlign = ContentAlignment.MiddleRight;
            label1.Click += label1_Click;
            // 
            // cuiFormRounder1
            // 
            cuiFormRounder1.OutlineColor = Color.FromArgb(32, 128, 128, 128);
            cuiFormRounder1.Rounding = 20;
            cuiFormRounder1.TargetForm = this;
            // 
            // frm_Lang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 137);
            Controls.Add(label1);
            Controls.Add(btn_EN);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Lang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Langs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label btn_EN;
        private Label label1;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
    }
}