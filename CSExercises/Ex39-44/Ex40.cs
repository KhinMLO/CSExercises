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
            Console.WriteLine("Square root value from 1 to 25");
            for(int i =1 ;i <=25 ; i++)
            {
                double sqrt = SQT(i);
                Console.WriteLine("Square root of {0} is {1}", i, sqrt);
            }
        }

        public static double SQT(int y)
        {
            Random r = new Random();
            double x = r.NextDouble();
            x = x*(y-1);
            x=x+1;
            double sqrt = (x+(y/x))/2; //= Math.Pow(y, 0.5);
            return sqrt;
        }
    }
}
