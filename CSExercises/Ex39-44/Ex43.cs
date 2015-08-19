using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            string result;
            Console.WriteLine("Hexadecimal value from Hex function ....");
            for (int i = 1; i <= 100; i++)
            {
                result = Hex(i);
                Console.WriteLine("Hexadecimal value for {0} is {1}.", i, result);
            }

            Console.WriteLine("Hexadecimal value from built in function ....");
            for (int i = 0; i <= 100; i++)
            {
                string str = i.ToString("X");
                Console.WriteLine("Hexadecimal value for {0} is {1}.", i, str);
            }
        }
        public static string Hex(int i)
        {
            int hex = i + (i * 16);
            string res = hex + "";
            return res;
        }
    }
}
