using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a amount : ");
            double amt = Convert.ToDouble(Console.ReadLine());
            
            int num = (int)amt;
            if(num > 0)
                Console.WriteLine(num * 100 + "c");

            double Amount = amt * 100;
            int res = (int) Amount % 100 ;

            do
            {
                if (res >= 50)
                {
                    res -= 50;
                    Console.WriteLine("50c");
                }
                else if(res >= 16)
                {
                    res -= 20;
                    Console.WriteLine("20c");
                }
                else if(res >= 6)
                {
                    res -= 10;
                    Console.WriteLine("10c");
                }
                else 
                {
                    res -= 5;
                    Console.WriteLine("5c");
                }
            } while (res > 0);
        }
    }
}
