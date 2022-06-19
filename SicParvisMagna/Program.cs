using SicParvisMagna.Forms;
using SicParvisMagna.Forms.PointOfSale;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SicParvisMagna
{
    static class Program
    {
        //public static int UserId = 0;
        public static Guid User_id = Guid.Empty;
        public static string User_name = ""; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Bunifu.Framework.License.Authenticate("HackAndModz", "HackAndModz");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormLogin());



        }

    }
}
