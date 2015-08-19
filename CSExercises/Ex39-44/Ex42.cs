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
            Console.WriteLine("Position of the word is : " + FindWord(str1, str2));
        }
        public static int FindWord(string s1, string s2)
        {
            if(s1.Contains(s2))
            {
                int pos = 0;
                pos = s1.IndexOf(s2);
                return pos;
            }
            else
                return -1;
        }
    }
}
