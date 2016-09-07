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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            runmapSS.WorkerSupportsCancellation = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "13";
            label2.Text = " -nk";
            label3.Text = " -ng";
            label4.Text = "";
            label5.Text = "";
            textBox2.Text = "17605";
        }

        #region TextBoxes

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            // scroll it automatically
            richTextBox1.ScrollToCaret();
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBox2.SelectionStart = richTextBox2.Text.Length;
            // scroll it automatically
            richTextBox2.ScrollToCaret();
        }

        #endregion

        #region Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            runmapSS.RunWorkerAsync();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            update.RunWorkerAsync();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            runmapSPS.RunWorkerAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C .\config\config.ini";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C start .";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            AccountCreation.RunWorkerAsync();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            runmapSS.CancelAsync();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            //String command = "/C RunNotifications.lnk";
            //ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
            //cmdsi.Arguments = command;
            //Process cmd = Process.Start(cmdsi);
            richTextBox2.Text = "";
            Notifications.RunWorkerAsync();
        }

        #endregion

        #region Background Workers

        private void Notifications_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessStartInfo pStartInfo = new ProcessStartInfo("cmd.exe", "/C RunNotifications.lnk");
            pStartInfo.CreateNoWindow = true;
            pStartInfo.UseShellExecute = false;
            pStartInfo.RedirectStandardInput = true;
            pStartInfo.RedirectStandardOutput = true;
            pStartInfo.RedirectStandardError = true;
            Process process1 = new Process();
            process1.OutputDataReceived += new DataReceivedEventHandler(OutputHandler2);
            process1.ErrorDataReceived += new DataReceivedEventHandler(ErrorHandler2);
            process1.StartInfo = pStartInfo;
            process1.SynchronizingObject = richTextBox2;
            process1.Start();
            process1.BeginOutputReadLine();
            process1.BeginErrorReadLine();
            process1.WaitForExit();
        }
        private void runmapSS_DoWork(object sender, DoWorkEventArgs e)
        { 
            ProcessStartInfo pStartInfo = new ProcessStartInfo("cmd.exe", "/c python runserver.py --webhook-updates-only -l " + textBox2.Text + " -st " + comboBox2.Text + label2.Text + label3.Text + label4.Text + label5.Text);
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
            //process1.WaitForExit();
            if (runmapSS.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

        }
        private void runmapSPS_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessStartInfo pStartInfo = new ProcessStartInfo("cmd.exe", "/c python runserver.py -ss --webhook-updates-only -l " + textBox2.Text + " -st " + comboBox2.Text + label2.Text + label3.Text + label4.Text + label5.Text);
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
        }
        private void update_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessStartInfo pStartInfo = new ProcessStartInfo("cmd.exe", "/C git pull & pip install -r requirements.txt --upgrade & npm install & npm run build");
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
        }
        private void AccountCreation_DoWork(object sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                ProcessStartInfo pStartInfo = new ProcessStartInfo("cmd.exe", "/C pikaptcha -p " + textBox1.Text + " -c " + comboBox1.Text + @" & python banned.py -f usernames.txt & powershell.exe .\usernames.ps1");
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
            }
            else
            {
                ProcessStartInfo pStartInfo = new ProcessStartInfo("cmd.exe", "/C pikaptcha -r " + textBox3.Text + " -p " + textBox1.Text + " -c " + comboBox1.Text + @" & python banned.py -f usernames.txt & powershell.exe .\usernames.ps1");
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
            }
        }

        #endregion

        #region Handlers
        private void OutputHandler(Object source, DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                richTextBox1.AppendText(outLine.Data + "\r\n");
            }
        }

        private void ErrorHandler(Object source, DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                richTextBox1.AppendText(outLine.Data + "\r\n");
            }
        }
        private void OutputHandler2(Object source, DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                richTextBox2.AppendText(outLine.Data + "\r\n");
            }
        }

        private void ErrorHandler2(Object source, DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                richTextBox2.AppendText(outLine.Data + "\r\n");
            }
        }


        #endregion



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label2.Text = "";
            }
            else
            {
                label2.Text = " -nk";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                label3.Text = "";
            }
            else
            {
                label3.Text = " -ng";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label4.Text = " -fl";
            }
            else
            {
                label4.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                label5.Text = " -nsc";
            }
            else
            {
                label5.Text = "";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }


    }
}
