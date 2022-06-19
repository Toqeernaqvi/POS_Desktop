using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SicParvisMagna.Library
{
    static class Validation
    {

        //for Name
        public static bool isAlpha(string input, int range)
        {
            Regex reg = new Regex("[a-zA-Z -']{3," + range + "}$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }
        //for Email
        public static bool isEmail(string input)
        {
            Regex reg = new Regex("^[a-z0-9]{3,60}@(gmail.com)$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }

        //for Cnic
        public static bool isCnic(string input)
        {//removed hyphens
            Regex reg = new Regex("^[0-9+]{5}[0-9+]{7}[0-9]{1}$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }
        //for PhoneNumber
        public static bool isPhoneNumber(string input)
        {

            Regex reg = new Regex("^[0-9]{11}$");
            if (reg.IsMatch(input))
                return true;

            return false;

        }
        //for Website
        public static bool isWebsite(string input)
        {
            Regex reg = new Regex("^(www.)[a-zA-z0-9]{2,30}(.com|.pk|.org)$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }
        //for Adress
        public static bool isAdress(string input)
        {
            Regex reg = new Regex("^^[a-zA-Z0-9]+( [a-zA-Z0-9]+)*$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }
        //for Password
        public static bool isPassword(string input)
        {
            //("^(?=.*\d).{4,8}$");
            Regex reg = new Regex("^.{4,8}$");
            if (reg.IsMatch(input))
                return true;

            return false;

        }
        //for Degree
        public static bool isDegree(string input, int range)
        {
            Regex reg = new Regex("[a-zA-Z -']{3," + range + "}$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }
        //for Board
        public static bool isBoard(string input, int range)
        {
            Regex reg = new Regex("[a-zA-Z -']{3," + range + "}$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }
        //Numeric
        public static bool isNumber(string input)
        {

            Regex reg = new Regex("^[0-9]{2,7}$");
            if (reg.IsMatch(input))
                return true;

            return false;

        }

        //for Certifcate
        public static bool isCertifcate(string input, int range)
        {
            Regex reg = new Regex("[a-zA-Z -']{3," + range + "}$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }

        //for Division
        public static bool isDivison(string input, int range)
        {
            Regex reg = new Regex("[a-zA-Z -']{3," + range + "}$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }
        //for AlphaNumeric
        public static bool isAlphaNumeric(string input)
        {
            Regex reg = new Regex("^^[a-zA-Z0-9_]+( [a-zA-Z0-9_]+)*$");
            if (reg.IsMatch(input))
                return true;

            return false;
        }
    }
}
