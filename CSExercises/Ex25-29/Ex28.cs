using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int i, count = 0;
            Console.Write("Enter a number : ");
            int PrimeNo = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= PrimeNo; i++)
            {
                if (PrimeNo % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
                Console.WriteLine("{0} is prime number.",PrimeNo);
            else
                Console.WriteLine("{0} is not prime number.", PrimeNo);
        }
    }
}
