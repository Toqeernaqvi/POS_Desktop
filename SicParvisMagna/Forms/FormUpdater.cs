using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.IO.Compression;
using System.Data.SqlClient;
using SicParvisMagna.Library;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;

namespace SicParvisMagna.Forms
{
    public partial class FormUpdater : Form
    {
        private SqlConnection conn = new SQLCon().getCon();
        Stopwatch sw = new Stopwatch();    // The stopwatch which we will be using to calculate the download speed
        Stopwatch stopwatch = new Stopwatch();
        string zipPath = @"F:\Final Project\SicParvisMagna\bin\Debug\testDownload.rar";
        string extractPath = @"F:\Final Project\SicParvisMagna\bin\Debug";

        //Download File Function
         public void DownloadFile(string filenameXML)
        {

            Stopwatch reveil = new Stopwatch();
            reveil.Start();
            HttpWebRequest request;
            HttpWebResponse response = null;
            FileStream fs = null;
            long startpoint = 0;
            sw.Start();

            fs = File.Create(filenameXML);

            request = (HttpWebRequest)WebRequest.Create(txtDownload.Text);
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version11;
            request.Method = "GET";
            request.ContentType = "gzip";
            request.Timeout = 10000;
            request.Headers.Add("xRange", "bytes " + startpoint + "-");
            response = (HttpWebResponse)request.GetResponse();
            txtUpdateLog.Text = Convert.ToString(response.ContentLength / 1000000) + "Mb" + Environment.NewLine;
            Stream streamResponse = response.GetResponseStream();

            byte[] buffer = new byte[1024];
            int read;
            while ((read = streamResponse.Read(buffer, 0, buffer.Length)) > 0)
            {
                fs.Write(buffer, 0, read);
            }
            fs.Flush(); fs.Close();
            reveil.Stop();
            txtUpdateLog.Text += "\nFor this url : " + request + " = " + reveil.ElapsedMilliseconds + " ms" + Environment.NewLine;
            txtUpdateLog.Text += "\nDownload Complete";

            // MessageBox.Show("File Downloaded");
        }


        // Move a file into another file, delete the original, and create a backup of the replaced file.
        public static void ReplaceFile(string FileToMoveAndDelete, string FileToReplace, string BackupOfFileToReplace)
        {
            File.Replace(FileToMoveAndDelete, FileToReplace, BackupOfFileToReplace, false);

        }

        public FormUpdater()
        {
            InitializeComponent();
        }

        WebClient client;


        private void btnDownload_Click(object sender, EventArgs e)
        {
            string url = txtDownload.Text;
            client.OpenRead(url);
            Int64 bytes_total = Convert.ToInt64(client.ResponseHeaders["Content-Length"]);
            lblFileSize.Text = (bytes_total.ToString() + " Bytes");
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

            // DownloadFile("testDownload.sql");
            //btn("http://globalteksoft.com/uploads/logo.zip");


        }

        //for Extract File
        private void btnExtract_Click(object sender, EventArgs e)
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);

        }

        private void btnBrowseOF_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOrignalFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnBrowseRF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtReplaceFilePath.Text = openFileDialog1.FileName;
            }
        }

        //Replace File
        private void button1_Click(object sender, EventArgs e)
        {

            string OrignalFile = Path.GetFileName(txtOrignalFilePath.Text);
            string replaceFile = Path.GetFileName(txtReplaceFilePath.Text);
            // string backupfile = 
            try
            {

                ReplaceFile(txtOrignalFilePath.Text, txtReplaceFilePath.Text, null);
                // File.Move(txtOrignalFilePath.Text, txtReplaceFilePath.Text);
                //MoveFile(txtReplaceFilePath.Text, txtOrignalFilePath.Text);

                MessageBox.Show("Processed Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Sql Script Browse
        private void btnSQLScript_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                //  DefaultExt = "txt",
                //    Filter = "txt files (*.txt)|*.txt",
                //FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSQLScript.Text = openFileDialog1.FileName;
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            updatedatabase();
        }
        public void updatedatabase()
        {

            try
            {

                conn.Open();

                string script = File.ReadAllText(txtSQLScript.Text);

                // split script on GO command
                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        new SqlCommand(commandString, conn).ExecuteNonQuery();
                    }
                }
                txtUpdateLog.Text = "Database updated successfully.";

            }
            catch (SqlException er)
            {
                txtUpdateLog.Text = er.Message;
                txtUpdateLog.ForeColor = Color.Red;
            }
            finally
            {
                conn.Close();
            }
        }

        private void FormUpdater_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            
            
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
                    progressBar.Minimum = 0;
                    try
                    {
                        double receive = double.Parse(e.BytesReceived.ToString());
                        double total = double.Parse(e.TotalBytesToReceive.ToString());
                        double percentage = receive / total * 100;
                        label6.Text = $"Download{string.Format("{0:0.##}", percentage)}%";
                        progressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
                        double seconds = stopwatch.Elapsed.TotalSeconds;

                        double speed = total / seconds;

                        speed = Math.Round(speed / 1000);
                        lblTime.Text = FormatDurationSeconds(Convert.ToInt32(seconds));
                        lblDownloadingSpeed.Text = (string.Format("Your speed: {0} kilobytes per second.", speed));
                    }
                    catch { }
                    
                       
                   

                }));
            }
            catch  { }
           

        }

        
    }
}
