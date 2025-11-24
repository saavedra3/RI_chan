using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RI_chan.About;
using RI_chan.Langs;
using RI_chan.Process;

namespace RI_chan.Main
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        #region VAR
        fun_Main fn = new fun_Main();
        #endregion
















        #region FUN
        private void LANG()
        {
            if (@params.LGN == 1)
            {
                fn.SetLanguage(typeof(EN));
            }
            else if (@params.LGN == 2)
            {
                fn.SetLanguage(typeof(ES));
            }  
        }
        private void START()
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
            frm_Lang frm = new frm_Lang();
            frm.ShowDialog();
            LANG();
            this.Show();
            this.WindowState = FormWindowState.Normal;
            pnl_load.Visible = false;
            this.Text = Lang.MainTitle;
            dropper.UploadContent = Lang.DropperClickToUpload;
            dropper.NormalContent = Lang.DropperNormalContent;
            dropper.HoverContent = Lang.DropperHoverContent;
            lb_intro.Text = Lang.InfoText1;
        }

        #endregion





















        #region FRM
        private void frm_Main_Load(object sender, EventArgs e)
        {
            START();
        }
        #endregion























        #region UI


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Lang.ExitConfirm, "RI-chan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion


        private async void dropper_FileDropped(object sender, CuoreUI.Controls.FileDroppedEventArgs e)
        {
            pnl_load.Visible = true;
            await Task.Delay(2000);
            var URLFile = fn.GetROMFile(dropper);
            if (fn.VerifyPayload(URLFile))
            {
                frm_Process frm = new frm_Process();
                frm.URLFile = URLFile;
                frm.ShowDialog();
                this.Show();
                START();
            }
            pnl_load.Visible = false;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_About frm = new frm_About();
            frm.ShowDialog();
            this.Show();
        }
    }
}
