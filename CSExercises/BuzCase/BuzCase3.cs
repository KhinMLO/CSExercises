using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessCase
{
    class BuzCase3
    {
        public static void Main(string[] args)
        {
            string str;
            //string rev="";
            Console.Write("Consider the word : ");
            str = Console.ReadLine();
            if (str.Contains(' '))
                Console.WriteLine("Space cannot accept. Please try again!");
            else
            {
                //with pass by reference
                Encrypt(ref str);

            } 
        }

        static string StringReverse(string revStr)
        {
            char[] chrev = revStr.ToCharArray();
            Array.Reverse(chrev);
            return (new string (chrev));
        }

        //pass by reference without return 
        static void Encrypt(ref string str)
        {
            string s = "";
            var regexItem = new Regex("^[a-zA-Z0-9]*$");

            //check contain special character or not
            if (regexItem.IsMatch(str))
            {
                //Not contain Special Characters
                char[] charArr = str.ToCharArray();
                char[] nextChar = new char[charArr.Length];

                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == 'Z')
                    {
                        nextChar[i] = 'A';
                    }
                    else if (charArr[i] == 'z')
                    {
                        nextChar[i] = 'a';
                    }
                    else if (charArr[i] == '9')
                    {
                        nextChar[i] = '0';
                    }
                    else
                        nextChar[i] = (char)((int)charArr[i] + 1);

                    s += nextChar[i].ToString();
                }
            }
            else
                Console.WriteLine("Your information include special character. Please try again!");

            if (s != "")
            {
                Console.WriteLine("First Transformation : " + s);
                Console.WriteLine("Second Transformation : " + StringReverse(s));
            }
                
        }
    }
}
