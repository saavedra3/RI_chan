using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RI_chan.Langs;

namespace RI_chan.About
{
    public partial class frm_About : Form
    {
        public frm_About()
        {
            InitializeComponent();
        }


        #region VAR
        public static void OpenLink(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("URL cannot be empty.", nameof(url));

            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "...?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error opening link: " + ex.Message);
            }
        }

        public static async Task FadeInAsync(Form form, int intervalMs)
        {
            if (form == null) throw new ArgumentNullException(nameof(form));
            if (intervalMs <= 0) intervalMs = 50; // valor mínimo de seguridad

            form.Opacity = 0;   // empieza invisible
            form.Show();        // mostrar el form

            while (form.Opacity < 1.0)
            {
                form.Opacity += 0.05; // incremento de opacidad (5%)
                if (form.Opacity > 1.0)
                    form.Opacity = 1.0;

                await Task.Delay(intervalMs); // controla la velocidad
            }
        }


        #endregion




        #region FRM
        private async void frm_About_Load(object sender, EventArgs e)
        {
            tx_version.Text = ($"V {Assembly.GetExecutingAssembly().GetName().Version.ToString()}");
            lb_at1.Text = Lang.AboutText1;
            lb_at2.Text = Lang.AboutText2;
            lb_oc.Text = Lang.OCText;
            await FadeInAsync(this, 60);
        }
        #endregion






        #region UI
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_telegram_Click(object sender, EventArgs e)
        {
            OpenLink("https://t.me/saavedra3");
        }

        private void llb_pld_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://github.com/ssut/payload-dumper-go/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink("https://developer.android.com/tools/releases/platform-tools?hl=es-419");
        }
        private void btn_github_Click(object sender, EventArgs e)
        {
            OpenLink("https://github.com/saavedra3");
        }
        #endregion





    }
}
