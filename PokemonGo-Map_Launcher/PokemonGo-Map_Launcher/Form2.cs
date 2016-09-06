using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace PokemonGo_Map_Launcher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            label1.Text = "Running";
            label1.ForeColor = System.Drawing.Color.Green;
            backgroundWorker1.RunWorkerAsync();
        }

        #region Handlers
        private void OutputHandler(Object source, DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                richTextBox2.AppendText(outLine.Data + "\r\n");
            }
        }

        private void ErrorHandler(Object source, DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                richTextBox2.AppendText(outLine.Data + "\r\n");
            }
        }
        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessStartInfo pStartInfo = new ProcessStartInfo("cmd.exe", @"/c python banned.py -f usernames.txt & powershell.exe .\usernames.ps1");
            pStartInfo.CreateNoWindow = true;
            pStartInfo.UseShellExecute = false;
            pStartInfo.RedirectStandardInput = true;
            pStartInfo.RedirectStandardOutput = true;
            pStartInfo.RedirectStandardError = true;
            Process process1 = new Process();
            process1.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process1.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler);
            process1.StartInfo = pStartInfo;
            process1.SynchronizingObject = richTextBox2;
            process1.Start();
            process1.BeginOutputReadLine();
            process1.BeginErrorReadLine();
            process1.WaitForExit();
            label1.Text = "Not Running";
            label1.ForeColor = System.Drawing.Color.Red;
        }
    }
}
