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
    class RegnoCls
    {
        public string getSerialno(Guid id, Guid clsid, Guid session)
        {
            string cls = "";

            ClassDAL classesdb = new ClassDAL();

            ClassBAL classes = classesdb.LoadbyClassID(id);
            

            if (classes.title.Length > 8)
            {
                cls = classes.title.Trim().Substring(0, 8);
            }
            else
            {
                cls = classes.title;
            }
            string new_class_level = "";
            cls = cls.ToUpper();
            //Primary
            //Middle
            //Higher
            string temp;
            if (classes.class_level == "Primary")
            {
                //new_class_level = "PRI";
                new_class_level = "";
                temp = id.ToString() + "" + new_class_level + "-" + cls + "-" + session;
            }
            else if (classes.class_level == "Middle")
            {
                //new_class_level = "MID";
                new_class_level = "";
                temp = id.ToString() + "" + new_class_level + "-" + cls + "-" + session;
            }
            else if (classes.class_level == "Higher")
            {
                //new_class_level = "HIGH";
                new_class_level = "";
                temp = id.ToString() + "" + new_class_level + "-" + cls + "-" + session;
            }
            else
                temp = "*Class Level not set*";


            return temp;
        }
        public string getSerialno(Guid id, Guid clsid)
        {
            string cls = "";
            DateTime expirationDate = DateTime.Now; // random date
            string lastTwoDigitsOfYear = expirationDate.ToString("yy");
            ClassDAL classesdb = new ClassDAL();

            ClassBAL classes = classesdb.LoadbyClassID(clsid);





            if (classes.title.Length>4)
            {
                cls = classes.title.Substring(0, 4);
            }
            else
            {
                cls = classes.title;
            }
            string new_class_level = "";
            cls = cls.ToUpper();
            //Primary
            //Middle
            //Higher
            string temp;
            if (classes.class_level == "Primary")
            {
                new_class_level = "PRI";
                temp = id.ToString() + "-" + new_class_level + "-" + cls + "-" + lastTwoDigitsOfYear;
            }
            else if (classes.class_level == "Middle")
            {
                new_class_level = "MID";
                temp = id.ToString() + "-" + new_class_level + "-" + cls + "-" + lastTwoDigitsOfYear;
            }
            else if (classes.class_level == "Higher")
            {
                new_class_level = "HIGH";
                temp = id.ToString() + "-" + new_class_level + "-" + cls + "-" + lastTwoDigitsOfYear;
            }
            else
                temp = "*Class Level not set*";


            return temp;
        }
    }
}
