using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int num1, num2=0;
            Console.WriteLine("Enter three-digit integer : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = num ; i > 0; i = i/10)
            {
                num1 = i % 10;
                num2 = num2 + num1 * num1 * num1;
            }
            if(num2 == num)
                Console.WriteLine("This number is Armstrong Number ");
            else
                Console.WriteLine("This number is not Armstrong Number ");
        }
    }
}