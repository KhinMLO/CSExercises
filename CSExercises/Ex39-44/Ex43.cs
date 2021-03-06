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
            for (int i = 0; i <= 100; i++)
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
            string hexVal = "";
            string str = "", str1 = "";
            if (i % 16 >= 10 && i / 16 < 10)
            {
                switch ((i % 16).ToString())
                {
                    case "10": str = "A"; break;
                    case "11": str = "B"; break;
                    case "12": str = "C"; break;
                    case "13": str = "D"; break;
                    case "14": str = "E"; break;
                    case "15": str = "F"; break;
                }
                if (i / 16 > 0)
                    hexVal = (i / 16).ToString() + str;
                else
                    hexVal = str;
            }
            else if (i / 16 >= 10 && i % 16 < 10)
            {
                switch ((i / 16).ToString())
                {
                    case "10": str = "A"; break;
                    case "11": str = "B"; break;
                    case "12": str = "C"; break;
                    case "13": str = "D"; break;
                    case "14": str = "E"; break;
                    case "15": str = "F"; break;
                }
                hexVal = str + (i % 16).ToString();
            }
            else if (i / 16 >= 10 && i % 16 >= 10)
            {
                switch ((i / 16).ToString())
                {
                    case "10": str = "A"; break;
                    case "11": str = "B"; break;
                    case "12": str = "C"; break;
                    case "13": str = "D"; break;
                    case "14": str = "E"; break;
                    case "15": str = "F"; break;
                }

                switch ((i % 16).ToString())
                {
                    case "10": str1 = "A"; break;
                    case "11": str1 = "B"; break;
                    case "12": str1 = "C"; break;
                    case "13": str1 = "D"; break;
                    case "14": str1 = "E"; break;
                    case "15": str1 = "F"; break;
                }
                hexVal = str + str1;
            }
            else
            {
                if (i / 16 > 0)
                    hexVal = (i / 16).ToString() + (i % 16).ToString();
                else
                    hexVal = (i % 16).ToString();
            }

            return hexVal;
        }

    }
}
