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
            buttonNPM.Text = "Downloading";
            buttonNPM.Enabled = false;
            buttonPythonCPP.Text = "Downloading";
            buttonPythonCPP.Enabled = false;
            buttonPython.Text = "Downloading";
            buttonPython.Enabled = false;
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
            MessageBox.Show("Download Completed");
            btnStartDownload.Text = "Start Download";
            btnStartDownload.Enabled = true;
            buttonNPM.Text = "Start Download";
            buttonNPM.Enabled = true;
            buttonPythonCPP.Text = "Start Download";
            buttonPythonCPP.Enabled = true;
            buttonPython.Text = "Start Download";
            buttonPython.Enabled = true;
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
            btnStartDownload.Text = "Downloading";
            btnStartDownload.Enabled = false;
            buttonNPM.Text = "Downloading";
            buttonNPM.Enabled = false;
            buttonPythonCPP.Text = "Downloading";
            buttonPythonCPP.Enabled = false;
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
            MessageBox.Show("Download Completed");
            btnStartDownload.Text = "Start Download";
            btnStartDownload.Enabled = true;
            buttonNPM.Text = "Start Download";
            buttonNPM.Enabled = true;
            buttonPythonCPP.Text = "Start Download";
            buttonPythonCPP.Enabled = true;
            buttonPython.Text = "Start Download";
            buttonPython.Enabled = true;
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
            btnStartDownload.Text = "Downloading";
            btnStartDownload.Enabled = false;
            buttonNPM.Text = "Downloading";
            buttonNPM.Enabled = false;
            buttonPythonCPP.Text = "Downloading";
            buttonPythonCPP.Enabled = false;
            buttonPython.Text = "Downloading";
            buttonPython.Enabled = false;
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
            MessageBox.Show("Download Completed");
            btnStartDownload.Text = "Start Download";
            btnStartDownload.Enabled = true;
            buttonNPM.Text = "Start Download";
            buttonNPM.Enabled = true;
            buttonPythonCPP.Text = "Start Download";
            buttonPythonCPP.Enabled = true;
            buttonPython.Text = "Start Download";
            buttonPython.Enabled = true;
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
            btnStartDownload.Text = "Downloading";
            btnStartDownload.Enabled = false;
            buttonNPM.Text = "Downloading";
            buttonNPM.Enabled = false;
            buttonPythonCPP.Text = "Downloading";
            buttonPythonCPP.Enabled = false;
            buttonPython.Text = "Downloading";
            buttonPython.Enabled = false;
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
            MessageBox.Show("Download Completed");
            btnStartDownload.Text = "Start Download";
            btnStartDownload.Enabled = true;
            buttonNPM.Text = "Start Download";
            buttonNPM.Enabled = true;
            buttonPythonCPP.Text = "Start Download";
            buttonPythonCPP.Enabled = true;
            buttonPython.Text = "Start Download";
            buttonPython.Enabled = true;
        }
        #endregion




        private void Form3_Load(object sender, EventArgs e)
        {
           if(Directory.Exists(@"C:\Python27"))
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
        }
    }
}
