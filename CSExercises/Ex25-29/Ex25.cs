using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int fac;
            int num = 1;
            Console.Write("Enter a number to find factorial : ");
            bool res = Int32.TryParse(Console.ReadLine(), out fac);
            if (res == true)
            {
                for (int i = 1; i <= fac; i++)
                {
                    num = num * i;
                    if (i != fac)
                        Console.Write(i + "*");
                    else
                        Console.Write(i);
                }
                Console.WriteLine("="+num);

                num = 1;
                for (int i = fac; i > 0; i--)
                {
                    num = num * i;
                    if (i != 1)
                        Console.Write(i + "*");
                    else
                        Console.Write(i);
                }
                Console.WriteLine("=" + num);
            }
            else
                Console.WriteLine("Please enter only number.");
            Console.ReadLine();
        }
    }
}
