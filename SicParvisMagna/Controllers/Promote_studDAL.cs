using SicParvisMagna.Library;
using SicParvisMagna.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna.Controllers
{
    class Promote_studDAL
    {

        //Connection
        private SqlConnection con = new SQLCon().getCon();
        private SqlCommand cmd = new SqlCommand();

        //MySQL Objects
        //Connection
        // private MySqlConnection mycon = new MYSQLCon().getCon();
        //private MySqlCommand mycmd = new MySqlCommand();

        public void Add(Promote_stuBAL obj)
        {
            try
            {
                //Local

                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Insert_promote_stud";
                cmd.Parameters.Add("@stu_id", SqlDbType.UniqueIdentifier).Value = obj.stu_id;
                cmd.Parameters.Add("@prev_sess", SqlDbType.UniqueIdentifier).Value = obj.prev_session;
                cmd.Parameters.Add("@prev_class", SqlDbType.UniqueIdentifier).Value = obj.prev_class;
                cmd.Parameters.Add("@prev_sect", SqlDbType.UniqueIdentifier).Value = obj.prev_section;
                cmd.Parameters.Add("@next_sess", SqlDbType.UniqueIdentifier).Value = obj.next_session;
                cmd.Parameters.Add("@next_class", SqlDbType.UniqueIdentifier).Value = obj.next_class;
                cmd.Parameters.Add("@next_sect", SqlDbType.UniqueIdentifier).Value = obj.next_section;
                cmd.Parameters.Add("@time", SqlDbType.DateTime).Value = obj.time;
                cmd.Parameters.Add("@addby", SqlDbType.UniqueIdentifier).Value = obj.addby;
                cmd.Parameters.Add("@flag", SqlDbType.TinyInt).Value = obj.flag;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
    }
}
