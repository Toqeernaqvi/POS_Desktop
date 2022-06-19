using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SicParvisMagna.Library
{
    class ValidationRegex
    {
        public bool alphasapce(string input, int min, int max)
        {
            string pattern = "^[A-Za-z ]{" + min + "," + max + "}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool alphanumeric(string input, int min, int max)
        {
            string pattern = "^[A-Za-z0-9,_-]{" + min + "," + max + "}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool numeric(string input, int min, int max)
        {
            string pattern = "^[0-9]{" + min + "," + max + "}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool Bank_account_number_pk(string input)
        {
            string pattern = "^[0-9]{6}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            pattern = "^[0-9]{9,17}$";
            result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            pattern = "^[0-9]{19,20}$";
            result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool Bank_account_number_iban(string input)
        {
            string pattern = @"^PK\d{2}[ -][a-zA-Z]{4}[ -]\d{4}[ -]\d{4}[ -]\d{4}[ -]\d{4}|PK\d{2}[a-zA-Z]{4}\d{16}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool National_Tax_Number(string input)
        {
            string pattern = @"^[0-9]{7}[-]{1}[0-9]{1}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool STRN(string input)
        {
            string pattern = @"^[0-9]{2}?[-]?[0-9]{2}?[-]?[0-9]{4}?[-]?[0-9]{3}?[-]?[0-9]{2}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool description(string input, int min, int max)
        {
            string pattern = "^[A-Za-z0-9.,_ ]{" + min + "," + max + "}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool address(string input)
        {
            string pattern = @"[a-zA-Z0-9 ,./\-]{15,50}";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool phoneno(string input)
        {
            //string pattern= @"preg_match_all(' / ([\(\+]) ? ([0 - 9]{ 1,3} ([\s]) ?)?([\+|\(|\-|\) |\s])?([0 - 9]{ 2,4})([\-|\) |\.|\s]([\s]) ?)?([0 - 9]{ 2,4})?([\.|\-|\s]) ? ([0 - 9]{ 4,8})/ ',$string, $phones);";
            string pattern = @"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool tel(string input)
        {
            string pattern = @"^\(?([0-9]{3})\)?[- ]?([0-9]{7,8})$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool Email(string input)
        {
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }

        public bool UAN_no(string input)
        {
            string pattern = @"^\(?([0-9]{3})\)?[-]?([0-9]{6})$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool grade(string input)
        {
            string pattern = "^[a-fA-F+-]{1,2}$";
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool password(string input)
        {
            string pattern = "^([a-zA-Z0-9@*#]{8,15})$";
            //Password must consists of at least 8 characters and not more than 15 characters.
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
        public bool CNIC(string input)
        {
            string pattern = @"^\(?([0-9]{5})\)?[-]?([0-9]{7})[-]?([0-9]{1})$";
            //Password must consists of at least 8 characters and not more than 15 characters.
            Match result = Regex.Match(input, pattern);
            if (result.Success)
            {
                return true;
            }
            return false;
        }
    }
}
