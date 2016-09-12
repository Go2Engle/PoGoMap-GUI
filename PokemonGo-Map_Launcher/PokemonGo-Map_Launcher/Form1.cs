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
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

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
            label11.Text = "";
            
        }
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }


        #region Buttons

        private void test_Click(object sender, EventArgs e)
        {
            Process p1 = Process.Start("cmd.exe");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p1.MainWindowHandle, panel1.Handle);
            MoveWindow(p1.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);

            Process p = Process.Start("cmd.exe");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel2.Handle);
            MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RunMapSS
            Process p = Process.Start("cmd.exe", @"/c cd PokemonGo-Map & python runserver.py --webhook-updates-only -enc -l " + textBox2.Text + " -st " + comboBox2.Text + label2.Text + label3.Text + label4.Text + label5.Text + label11.Text + " -H " + GetLocalIPAddress() + " -P " + textBox4.Text + " -wh http://" + GetLocalIPAddress() + ":" + textBox5.Text + "& pause");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel2.Handle);
            MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Run Updates
            DialogResult result = MessageBox.Show("Are you sure you want to update?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
            {
                Process p = Process.Start("cmd.exe", @"/C cd PokemonGo-Map & git pull & pip install -r requirements.txt --upgrade & npm install & npm run build & echo Finish Updating & pause");
                Thread.Sleep(150); // Allow the process to open it's window
                SetParent(p.MainWindowHandle, panel1.Handle);
                MoveWindow(p.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
            }
            else if (result == DialogResult.No)
            {

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C .\PokemonGo-Map\config\config.ini";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C .\PokeAlarm\alarms.json";
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
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                var lines = File.ReadAllLines(@".\PokemonGo-map\config\config.ini");
                lines[4] = "password:[" + textBox1.Text + "]";
                File.WriteAllLines(@".\PokemonGo-map\config\config.ini", lines);
                Process p = Process.Start("cmd.exe", @"/C cd PokemonGo-Map & pikaptcha -p " + textBox1.Text + " -c " + comboBox1.Text + @" & python banned.py -f usernames.txt & powershell -executionpolicy unrestricted .\usernames.ps1 & pause");
                Thread.Sleep(150); // Allow the process to open it's window
                SetParent(p.MainWindowHandle, panel2.Handle);
                MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
            }
            else
            {
                var lines = File.ReadAllLines(@".\PokemonGo-map\config\config.ini");
                lines[4] = "password:[" + textBox1.Text + "]";
                File.WriteAllLines(@".\PokemonGo-map\config\config.ini", lines);
                Process p = Process.Start("cmd.exe", @"/C cd PokemonGo-Map & pikaptcha -r " + textBox3.Text + " -p " + textBox1.Text + " -c " + comboBox1.Text + @" & python banned.py -f usernames.txt & powershell -executionpolicy unrestricted .\usernames.ps1 & pause");
                Thread.Sleep(150); // Allow the process to open it's window
                SetParent(p.MainWindowHandle, panel2.Handle);
                MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //RunNotifications
            Process p = Process.Start("cmd.exe", @"/C cd PokeAlarm & python runwebhook.py -H " + GetLocalIPAddress() + " -P " + textBox5.Text + " & pause");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel1.Handle);
            MoveWindow(p.MainWindowHandle, 0, 0, panel1.Width, panel1.Height, true);
        }
      
        private void button9_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("cmd.exe", @"/c cd PokemonGo-Map & python banned.py -f usernames.txt & powershell -executionpolicy unrestricted .\usernames.ps1 & Pause");
            Thread.Sleep(150); // Allow the process to open it's window
            SetParent(p.MainWindowHandle, panel2.Handle);
            MoveWindow(p.MainWindowHandle, 0, 0, panel2.Width, panel2.Height, true);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + GetLocalIPAddress() + ":" + textBox4.Text);
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
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                label11.Text = " -ss";
            }
            else
            {
                label2.Text = "";
            }
        }


        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.CaptchaKEY = textBox3.Text;
            Properties.Settings.Default.StartLOC = textBox2.Text;
            Properties.Settings.Default.Password = textBox1.Text;
            Properties.Settings.Default.MapPort = textBox4.Text;
            Properties.Settings.Default.NotificationsPort = textBox5.Text;
            Properties.Settings.Default.Save();
            if (MessageBox.Show("Are all your command windows closed?", "IMPORTANT", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
