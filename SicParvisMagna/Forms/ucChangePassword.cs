using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using SicParvisMagna.Models;
using SicParvisMagna.Controllers;
using SicParvisMagna.Library;

namespace SicParvisMagna.Forms
{
    public partial class ucChangePassword : UserControl
    {
        public ucChangePassword()
        {
            InitializeComponent();
        }
        //generate hash
        static string generateHash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private bool FormValidation()
        {
            bool validated = true;
            //for Password
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                lblErrorPassword.Text += "password is required!";
                validated = false;
            }
            else
            {
                lblErrorPassword.Text = "";
            }

            if (!Validation.isPassword(txtPassword.Text))
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                    lblErrorPassword.Text += "\n";
                lblErrorPassword.Text += "Password maximum 8 chraxcters";
                validated = false;
            }
            else
            {
                lblErrorPassword.Text = "";
            }
            //====================================================
            //For  Retype password
            if (string.IsNullOrEmpty(txtRetypePassword.Text))
            {
                lblErrorRetypePassword.Text += "Passowrd  required!";
                validated = false;
            }
            else
            {
                lblErrorRetypePassword.Text = "";
            }

            if (txtPassword.Text == txtRetypePassword.Text)
            {
                lblErrorRetypePassword.Text = "";
                ;
            }
            else
            {
                lblErrorRetypePassword.Text += "Password  doesn't match";
                validated = false;
            }
            //
            return validated;
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                string oldpassword = generateHash(txtOldPassword.Text);
                string newpassword = generateHash(txtRetypePassword.Text);
                UserBAL obj = new UserBAL();
                UserDAL objDAL = new UserDAL();
                obj.oldPassword = oldpassword;
                obj.password = newpassword;
                obj.User_id = Guid.Empty;
                objDAL.updateOldPassword(obj);
            }
        }
    }
}
