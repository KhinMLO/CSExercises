using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First String.");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Second String.");
            string str2 = Console.ReadLine();
            int result = FindWord(str1, str2);
            if(result == -1)
                Console.WriteLine("Second string does not contain in First string.");
            else
                Console.WriteLine("Starting position of the Second string is " + result);
        }
        public static int FindWord(string s1, string s2)
        {
            int pos = 0;
            int len = s1.Length;
            s1 = s1.ToUpper().TrimEnd().TrimStart();
            s2 = s2.ToUpper().TrimEnd().TrimStart();

            if (s1.Length == s2.Length)
            {
                if (s2.CompareTo(s1.Substring(0, s2.Length)) == 0)
                {
                    pos = s1.IndexOf(s2);
                    return pos;
                }
                else
                    return -1;
            }
            else if (s1.Length > s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (len >= s2.Length)
                    {
                        len -= 1;
                        if (s2.CompareTo(s1.Substring(i, s2.Length)) == 0)
                        {
                            pos = s1.IndexOf(s2);
                            return pos;
                        }
                    }
                    else
                        return -1;
                }
                return -1;
            }
            else
                return -1;
        }
    }
}
