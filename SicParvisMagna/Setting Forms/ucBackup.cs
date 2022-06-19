using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SicParvisMagna.Library;
using SicParvisMagna.Controllers;
using SicParvisMagna.Models;
using MadMilkman.Ini;

namespace SicParvisMagna.Setting_Forms
{
    public partial class ucBackup : UserControl
    {
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();
        FormSQLBackup f = new FormSQLBackup();

        string path;
        public ucBackup()
        {
            InitializeComponent();
            //----------------------------------------------------------

            //for Writnig
            //IniOptions options = new IniOptions();
            //IniFile iniFile = new IniFile(options);
            //iniFile.Sections.Add(
            //    new IniSection(iniFile, "Default Backup Path",
            //        new IniKey(iniFile, "Backup", @"F:\Final Project\DatabaseBackupPath")
            //       ));

            //// Save file to path.
            //iniFile.Save(@"F:\Final Project\BackupPath.ini");
            //----------------------------------------------------------
            //reading Data
            IniFile iniFile = new IniFile();
            iniFile.Load(@"D:\Backup\BackupPath.ini");

            iniFile.Sections["Default Backup Path"].Keys["Backup"].TryParseValue(out path);
             txtPath.Text = path;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
           
           
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                //for Writnig
                IniOptions options = new IniOptions();
                IniFile iniFile = new IniFile(options);
                iniFile.Sections.Add(
                    new IniSection(iniFile, "Default Backup Path",
                        new IniKey(iniFile, "Backup", fd.SelectedPath)
                       ));

                // Save file to path.
                iniFile.Save(@"D:\Backup\BackupPath.ini");
             //   txtPath.Text = fd.SelectedPath;


                //reading Data
                 iniFile.Load(@"D:\Backup\BackupPath.ini");

                iniFile.Sections["Default Backup Path"].Keys["Backup"].TryParseValue(out path);
                txtPath.Text = path;
            }

            
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            f.Show();
            backgroundWorker1.RunWorkerAsync();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            con.Open();
            try
            {

                

                string qry = "BACKUP DATABASE [" + con.Database + "] TO  DISK = N'" + txtPath.Text + "//" + con.Database 
                    + ".bak'WITH NOFORMAT, NOINIT,  NAME = N'BasicCRUD-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
            con.Close();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            f.Hide();
        }

        private void btnBrowseDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = @"E:\";
            opf.Title = "Browse Backup File";
            opf.CheckFileExists = true;
            opf.CheckPathExists = true;
            opf.DefaultExt = "BAK";
            opf.Filter = "Backup Files(*.bak)|*.bak";
            opf.FilterIndex = 2;
            opf.RestoreDirectory = true;
            opf.ReadOnlyChecked = false;
            opf.ShowReadOnly = true;
            if (opf.ShowDialog() == DialogResult.OK)
            {
                txtPathDatabase.Text = opf.FileName;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "Use [Master];";
            string str1 = "Alter Database"+ "[SicParvisMagnaProduction]" + "SET SINGLE_USER  WITH ROLLBACK IMMEDIATE";
            string str2 = "RESTORE DATABASE [SicParvisMagnaProduction] FROM  DISK = N'" + txtPathDatabase.Text+"' WITH  Replace ";
            SqlCommand cmd = new SqlCommand(str, con);
           SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlCommand cmd2 = new SqlCommand(str2, con);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();

            MessageBox.Show("Database Restore  Successfully");
            con.Close();
        }
    }
}
