using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter a value ");
            x = Convert.ToInt32(Console.ReadLine());
            y = 2 * (int) Math.Pow(x, 2) - 4 * x + 3;
            Console.WriteLine("Output of the value is " + y);
        }
    }
}
