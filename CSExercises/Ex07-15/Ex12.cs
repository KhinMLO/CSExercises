using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            double min = 2.4;
            double dist, tot;
            Console.Write("Enter Distance : ");
            dist = Convert.ToDouble(Console.ReadLine());
            tot = min * dist * 0.4;
            Console.WriteLine("Total fare is " + Math.Round(tot,2));
        }
    }
}
