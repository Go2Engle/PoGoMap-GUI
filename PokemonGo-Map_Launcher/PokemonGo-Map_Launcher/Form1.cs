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
using System.Runtime.InteropServices;
using System.Threading;

namespace PokemonGo_Map_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "13";
            label2.Text = " -nk";
            label3.Text = " -ng";
            label4.Text = "";
            label5.Text = "";
            
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);


        #region Buttons

        private void test_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("cmd.exe");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, this.Handle);
            MoveWindow(p.MainWindowHandle, 290, 218, 970, 357, true);

            Process p1 = Process.Start("cmd.exe");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p1.MainWindowHandle, this.Handle);
            MoveWindow(p1.MainWindowHandle, 290, 0, 970, 218, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RunMapSS
            Process p = Process.Start("cmd.exe", @"/c python runserver.py --webhook-updates-only -l " + textBox2.Text + " -st " + comboBox2.Text + label2.Text + label3.Text + label4.Text + label5.Text);
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, this.Handle);
            MoveWindow(p.MainWindowHandle, 290, 218, 970, 357, true);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Run Updates
            Process p = Process.Start("cmd.exe", @"/C git pull & pip install -r requirements.txt --upgrade & npm install & npm run build");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, this.Handle);
            MoveWindow(p.MainWindowHandle, 290, 0, 970, 218, true);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //RunMapSPS
            Process p = Process.Start("cmd.exe", @"/c python runserver.py -ss --webhook-updates-only -l " + textBox2.Text + " -st " + comboBox2.Text + label2.Text + label3.Text + label4.Text + label5.Text);
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, this.Handle);
            MoveWindow(p.MainWindowHandle, 290, 218, 970, 357, true);
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
            //Account Creation
            Process p = Process.Start("cmd.exe", @"/C pikaptcha -p " + textBox1.Text + " -c " + comboBox1.Text + @" & python banned.py -f usernames.txt & powershell.exe .\usernames.ps1");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, this.Handle);
            MoveWindow(p.MainWindowHandle, 290, 218, 970, 357, true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //RunNotifications
            Process p = Process.Start("cmd.exe", @"/C RunNotifications.lnk");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, this.Handle);
            MoveWindow(p.MainWindowHandle, 290, 0, 970, 218, true);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        #endregion

        #region CheckBoxes

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

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CaptchaKEY = textBox3.Text;
            Properties.Settings.Default.StartLOC = textBox2.Text;
            Properties.Settings.Default.Password = textBox1.Text;
            Properties.Settings.Default.Save();
            if (MessageBox.Show("Are all your command windows close?", "IMPORTANT", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
