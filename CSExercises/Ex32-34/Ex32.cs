using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int [] Sales = new int[12] ;
            int sum = 0,i;
            for (i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month {0} : ",i);
                Sales[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + Sales[i];
            }
            //To find maximum sales
            int num = Sales.Max();
            int max = Sales.ToList().IndexOf(num);
            Console.WriteLine("Maximum Sales : " + max);

            //To find minimum sales
            num = Sales.Min();
            int min = Sales.ToList().IndexOf(num);
            Console.WriteLine("Minimum Sales : " + min);

            //To find average sales
            int avg = 0;
            avg = sum / i;
            Console.WriteLine("Average Sales : " + avg);
        }
    }
}
