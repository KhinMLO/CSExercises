using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Enter Number for square root ");
            
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                number = 0;
            }

            if (number == 0)
                Console.WriteLine("Please enter only number");
            else
                Console.WriteLine("Squre root of the number is " + Math.Sqrt(number));
        }
    }
}
