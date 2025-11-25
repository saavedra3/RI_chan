using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RI_chan.Main
{
    public partial class frm_Lang : Form
    {
        public frm_Lang()
        {
            InitializeComponent();
        }

        #region FUN
        private void StartMain()
        {
            frm_Main frm = new frm_Main();
            this.Hide();
            frm.Show();
        }
        #endregion








        #region UI
        private void btn_EN_Click(object sender, EventArgs e)
        {
            @params.LGN = 1;
            StartMain();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            @params.LGN = 2;
            StartMain();
        }
        private void btn_HI_Click(object sender, EventArgs e)
        {
            @params.LGN = 3;
            StartMain();
        }
        #endregion

        private void btn_PT1_Click(object sender, EventArgs e)
        {
            @params.LGN = 4;
            StartMain();
        }
    }
}
