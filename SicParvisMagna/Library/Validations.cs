using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Library
{
    class Validations
    {
        public static int d;
        public static int y;
        public static int m;
        public bool isalpha_spcae(string valid)
        {
            int c = 0;
            char[] a = valid.ToCharArray();
            foreach (char t in a)
            {
                if (((t >= 65 && t <= 90)) || ((t >= 97 && t <= 122)) || (t == 32 || t == 45))
                {

                }
                else
                {
                    c++;
                }
            }
            return c < 1;
        }
        public bool isdigit_str(string valid)
        {
            int c = 0;
            char[] a = valid.ToCharArray();
            foreach (char t in a)
            {
                if ((t >= 48 && t <= 57))
                {

                }
                else
                {
                    c++;
                }
            }
            return c < 1;
        }
        public bool isdigit_str_marks(string valid)
        {
            int c = 0;
            int marks = 0;
            int.TryParse(valid, out marks);
            char[] a = valid.ToCharArray();
            foreach (char t in a)
            {
                if ((t >= 48 && t <= 57))
                {
                    if (marks > 0 && marks <= 100)
                    {

                    }
                    else
                    {
                        c++;
                    }
                }
                else
                {
                    c++;
                }
            }
            return c < 1;
        }
        public bool isalpha(char t)
        {
            int c = 0;

            if (((t >= 65 && t <= 90)) || ((t >= 97 && t <= 122)))
            {

            }
            else
            {
                c++;
            }

            return c < 1;
        }
        public bool isdigit(char t)
        {
            int c = 0;


            if ((t >= 48 && t <= 57))
            {

            }
            else
            {
                c++;
            }

            return c < 1;
        }
        public bool UserName(string valid)
        {
            int c = 0;
            char[] a = valid.ToCharArray();
            foreach (char t in a)
            {
                if (((t >= 65 && t <= 90)) || ((t >= 97 && t <= 122)) || (t >= 48 && t <= 57) || (t == 45) || t == 95)
                {


                }
                else
                {
                    c++;
                }

            }
            return c < 1;
        }

        public bool required(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        public string Phonum(string valid)
        {
            int max = 50, alphacount = 0, spacecount = 0, error = 0, PCODE = 0, PNUM = 0, digitcount = 0, codedetect = 0, s_lencount = 0;
            char[] NUM = valid.ToCharArray();
            string TNUM = null, reterror = null;
            string temp = null;
            for (int x = 0; x < NUM.Length; x++)
            {

                if (isdigit(NUM[x]))
                {
                    digitcount++;
                    temp += NUM[x].ToString();
                    if (digitcount == 4 && spacecount == 0 && codedetect == 0)
                    {
                        int.TryParse(temp, out PCODE);
                        codedetect = 1;
                        temp = "";
                    }
                    else if (codedetect == 1)
                    {
                        s_lencount++;
                        if (x == 11 || x == 10 && s_lencount == 7)
                            TNUM = temp;
                    }
                }
                else if (isalpha(NUM[x]))
                {
                    alphacount++;
                }
                if (NUM[x] == '-')
                {
                    spacecount++;
                    if (spacecount == 1 && digitcount == 4 && codedetect == 0)
                    {
                        int.TryParse(temp, out PCODE);
                        codedetect = 1;
                        temp = "";
                    }

                }
            }

            if (spacecount > 1)
            {
                error++;
                reterror = ". Only 1 hyphen(-) allow in the Number ";
            }
            if (alphacount > 0)
            {
                error++;
                reterror = ". Alphabet Not Allowed in Phone Number";
            }
            if (codedetect == 0)
            {
                error++;
                reterror = ". Invalid Code ";
            }
            if (spacecount == 1)
            {
                if (NUM.Length > 12 || NUM.Length < 12)
                {
                    error++;
                    reterror = ". In Phone Number Digits Length Should be 11 ";
                }
            }
            else if (spacecount == 0)
            {
                if (NUM.Length > 11 || NUM.Length < 11)
                {
                    error++;
                    reterror = ". In Phone Number Digits Length Should be 11 ";
                }
            }
            if (codedetect == 1)
            {
                if (PCODE >= 300 && PCODE <= 309)
                {
                    // cout << "Network is Moblink" << endl;
                }
                else if (PCODE >= 310 && PCODE <= 316)
                {
                    //  cout << "Network is Zong Pakistan" << endl;
                }
                else if (PCODE >= 320 && PCODE <= 324)
                {
                    // cout << "Network is Warid" << endl;
                }
                else if (PCODE >= 331 && PCODE <= 336)
                {
                    // cout << "Network is Ufone" << endl;
                }
                else if (PCODE >= 340 && PCODE <= 348)
                {
                    // cout << "Network is Telenor" << endl;
                }
                else if (PCODE == 355)
                {
                    //cout << "Network is SCO (Special Communications Organization)" << endl;
                }
                else if (PCODE == 364)
                {
                    //cout << "Network is Insta Phone " << endl;
                }
                else
                {
                    error++;
                    reterror = ". Invalid Network ";
                }
            }
            if (error == 0 && NUM.Length != 0)
            {
                reterror = "Valid";

                //cout << "Number: +92" << PCODE << " " << TNUM << endl;
                //cout << "Number is Valid" << endl;
            }
            if (NUM.Length == 0)
            {
                reterror = "Required";
            }
            return reterror;
        }
        public string LandLine(string valid)
        {
            int max = 50, codeNUM = 0, slashcount = 0, digitcount = 0, tcode = 0, Plahore_Code = 0, error = 0;
            bool codedetect = false, alphabetfound = false;
            char[] L_NUM = valid.ToCharArray();
            string temp = null, TNUM, ret = null;
            for (int x = 0; x < L_NUM.Length; x++)
            {
                digitcount = x + 1;
                if (isdigit(L_NUM[x]))
                {
                    temp += L_NUM[x];
                    if (L_NUM.Length == 11 && digitcount == 3 && slashcount == 0 && codedetect == false)
                    {
                        int.TryParse(temp, out codeNUM);
                        codedetect = true;
                        temp = "";
                        tcode = 1;
                    }
                    else if (L_NUM.Length == 9 && digitcount == 4 && slashcount == 0 && codedetect == false)
                    {
                        int.TryParse(temp, out codeNUM);
                        codedetect = true;
                        temp = "";
                        tcode = 1;
                    }
                    /*else if(L_NUM.length==12&&digitcount==4&&slashcount==0){
                    codeNUM=atoi(temp.c_str());
                    codedetect=true;
                    temp="";
                    tcode=2;
                    }*/
                    if (codedetect == true && codeNUM == 42)
                    {
                        if (L_NUM.Length == 11 && digitcount == 7)
                            int.TryParse(temp, out Plahore_Code);
                        else if (L_NUM.Length == 12 && digitcount == 8)
                            int.TryParse(temp, out Plahore_Code);
                    }
                    if (codedetect == true)
                    {
                        if (L_NUM.Length == 11 || L_NUM.Length == 12)
                        {
                            TNUM = temp;
                        }
                    }

                }
                else if (L_NUM[x] == '-')
                {
                    slashcount++;
                    if (slashcount == 1)
                    {
                        if (L_NUM.Length == 12 && digitcount == 4)
                        {
                            int.TryParse(temp, out codeNUM);
                            codedetect = true;
                            temp = "";
                            tcode = 1;
                        }
                        else if (L_NUM.Length == 10 && digitcount == 5)
                        {
                            int.TryParse(temp, out codeNUM);
                            codedetect = true;
                            temp = "";
                            tcode = 1;
                        }
                        /*else if(L_NUM.length==13&&digitcount==5){
                        codeNUM=atoi(temp.c_str());
                        codedetect=true;
                        temp="";
                        tcode=2;
                        }*/
                    }
                }
                else
                if (isalpha(L_NUM[x]))
                {
                    alphabetfound = true;
                }
            }
            if (slashcount > 1)
            {
                error++;
                ret = ". Only 1 hyphen(-) allow in the Number ";
            }
            if (codedetect == false)
            {
                error++;
                ret = ". Invalid Code ";
            }
            if (alphabetfound == true)
            {
                error++;
                ret = ". Alphabet not Allowed in Landline Number";
            }
            if (slashcount == 0 && (L_NUM.Length < 10 && L_NUM.Length > 8))
            {
                error++;
                ret = ". Digits Length should be 11 ";
            }
            if (slashcount == 1 && (L_NUM.Length < 11 && L_NUM.Length > 9))
            {
                error++;
                ret = ". Digits Length should be 11 ";
            }
            ////////////////////////////////////City Codes
            if (codedetect == true)
            {
                if (codeNUM == 21)
                {
                    ret = "Karachi";
                }
                else if (codeNUM == 51)
                {
                    ret = "Islamabad/Rwalpindi";
                }
                else if (codeNUM == 42)
                {
                    if (Plahore_Code == 3757)
                        ret = "Samnabad, Lahore";
                    else if (Plahore_Code == 3737)
                        ret = "Ali Park, Lahore";
                    else if (Plahore_Code == 3751)
                        ret = "Shahpur, Lahore";
                    else if (Plahore_Code == 3760)
                        ret = "Misrishah, Lahore";
                    else if (Plahore_Code == 3542)
                        ret = "Kamran Block, Lahore";
                    else if (Plahore_Code == 3576)
                        ret = "Pace, Lahore";
                    else if (Plahore_Code == 3584)
                        ret = "Barkat Market, Lahore";
                    else if (Plahore_Code == 3523)
                        ret = "CTH, Lahore";
                    else if (Plahore_Code == 3746)
                        ret = "Gulshan Ravi, Lahore";
                    else if (Plahore_Code == 3583)
                        ret = "Garden Town, Lahore";
                    else if (Plahore_Code == 3660)
                        ret = "Cannt, Lahore";
                    else if (Plahore_Code == 3574)
                        ret = "DHA, Lahore";
                    else if (Plahore_Code == 3780)
                        ret = "Kashmir Block, Lahore";
                    else if (Plahore_Code == 3516)
                        ret = "Faisal Town, Lahore";
                    else if (Plahore_Code == 3714)
                        ret = "Sanda, Lahore";
                    else if (Plahore_Code == 3799)
                        ret = "Murridkey, Lahore";
                    else if (Plahore_Code == 3784)
                        ret = "Multan Road, Lahore";
                    else if (Plahore_Code == 3514)
                        ret = "Mustafa Town, Lahore";
                    else if (Plahore_Code == 3534)
                        ret = "Bahria Town, Lahore";
                    else if (Plahore_Code == 3511)
                        ret = "Township, Lahore";
                    else if (Plahore_Code == 3531)
                        ret = "Johar Town, Lahore";
                    else if (Plahore_Code == 3582)
                        ret = "Ferozpur Road, Lahore";
                    else if (Plahore_Code == 3766)
                        ret = "Shahalam, Lahore";
                    else if (Plahore_Code == 3772)
                        ret = "Badami Bagh, Lahore";
                    else if (Plahore_Code == 3792)
                        ret = "Shahdra, Lahore";
                    else if (Plahore_Code == 3587)
                        ret = "Gulberg, Lahore";
                    else if (Plahore_Code == 3683)
                        ret = "Baghbanpura, Lahore";
                    else if (Plahore_Code == 3654)
                        ret = "Mominpura, Lahore";
                    else if (Plahore_Code == 663)
                        ret = "Guldasht, Lahore";
                    else if (Plahore_Code == 3210)
                        ret = "Brain Tel, Lahore";
                    else
                    {
                        ret = "Some where in Lahore";
                    }
                }
                else if (codeNUM == 41)
                {
                    ret = "Faislabad";
                }
                else if (codeNUM == 22)
                {
                    ret = "Hyderabad";
                }
                else if (codeNUM == 71)
                {
                    ret = "Sukhar";
                }
                else if (codeNUM == 81)
                {
                    ret = "Quetta";
                }
                else if (codeNUM == 91)
                {
                    ret = "Peshawar";
                }
                else if (codeNUM == 52)
                {
                    ret = "Sialkot";
                }
                else if (codeNUM == 966)
                {
                    ret = "Derra Ismail Khan";
                }
                else if (codeNUM == 64)
                {
                    ret = "Dera Ghazi Khan ";
                }
                else if (codeNUM == 53)
                {
                    ret = "Gujrat";
                }
                else if (codeNUM == 61)
                {
                    ret = "Multan";
                }
                else if (codeNUM == 62)
                {
                    ret = "Bhawalpur";
                }
                else if (codeNUM == 68)
                {
                    ret = "Rahim Yar Khan";
                }
                else if (codeNUM == 55)
                {
                    ret = "Gujranwala";
                }
                else if (codeNUM == 544)
                {
                    ret = "Jehlam/Mandi Bahauddin";
                }
                else if (codeNUM == 92)
                {
                    ret = "Parachina FATA";
                }
                else if (codeNUM == 48)
                {
                    ret = "Sargodha";
                }
                else if (codeNUM == 49)
                {
                    ret = "Kasur";
                }
                else if (codeNUM == 44)
                {
                    ret = "Okara";
                }
                else if (codeNUM == 57)
                {
                    ret = "Attock";
                }
                else if (codeNUM == 900)
                {
                    ret = "Premium Rate Services ";
                }
                else if (codeNUM == 800)
                {
                    ret = "Toll free Number";
                }
                else
                {
                    error++;
                    ret = ". Given Number Code Doesnot Belong to Any City of Pakistan";
                }

            }
            if (error == 0)
            {
                //ret = "+92"codeNUM" "TNUM;
                ret = "Valid";
            }
            if (L_NUM.Length == 0)
            {
                ret = "Required";
            }
            return ret;

        }

        public bool greaterdate(int y, int m, int d)
        {
            int count = 0;
            if (DateTime.Now.Year == y)
            {
                if (DateTime.Now.Month == m)
                {

                    if (DateTime.Now.Day < d)
                    { return false; }


                }
                else if (DateTime.Now.Month < m)
                {
                    return false;
                }

            }


            return true;
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SicParvisMagna.Library
//{
//    class Validations
//    {
//        public static int d;
//        public static int y;
//        public static int m;
//        public bool isalpha_spcae(string valid)
//        {
//            int c = 0;
//            char[] a = valid.ToCharArray();
//            foreach (char t in a)
//            {
//                if (((t >= 65 && t <= 90)) || ((t >= 97 && t <= 122)) || (t == 32 || t == 45))
//                {

//                }
//                else
//                {
//                    c++;
//                }
//            }
//            return c < 1;
//        }
//        public bool isdigit_str(string valid)
//        {
//            int c = 0;
//            char[] a = valid.ToCharArray();
//            foreach (char t in a)
//            {
//                if ((t >= 48 && t <= 57))
//                {

//                }
//                else
//                {
//                    c++;
//                }
//            }
//            return c < 1;
//        }
//        public bool isdigit_str_marks(string valid)
//        {
//            int c = 0;
//            int marks = 0;
//            int.TryParse(valid, out marks);
//            char[] a = valid.ToCharArray();
//            foreach (char t in a)
//            {
//                if ((t >= 48 && t <= 57))
//                {
//                    if (marks > 0 && marks <= 100)
//                    {

//                    }
//                    else
//                    {
//                        c++;
//                    }
//                }
//                else
//                {
//                    c++;
//                }
//            }
//            return c < 1;
//        }
//        public bool isalpha(char t)
//        {
//            int c = 0;

//            if (((t >= 65 && t <= 90)) || ((t >= 97 && t <= 122)))
//            {

//            }
//            else
//            {
//                c++;
//            }

//            return c < 1;
//        }
//        public bool isdigit(char t)
//        {
//            int c = 0;


//            if ((t >= 48 && t <= 57))
//            {

//            }
//            else
//            {
//                c++;
//            }

//            return c < 1;
//        }
//        public bool UserName(string valid)
//        {
//            int c = 0;
//            char[] a = valid.ToCharArray();
//            foreach (char t in a)
//            {
//                if (((t >= 65 && t <= 90)) || ((t >= 97 && t <= 122)) || (t >= 48 && t <= 57) || (t == 45) || t == 95)
//                {


//                }
//                else
//                {
//                    c++;
//                }

//            }
//            return c < 1;
//        }

//        public bool required(string value)
//        {
//            return !string.IsNullOrWhiteSpace(value);
//        }

//        public string Phonum(string valid)
//        {
//            int max = 50, alphacount = 0, spacecount = 0, error = 0, PCODE = 0, PNUM = 0, digitcount = 0, codedetect = 0, s_lencount = 0;
//            char[] NUM = valid.ToCharArray();
//            string TNUM = null, reterror = null;
//            string temp = null;
//            for (int x = 0; x < NUM.Length; x++)
//            {

//                if (isdigit(NUM[x]))
//                {
//                    digitcount++;
//                    temp += NUM[x].ToString();
//                    if (digitcount == 4 && spacecount == 0 && codedetect == 0)
//                    {
//                        int.TryParse(temp, out PCODE);
//                        codedetect = 1;
//                        temp = "";
//                    }
//                    else if (codedetect == 1)
//                    {
//                        s_lencount++;
//                        if (x == 11 || x == 10 && s_lencount == 7)
//                            TNUM = temp;
//                    }
//                }
//                else if (isalpha(NUM[x]))
//                {
//                    alphacount++;
//                }
//                if (NUM[x] == '-')
//                {
//                    spacecount++;
//                    if (spacecount == 1 && digitcount == 4 && codedetect == 0)
//                    {
//                        int.TryParse(temp, out PCODE);
//                        codedetect = 1;
//                        temp = "";
//                    }

//                }
//            }

//            if (spacecount > 1)
//            {
//                error++;
//                reterror = ". Only 1 hyphen(-) allow in the Number ";
//            }
//            if (alphacount > 0)
//            {
//                error++;
//                reterror = ". Alphabet Not Allowed in Phone Number";
//            }
//            if (codedetect == 0)
//            {
//                error++;
//                reterror = ". Invalid Code ";
//            }
//            if (spacecount == 1)
//            {
//                if (NUM.Length > 12 || NUM.Length < 12)
//                {
//                    error++;
//                    reterror = ". In Phone Number Digits Length Should be 11 ";
//                }
//            }
//            else if (spacecount == 0)
//            {
//                if (NUM.Length > 11 || NUM.Length < 11)
//                {
//                    error++;
//                    reterror = ". In Phone Number Digits Length Should be 11 ";
//                }
//            }
//            if (codedetect == 1)
//            {
//                if (PCODE >= 300 && PCODE <= 309)
//                {
//                    // cout << "Network is Moblink" << endl;
//                }
//                else if (PCODE >= 310 && PCODE <= 316)
//                {
//                    //  cout << "Network is Zong Pakistan" << endl;
//                }
//                else if (PCODE >= 320 && PCODE <= 324)
//                {
//                    // cout << "Network is Warid" << endl;
//                }
//                else if (PCODE >= 331 && PCODE <= 336)
//                {
//                    // cout << "Network is Ufone" << endl;
//                }
//                else if (PCODE >= 340 && PCODE <= 348)
//                {
//                    // cout << "Network is Telenor" << endl;
//                }
//                else if (PCODE == 355)
//                {
//                    //cout << "Network is SCO (Special Communications Organization)" << endl;
//                }
//                else if (PCODE == 364)
//                {
//                    //cout << "Network is Insta Phone " << endl;
//                }
//                else
//                {
//                    error++;
//                    reterror = ". Invalid Network ";
//                }
//            }
//            if (error == 0 && NUM.Length != 0)
//            {
//                reterror = "Valid";

//                //cout << "Number: +92" << PCODE << " " << TNUM << endl;
//                //cout << "Number is Valid" << endl;
//            }
//            if (NUM.Length == 0)
//            {
//                reterror = "Required";
//            }
//            return reterror;
//        }
//        public string LandLine(string valid)
//        {
//            int max = 50, codeNUM = 0, slashcount = 0, digitcount = 0, tcode = 0, Plahore_Code = 0, error = 0;
//            bool codedetect = false, alphabetfound = false;
//            char[] L_NUM = valid.ToCharArray();
//            string temp = null, TNUM, ret = null;
//            for (int x = 0; x < L_NUM.Length; x++)
//            {
//                digitcount = x + 1;
//                if (isdigit(L_NUM[x]))
//                {
//                    temp += L_NUM[x];
//                    if (L_NUM.Length == 11 && digitcount == 3 && slashcount == 0 && codedetect == false)
//                    {
//                        int.TryParse(temp, out codeNUM);
//                        codedetect = true;
//                        temp = "";
//                        tcode = 1;
//                    }
//                    else if (L_NUM.Length == 9 && digitcount == 4 && slashcount == 0 && codedetect == false)
//                    {
//                        int.TryParse(temp, out codeNUM);
//                        codedetect = true;
//                        temp = "";
//                        tcode = 1;
//                    }
//                    /*else if(L_NUM.length==12&&digitcount==4&&slashcount==0){
//                    codeNUM=atoi(temp.c_str());
//                    codedetect=true;
//                    temp="";
//                    tcode=2;
//                    }*/
//                    if (codedetect == true && codeNUM == 42)
//                    {
//                        if (L_NUM.Length == 11 && digitcount == 7)
//                            int.TryParse(temp, out Plahore_Code);
//                        else if (L_NUM.Length == 12 && digitcount == 8)
//                            int.TryParse(temp, out Plahore_Code);
//                    }
//                    if (codedetect == true)
//                    {
//                        if (L_NUM.Length == 11 || L_NUM.Length == 12)
//                        {
//                            TNUM = temp;
//                        }
//                    }

//                }
//                else if (L_NUM[x] == '-')
//                {
//                    slashcount++;
//                    if (slashcount == 1)
//                    {
//                        if (L_NUM.Length == 12 && digitcount == 4)
//                        {
//                            int.TryParse(temp, out codeNUM);
//                            codedetect = true;
//                            temp = "";
//                            tcode = 1;
//                        }
//                        else if (L_NUM.Length == 10 && digitcount == 5)
//                        {
//                            int.TryParse(temp, out codeNUM);
//                            codedetect = true;
//                            temp = "";
//                            tcode = 1;
//                        }
//                        /*else if(L_NUM.length==13&&digitcount==5){
//                        codeNUM=atoi(temp.c_str());
//                        codedetect=true;
//                        temp="";
//                        tcode=2;
//                        }*/
//                    }
//                }
//                else
//                if (isalpha(L_NUM[x]))
//                {
//                    alphabetfound = true;
//                }
//            }
//            if (slashcount > 1)
//            {
//                error++;
//                ret = ". Only 1 hyphen(-) allow in the Number ";
//            }
//            if (codedetect == false)
//            {
//                error++;
//                ret = ". Invalid Code ";
//            }
//            if (alphabetfound == true)
//            {
//                error++;
//                ret = ". Alphabet not Allowed in Landline Number";
//            }
//            if (slashcount == 0 && (L_NUM.Length < 10 && L_NUM.Length > 8))
//            {
//                error++;
//                ret = ". Digits Length should be 11 ";
//            }
//            if (slashcount == 1 && (L_NUM.Length < 11 && L_NUM.Length > 9))
//            {
//                error++;
//                ret = ". Digits Length should be 11 ";
//            }
//            ////////////////////////////////////City Codes
//            if (codedetect == true)
//            {
//                if (codeNUM == 21)
//                {
//                    ret = "Karachi";
//                }
//                else if (codeNUM == 51)
//                {
//                    ret = "Islamabad/Rwalpindi";
//                }
//                else if (codeNUM == 42)
//                {
//                    if (Plahore_Code == 3757)
//                        ret = "Samnabad, Lahore";
//                    else if (Plahore_Code == 3737)
//                        ret = "Ali Park, Lahore";
//                    else if (Plahore_Code == 3751)
//                        ret = "Shahpur, Lahore";
//                    else if (Plahore_Code == 3760)
//                        ret = "Misrishah, Lahore";
//                    else if (Plahore_Code == 3542)
//                        ret = "Kamran Block, Lahore";
//                    else if (Plahore_Code == 3576)
//                        ret = "Pace, Lahore";
//                    else if (Plahore_Code == 3584)
//                        ret = "Barkat Market, Lahore";
//                    else if (Plahore_Code == 3523)
//                        ret = "CTH, Lahore";
//                    else if (Plahore_Code == 3746)
//                        ret = "Gulshan Ravi, Lahore";
//                    else if (Plahore_Code == 3583)
//                        ret = "Garden Town, Lahore";
//                    else if (Plahore_Code == 3660)
//                        ret = "Cannt, Lahore";
//                    else if (Plahore_Code == 3574)
//                        ret = "DHA, Lahore";
//                    else if (Plahore_Code == 3780)
//                        ret = "Kashmir Block, Lahore";
//                    else if (Plahore_Code == 3516)
//                        ret = "Faisal Town, Lahore";
//                    else if (Plahore_Code == 3714)
//                        ret = "Sanda, Lahore";
//                    else if (Plahore_Code == 3799)
//                        ret = "Murridkey, Lahore";
//                    else if (Plahore_Code == 3784)
//                        ret = "Multan Road, Lahore";
//                    else if (Plahore_Code == 3514)
//                        ret = "Mustafa Town, Lahore";
//                    else if (Plahore_Code == 3534)
//                        ret = "Bahria Town, Lahore";
//                    else if (Plahore_Code == 3511)
//                        ret = "Township, Lahore";
//                    else if (Plahore_Code == 3531)
//                        ret = "Johar Town, Lahore";
//                    else if (Plahore_Code == 3582)
//                        ret = "Ferozpur Road, Lahore";
//                    else if (Plahore_Code == 3766)
//                        ret = "Shahalam, Lahore";
//                    else if (Plahore_Code == 3772)
//                        ret = "Badami Bagh, Lahore";
//                    else if (Plahore_Code == 3792)
//                        ret = "Shahdra, Lahore";
//                    else if (Plahore_Code == 3587)
//                        ret = "Gulberg, Lahore";
//                    else if (Plahore_Code == 3683)
//                        ret = "Baghbanpura, Lahore";
//                    else if (Plahore_Code == 3654)
//                        ret = "Mominpura, Lahore";
//                    else if (Plahore_Code == 663)
//                        ret = "Guldasht, Lahore";
//                    else if (Plahore_Code == 3210)
//                        ret = "Brain Tel, Lahore";
//                    else
//                    {
//                        ret = "Some where in Lahore";
//                    }
//                }
//                else if (codeNUM == 41)
//                {
//                    ret = "Faislabad";
//                }
//                else if (codeNUM == 22)
//                {
//                    ret = "Hyderabad";
//                }
//                else if (codeNUM == 71)
//                {
//                    ret = "Sukhar";
//                }
//                else if (codeNUM == 81)
//                {
//                    ret = "Quetta";
//                }
//                else if (codeNUM == 91)
//                {
//                    ret = "Peshawar";
//                }
//                else if (codeNUM == 52)
//                {
//                    ret = "Sialkot";
//                }
//                else if (codeNUM == 966)
//                {
//                    ret = "Derra Ismail Khan";
//                }
//                else if (codeNUM == 64)
//                {
//                    ret = "Dera Ghazi Khan ";
//                }
//                else if (codeNUM == 53)
//                {
//                    ret = "Gujrat";
//                }
//                else if (codeNUM == 61)
//                {
//                    ret = "Multan";
//                }
//                else if (codeNUM == 62)
//                {
//                    ret = "Bhawalpur";
//                }
//                else if (codeNUM == 68)
//                {
//                    ret = "Rahim Yar Khan";
//                }
//                else if (codeNUM == 55)
//                {
//                    ret = "Gujranwala";
//                }
//                else if (codeNUM == 544)
//                {
//                    ret = "Jehlam/Mandi Bahauddin";
//                }
//                else if (codeNUM == 92)
//                {
//                    ret = "Parachina FATA";
//                }
//                else if (codeNUM == 48)
//                {
//                    ret = "Sargodha";
//                }
//                else if (codeNUM == 49)
//                {
//                    ret = "Kasur";
//                }
//                else if (codeNUM == 44)
//                {
//                    ret = "Okara";
//                }
//                else if (codeNUM == 57)
//                {
//                    ret = "Attock";
//                }
//                else if (codeNUM == 900)
//                {
//                    ret = "Premium Rate Services ";
//                }
//                else if (codeNUM == 800)
//                {
//                    ret = "Toll free Number";
//                }
//                else
//                {
//                    error++;
//                    ret = ". Given Number Code Doesnot Belong to Any City of Pakistan";
//                }

//            }
//            if (error == 0)
//            {
//                //ret = "+92"codeNUM" "TNUM;
//                ret = "Valid";
//            }
//            if (L_NUM.Length == 0)
//            {
//                ret = "Required";
//            }
//            return ret;

//        }

//        public bool greaterdate(int y, int m, int d)
//        {
//            int count = 0;
//            if (DateTime.Now.Year == y)
//            {
//                if (DateTime.Now.Month == m)
//                {

//                    if (DateTime.Now.Day < d)
//                    { return false; }


//                }
//                else if (DateTime.Now.Month < m)
//                {
//                    return false;
//                }

//            }


//            return true;
//        }



//    }
//}
