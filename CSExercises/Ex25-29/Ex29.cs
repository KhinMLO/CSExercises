using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int perfect_no, i, sum = 0;
            Console.Write("Enter a number to check perfect number or not : ");
            bool res = Int32.TryParse(Console.ReadLine(),out perfect_no);

            if (res == true)
            {
                for (i = 1; i < perfect_no; i++)
                {
                    if (perfect_no % i == 0)
                        sum = sum + i;
                }

                if (sum == perfect_no)
                    Console.WriteLine("{0} is perfect number.", perfect_no);
                else
                    Console.WriteLine("{0} is not perfect number.", perfect_no);
            }
            else
                Console.WriteLine("Please enter only number.");
        }
    }
}
