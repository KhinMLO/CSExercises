using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("No \t INVERSE \t SQUARE ROOT \t SQUARE \t");
            Console.WriteLine("----------------------------------------------");
            for(int i=1 ; i<=10 ; i++)
            {
                Console.Write("{0:0.0} \t ", i);
                Console.Write("{0:0.0##} \t\t ", (1.0 / i));
                Console.Write("{0:0.0##} \t\t ", Math.Sqrt(i*1.0));
                Console.Write("{0:0.0} ", Math.Pow(i, 2));
                Console.WriteLine();
            }
        }
    }
}
