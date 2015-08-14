using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double num;
            Console.Write("Enter number ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square root of the number is " + Math.Sqrt(num));
        }
    }
}