using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int perfect_no, i;
            for (perfect_no = 1; perfect_no <= 1000; perfect_no++)
            {
                int sum = 0;
                for (i = 1; i < perfect_no; i++)
                {
                    if (perfect_no % i == 0)
                        sum = sum + i;
                }

                if (sum == perfect_no)
                   Console.WriteLine("Perfect number between 1 and 1000. ", perfect_no); 
            }
            Console.ReadLine(); 
               
        }
    }
}
