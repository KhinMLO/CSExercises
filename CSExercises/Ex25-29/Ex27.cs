using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            int x, y=0;
            Console.WriteLine("X \t\t\t\t Y");
            Console.WriteLine("-------------------------------------------------------------");
            for (x = -4; x < 5; x++ )
            {
                y = 2 * (x * x) - 4 * x + 3;
                Console.WriteLine("Output of the value is {0} \t {1:0.0}" , x , y);
            }

            for (x = -4; x < 5; x++)
            {
                y = 2 * (x * x) - 4 * x + 3;
                for (int i = y; i >0 ; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
