using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RI_chan.Langs;
using RI_chan.Main;
using SiticoneNetCoreUI;

namespace RI_chan.Process
{
    public partial class frm_Process : Form
    {
        public frm_Process()
        {
            InitializeComponent();
        }


        #region VAR
        fun_Process fn = new fun_Process();
        public string URLFile { get; set; }
        public string IMGsPatch = @"pdg/output";
        #endregion















        #region FUN
        private void PrepareForFlashROM()
        {
            Task.Delay(4000);
            pb_sideload.Image = Properties.Resources.Waiting;
            lb_sideload.Text = Lang.WaitingForSideload;
            Task.Delay(2000);
            pnl_waitSideload.Visible = true;
            Tadb.Start();
        }
        private async void FlashROM()
        {
            Steps.StepSubtitles.Add("...");
            bar.Visible = true;
            if (await fn.SideloadingAsync(URLFile, bar))
            {
                Steps.CurrentStep = 6;
                pnl_finish.Visible = true;
            }
            else
            {
                ErrorAndCancel();
            }
        }
        private void ErrorAndCancel()
        {
            lb_Error.Text = Lang.Error1;
            pnl_error.Visible = true;
            pb_error.Image = Properties.Resources.ERR_all;
        }
        private async void START()
        {
            frm_Main frm = new frm_Main();
            frm.Hide();
            bar.Visible = false;
            pnl_waitSideload.Visible = false;
            pnl_error.Visible = false;
            pnl_finish.Visible = false;
            lb_process.Text = Lang.InfoText2;
            Steps.CurrentStep = -1;
            Steps.StepTitles.Clear();
            Steps.StepSubtitles.Clear();
            Steps.StepTitles.Add(Lang.StepTitle1);
            Steps.StepTitles.Add(Lang.StepTitle2);
            Steps.StepTitles.Add(Lang.StepTitle3);
            Steps.StepTitles.Add(Lang.StepTitle4);
            Steps.StepTitles.Add(Lang.StepTitle5);
            Steps.StepTitles.Add(Lang.StepTitle6);
            Steps.StepTitles.Add(Lang.StepTitle7);
            btn_Reload.Content = Lang.ReloadButtonText;
            lb_finished.Text = Lang.Finished;
            btn_exit.Content = Lang.GoToStart;
            await Task.Delay(1000);
            var ID_DEVICE = await fn.GetFastbootDeviceAsync();
            if (ID_DEVICE != null)
            {
                Steps.CurrentStep = 0;
                Steps.StepSubtitles.Add(ID_DEVICE);
                if (await fn.ExtractAsync(URLFile))
                {
                    Steps.CurrentStep = 1;
                    Steps.StepSubtitles.Add(Lang.StepDone);
                    if (await fn.FlashBootAsync())
                    {
                        Steps.CurrentStep = 2;
                        Steps.StepSubtitles.Add(Lang.StepDone);
                        if (await fn.FlashDtboAsync())
                        {
                            Steps.CurrentStep = 3;
                            Steps.StepSubtitles.Add(Lang.StepDone);
                            if (await fn.FlashVendorBootAsync())
                            {
                                Steps.CurrentStep = 4;
                                Steps.StepSubtitles.Add(Lang.StepDone);
                                fn.RebootAsync();
                                PrepareForFlashROM();
                            }
                            else
                            {
                                ErrorAndCancel();
                            }
                        }
                        else
                        {
                            ErrorAndCancel();
                        }
                    }
                    else
                    {
                        ErrorAndCancel();
                    }
                }
                else
                {
                    ErrorAndCancel();
                }
            }
            else
            {
                lb_Error.Text = Lang.ErrorNoDevice;
                pnl_error.Visible = true;
                pb_error.Image = Properties.Resources.ERR_NoDevice;
            }
        }

        #endregion














        #region FRM
        private void frm_Process_Load(object sender, EventArgs e)
        {
            START();
        }
        #endregion

















        #region UI
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void Tadb_Tick(object sender, EventArgs e)
        {
            Tadb.Stop();
            var ADBDevice = await fn.GetAdbDeviceAsync();
            if (ADBDevice.found)
            {
                pb_sideload.Image = Properties.Resources.ThankYou;
                lb_sideload.Text = Lang.ThankYou;
                await Task.Delay(2000);
                Steps.CurrentStep = 5;
                Steps.StepSubtitles.Add(Lang.StepDone);
                pnl_waitSideload.Visible = false;
                FlashROM();
            }
            else
            {
                Tadb.Start();
            }
        }
        #endregion



    }
}
