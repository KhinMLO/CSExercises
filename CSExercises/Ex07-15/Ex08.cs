using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double Cet;
            Console.Write("Enter temperature in Centigrate Scale ");
            Cet = Convert.ToInt32(Console.ReadLine());
            double Fah = 1.8 * Cet + 32;
            Console.WriteLine("Temperature in Fahrenheit is " + Fah);
        }
    }
}
