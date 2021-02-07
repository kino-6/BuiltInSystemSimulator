using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Runtime.InteropServices;

namespace Simulator
{
    public partial class MainUI : MetroForm
    {
        public MainUI()
        {
            InitializeComponent();

            // simulation main thread
            bw_main.DoWork += new DoWorkEventHandler(BwSimMain);
            bw_main.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BwSimMainCompleted);
            bw_main.WorkerSupportsCancellation = true;
            bw_main.WorkerReportsProgress = true;

            // logger main thread
            logger_main.DoWork += new DoWorkEventHandler(LoggerMain);
            logger_main.RunWorkerCompleted += new RunWorkerCompletedEventHandler(LoggerMainCompleted);
            logger_main.WorkerSupportsCancellation = true;

            // progress
            progress_main.DoWork += new DoWorkEventHandler(BwSimProgressMain);
            progress_main.WorkerSupportsCancellation = true;
            progress_main.WorkerReportsProgress = true;
        }

        private void AddLog(String str, Color color)
        {
            if (Log.InvokeRequired)
            {
                Log.Invoke((MethodInvoker)delegate {
                    AddLog(str, color);
                });
            }
            else
            {
                Log.ForeColor = color;
                Log.AppendText(System.DateTime.Now.ToString() + " " + str + System.Environment.NewLine);
            }
        }

        private DialogResult OpenFile(OpenFileDialog ofd)
        {
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ScenarioPath.Text = ofd.FileName;
                AddLog(ofd.FileName, Color.Black);
            }
            else
            {
                AddLog("Error Open File " + ofd.FileName, Color.Red);
            }
            return dr;
        }

        private void ScenarioPath_Click(object sender, EventArgs e)
        {
            OpenFile(OpenScenarioFile);
        }


        enum ConfigState
        {
            CONFIG_OK,
            CONFIG_NG,
            CONFIG_STATE_NUM
        };

        private void ChangeConfigState(ConfigState state)
        {
            switch (state)
            {
                case ConfigState.CONFIG_OK:
                    ConfigStateLabel.Text = "ConfigState = OK  ✔";
                    break;
                case ConfigState.CONFIG_NG:
                    ConfigStateLabel.Text = "ConfigState = NG  ✖";
                    break;
                default:
                    ConfigStateLabel.Text = "ConfigState = None";
                    break;
            }
        }

        private void ConfigFilePath_ButtonClick(object sender, EventArgs e)
        {
            DialogResult dr = OpenFile(OpenConfigFile);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                ChangeConfigState(ConfigState.CONFIG_OK);
            }
            else
            {
                ChangeConfigState(ConfigState.CONFIG_NG);
            }
        }

        [DllImport("SimCore.dll")]
        static extern void sim_main();
        [DllImport("SimCore.dll")]
        static extern UInt64 get_log(StringBuilder str, UInt64 buffer_size);
        [DllImport("SimCore.dll")]
        static extern double get_progress();


        private void BwSimMain(object sender, DoWorkEventArgs e)
        {
            sim_main();
            e.Result = "Simulation Completed!";
        }

        private void BwSimMainCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AddLog(e.Result.ToString(), Color.Black);
            RunSimulationButton.Enabled = true;

            // cancel logger thread
            logger_main.CancelAsync();

            // cancel progress thread
            progress_main.CancelAsync();
        }


        private void LoggerMain(object sender, DoWorkEventArgs e)
        {
            int buffer_size = 2048;
            StringBuilder sb = new StringBuilder("Logger Strings", buffer_size);

            while (true)
            {
                System.Threading.Thread.Sleep(200);

                while (get_log(sb, (UInt64)buffer_size) > 0)
                {
                    AddLog(sb.ToString(), Color.Black);
                }

                if (logger_main.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        private void LoggerMainCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //AddLog(e.Result.ToString(), Color.Black);
        }

        private void BwSimProgressMain(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1);
                int p = (int)(get_progress() + 1);
                progress_main.ReportProgress(p);

                if (progress_main.CancellationPending || p >= 100)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }
        private void progress_main_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ScenarioProgress.Value = e.ProgressPercentage;
        }


        private void RunSimulationButton_Click(object sender, EventArgs e)
        {
            AddLog("Start Simulation... ", Color.Black);

            if (Environment.Is64BitProcess)
            {
                bw_main.RunWorkerAsync();
                RunSimulationButton.Enabled = false;

                logger_main.RunWorkerAsync();
                progress_main.RunWorkerAsync();
            }
            else
            {
                AddLog("Target dll is working on 64bit! ", Color.Black);
            }
        }
    }
}
