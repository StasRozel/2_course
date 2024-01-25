using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__8
{
      class WorkingStrings
    {
        public string RemoveCommas(string str)
        {
            string[] newStr = str.Split(',');

            str = String.Concat(newStr);

            return str;
        }

        public bool CheckEngChar(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                    return true;
            }

            return false;
        }

        public void RemoveExtraSpace(string str)
        {
            StringBuilder _string = new StringBuilder(str);

            for (int i = 0; i < _string.Length; i++)
            { 
                if (_string[i] == ' ')
                    while (_string[i+1] == ' ')
                    {
                        _string.Remove(i + 1, 1);
                    }
            }
            str = _string.ToString();
            Console.WriteLine(str);
        }

        public string FirstLetterCapitalized(string str)
        {
            string buffStr = "";

            for (int i = 0; i < str.Length; i++) 
            { 
                if (str[i] == ' ' && str[i + 1] != ' ')
                {
                    string symb = "";
                    symb += str[i + 1];
                    buffStr += str[i];
                    buffStr += symb.ToUpper();
                    i++;
                } else
                {
                    buffStr += str[i];
                }
            }

            return buffStr;
        }

        public string RemoveSpecialChar(string str)
        {
            StringBuilder _string = new StringBuilder(str);

            char[] specialChar = { '@', '#', '^', '&' };

            for (int i = 0; i < _string.Length; i++)
            {
                for (int j = 0; j < specialChar.Length; j++)
                {
                    if (specialChar[j] == _string[i])
                    {
                        _string.Remove(i, 1);
                        i--;
                    } 
                }
            }
            str = _string.ToString();   
            return str;
        }   
    }
}
