using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double num;
            Console.Write("Enter Double Precision Number : ");
            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Double of {0} number is {1}", num, num * num);
        }
    }
}
