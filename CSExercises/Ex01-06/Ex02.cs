using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter integer number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0)
                Console.WriteLine("Please enter postive number.");
            else
                Console.WriteLine("Square of {0} is {1}.",num,num*num);
        }
    }
}
