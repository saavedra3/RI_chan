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



        #region UI
        private void btn_EN_Click(object sender, EventArgs e)
        {
            @params.LGN = 1;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            @params.LGN = 2;
            this.Close();
        }
        #endregion
    }
}
