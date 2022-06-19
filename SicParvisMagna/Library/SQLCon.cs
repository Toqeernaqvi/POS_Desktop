using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Library
{
    class SQLCon
    {
        string server = "";
        string database = "";
        string userid = "";
        string password = "";
        private SqlConnection con;
        //

        public SQLCon()
        {
            string line = "";
            try
            {
                // Gets current location of project bin/debug directory
                string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                // Location of file inside debug directory
                string file = dir + @"\Connection\SQLconfig.txt";

                StreamReader sr = new StreamReader(file);
                line = sr.ReadToEnd();
                string[] data = line.Split(',');

                server = data[0].Trim();
                database = data[1].Trim();
                userid = data[2].Trim();
                password = data[3].Trim();

                sr.Close();
                //   con = new SqlConnection("Data Source=DESKTOP-DBU9OUO;Initial Catalog=SicParvisMagna;User ID=sa;Password=Allah;");
                //con = new SqlConnection("Data Source=USER-PC;Initial Catalog=MasterDatabase;User ID=sa;Password=Allah");
               // con = new SqlConnection("Data Source=DESKTOP-I64JS4L;Initial Catalog=BasicCRUD;Integrated Security=True");

               con = new SqlConnection("Data Source=" + server + "; Initial Catalog=" + database + ";User ID=" + userid + "; Password=" + password + ";");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        SqlCommand cmd = new SqlCommand();



        public SqlConnection getCon()
        {
            return con;
        }


    }
}
