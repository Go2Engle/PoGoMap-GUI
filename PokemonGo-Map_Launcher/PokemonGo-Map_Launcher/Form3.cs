using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace PokemonGo_Map_Launcher
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string DPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public string PythonCPPL = Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%\Programs\Common\Microsoft\Visual C++ for Python");

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Python27"))
            {
                buttonPython.Enabled = false;
                buttonPython.Text = "Already Installed";
            }
            if (Directory.Exists(@"C:\Program Files\nodejs"))
            {
                buttonNPM.Enabled = false;
                buttonNPM.Text = "Already Installed";
            }
            if (Directory.Exists(PythonCPPL))
            {
                buttonPythonCPP.Enabled = false;
                buttonPythonCPP.Text = "Already Installed";
            }
            if (Directory.Exists(@"C:\Program Files\Git"))
            {
                btnStartDownload.Enabled = false;
                btnStartDownload.Text = "Already Installed";
            }
            if (File.Exists(@"C:\python27\scripts\chromedriver.exe"))
            {
                DLChromeDriver.Enabled = false;
                DLChromeDriver.Text = "Already Installed";
            }
            if (File.Exists(@"C:\python27\scripts\phantomjs.exe"))
            {
                DownloadPJS.Enabled = false;
                DownloadPJS.Text = "Already Installed";
            }
            if (File.Exists(@"C:\python27\scripts\pikaptcha.exe"))
            {
                DLAccountCreator.Enabled = false;
                DLAccountCreator.Text = "Already Installed";
            }

        }

        #region GitHub
        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            // Starts the download
            client.DownloadFileAsync(new Uri("http://github.com/git-for-windows/git/releases/download/v2.10.0.windows.1/Git-2.10.0-64-bit.exe"), DPath + @"\github.exe");
            btnStartDownload.Text = "Downloading";
            btnStartDownload.Enabled = false;

        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("Download Completed");
            btnStartDownload.Text = "Installing";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "github.exe";
            startInfo.Arguments = "/verysilent";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            btnStartDownload.Text = "Installed";

        }
        #endregion


        #region Python
        private void buttonPython_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged1);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted1);
            // Starts the download
            client.DownloadFileAsync(new Uri("https://www.python.org/ftp/python/2.7.12/python-2.7.12.amd64.msi"), DPath + @"\python.msi");
            buttonPython.Text = "Downloading";
            buttonPython.Enabled = false;
        }
        void client_DownloadProgressChanged1(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted1(object sender, AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("Download Completed");
            buttonPython.Text = "Installing";
            Process process = new Process();
            process.StartInfo.FileName = "msiexec.exe";
            process.StartInfo.Arguments = string.Format(" /qb /i python.msi ADDLOCAL=ALL");
            process.Start();
            process.WaitForExit();         
            buttonPython.Text = "Installed";
        }
        #endregion


        #region PythonCPP
        private void buttonPythonCPP_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged2);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted2);
            // Starts the download
            client.DownloadFileAsync(new Uri("https://download.microsoft.com/download/7/9/6/796EF2E4-801B-4FC4-AB28-B59FBF6D907B/VCForPython27.msi"), DPath + @"\pythonCPP.msi");
            buttonPythonCPP.Text = "Downloading";
            buttonPythonCPP.Enabled = false;

        }
        void client_DownloadProgressChanged2(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar2.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted2(object sender, AsyncCompletedEventArgs e)
        {
            buttonPythonCPP.Text = "Installing";
            Process process = new Process();
            process.StartInfo.FileName = "msiexec.exe";
            process.StartInfo.Arguments = string.Format(" /qb /i pythonCPP.msi");
            process.Start();
            process.WaitForExit();
            buttonPythonCPP.Text = "Installed";

        }
        #endregion


        #region NPM
        private void buttonNPM_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged3);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted3);
            // Starts the download
            client.DownloadFileAsync(new Uri("https://nodejs.org/dist/v4.5.0/node-v4.5.0-x64.msi"), DPath + @"\NPM.msi");
            buttonNPM.Text = "Downloading";
            buttonNPM.Enabled = false;

        }
        void client_DownloadProgressChanged3(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar3.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted3(object sender, AsyncCompletedEventArgs e)
        {
            buttonNPM.Text = "Installing";
            Process process = new Process();
            process.StartInfo.FileName = "msiexec.exe";
            process.StartInfo.Arguments = string.Format(" /qb /i NPM.msi");
            process.Start();
            process.WaitForExit();
            buttonNPM.Text = "Installed";

        }
        #endregion


        #region Chrome Driver
        private void DLChromeDriver_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged4);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted4);
            // Starts the download
            client.DownloadFileAsync(new Uri("http://go2engle.com/downloads/chromedriver.exe"), @"C:\python27\scripts\chromedriver.exe");
            DLChromeDriver.Text = "Downloading";
            DLChromeDriver.Enabled = false;
        }
        void client_DownloadProgressChanged4(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar4.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted4(object sender, AsyncCompletedEventArgs e)
        {
            DLChromeDriver.Text = "Installed";
        }
        #endregion


        #region DownloadPJS
        private void DownloadPJS_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged5);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted5);
            // Starts the download
            client.DownloadFileAsync(new Uri("http://go2engle.com/downloads/phantomjs.exe"), @"C:\python27\scripts\phantomjs.exe");
            DownloadPJS.Text = "Downloading";
            DownloadPJS.Enabled = false;
        }
        void client_DownloadProgressChanged5(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            progressBar5.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted5(object sender, AsyncCompletedEventArgs e)
        {
            DownloadPJS.Text = "Installed";
        }
        #endregion


        private void DLAccountCreator_Click(object sender, EventArgs e)
        {
            String command = @"/C pip install git+https://github.com/sriyegna/pikaptcha & pip install git+https://github.com/keyphact/pgoapi.git";
            ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
            cmdsi.Arguments = command;
            Process cmd = Process.Start(cmdsi);
            cmd.WaitForExit();
            DLAccountCreator.Enabled = false;
            DLAccountCreator.Text = "Done";
        }


        private void PoGoConfig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This may take some time to run.");
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C cd PokemonGo-Map & pip install -r requirements.txt & npm install";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void PokeAlarmConfig_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C cd PokeAlarm & pip install -r requirements.txt";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void GMapsAPI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = @"/C cd PokemonGo-Map & cd config & MapsAPI.bat " + textBox1.Text;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            MessageBox.Show("API Key has been updated");
        }
    }
}
