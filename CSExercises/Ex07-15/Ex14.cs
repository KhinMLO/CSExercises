using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c, s, area;
            Console.WriteLine("Enter the side a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the side b ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the side c ");
            c = Convert.ToDouble(Console.ReadLine());
            s = (a + b + c) / 2;
            Console.WriteLine("The area of the Triangle is " + s);
            area = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            Console.WriteLine("The area of the Triangle is " + area);
        }
    }
}