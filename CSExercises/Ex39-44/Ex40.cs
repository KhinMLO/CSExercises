using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 25");
            int num = Convert.ToInt32(Console.ReadLine());
            double sqrt = SQT(num);
            Console.WriteLine("Square root of {0} is {1}", num, sqrt);
        }

        public static double SQT(int y)
        {
            
            return 0;
        }
    }
}
