using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First String.");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Second String.");
            string str2 = Console.ReadLine();
            Console.WriteLine(InString(str1, str2));
        }

        public static bool InString(string s1, string s2)
        {
            if (s1.Contains(s2))
                return true;
            else
                return false;
        }
    }
}
