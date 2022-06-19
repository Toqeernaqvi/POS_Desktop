using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicParvisMagna.Library
{
    class E_And_D
    {
        public string encode(string text)
        {
            byte[] mybyte = System.Text.Encoding.UTF8.GetBytes(text);
            string returntext = System.Convert.ToBase64String(mybyte);
            return returntext;
        }

        public string decode(string text)
        {
            byte[] mybyte = System.Convert.FromBase64String(text);
            string returntext = System.Text.Encoding.UTF8.GetString(mybyte);
            return returntext;
        }
    }
}
