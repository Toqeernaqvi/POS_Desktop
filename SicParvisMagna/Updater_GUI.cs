using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using SicParvisMagna.Library;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;
namespace SicParvisMagna
{
    public partial class Updater_GUI : Form
    {
        private SqlConnection conn = new SQLCon().getCon();
        Stopwatch sw = new Stopwatch();    // The stopwatch which we will be using to calculate the download speed
        Stopwatch stopwatch = new Stopwatch();
        string zipPath = @"F:\Final Project\SicParvisMagna\bin\Debug\testDownload.rar";
        string extractPath = @"F:\Final Project\SicParvisMagna\bin\Debug";
        WebClient client;


        public Updater_GUI()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           

            if (this.Height == 400)
            {
                this.Height = 800;
                 
            }
            else
            {
                 this.Height = 400;
                  
            }
        }

        private void Updater_GUI_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;


            string url = "http://globalteksoft.com/uploads/logo.zip";
            client.OpenRead(url);
            Int64 bytes_total = Convert.ToInt64(client.ResponseHeaders["Content-Length"]);
            if (bytes_total > 1024)
            {
                long kbs = bytes_total / 1024;
                lblFileSize.Text = (kbs.ToString() + "Kbs");

                if (kbs > 1024)
                {
                    long mbs = kbs / 1024;
                    lblFileSize.Text = (mbs.ToString() + "Mbs");

                }
            }
            else
            {
                lblFileSize.Text = (bytes_total.ToString() + " Bytes");
            }
            stopwatch.Reset();
            stopwatch.Start();
            if (!string.IsNullOrEmpty(url))
            {
                Thread thread = new Thread(() =>
                {
                    Uri uri = new Uri(url);
                    string filename = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client.DownloadFileAsync(uri, Application.StartupPath + " / " + "a1");


                });
                thread.Start();

                //  Invoke(new Action(() => txtUpdateLog.Text = "Download rate: " + kbsec + " kb/sec"));

            }

        }

        private void radProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
 

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            if (this.Height == 380)
            {
                this.Height = 620;
            }
            else
            {
                this.Height = 380;
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

            MessageBox.Show("Download Completed");

        }
        public static string FormatDurationSeconds(int seconds)
        {
            var duration = TimeSpan.FromSeconds(seconds);
            string result = "";

            if (duration.TotalHours >= 1)
                result += (int)duration.TotalHours + " Hours, ";

            result += String.Format("{0:%m} Minutes, {0:%s} Seconds", duration);

            return result;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {

                Invoke(new MethodInvoker(delegate ()
                {
                    stopwatch.Stop();
                    progressBar.Value = 0;
                    double receive = double.Parse(e.BytesReceived.ToString());
                    double total = double.Parse(e.TotalBytesToReceive.ToString());
                    double percentage = receive / total * 100;
                    //label6.Text = $"Download{string.Format("{0:0.##}", percentage)}%";
                    progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
                    double seconds = stopwatch.Elapsed.TotalSeconds;

                    double speed = total / seconds;

                    speed = Math.Round(speed / 1000);

                    //lblTime.Text = FormatDurationSeconds(Convert.ToInt32(seconds));
                    lblDownloadingSpeed.Text = (string.Format("{0}kbps.", speed));


                }));
            }
            catch { }


        }

    }
}
