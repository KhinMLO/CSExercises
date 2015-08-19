using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a String.");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter a character to find form the string.");
            char chr1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a character that you want to replace.");
            char chr2 = Convert.ToChar(Console.ReadLine());
            string res = Substitute(str1, chr1, chr2);
            if (res == "")
                Console.WriteLine("Entered string doesn't contains character that you want to replace.");
            else
                Console.WriteLine("New form of string : " + res);
        }
        public static string Substitute(string s, char c1, char c2)
        {
            if (s.Contains(c1) == true)
            {
                s = s.Replace(c1, c2);
                return s;
            }
            else
                return "";
        }
    }
}
