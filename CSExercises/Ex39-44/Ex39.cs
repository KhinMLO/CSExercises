﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    class Ex39
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number to calculate for factorial : ");
            double fac = Convert.ToDouble(Console.ReadLine());
            double facNum = Factorial(fac);
            Console.WriteLine("{0} for factorial is : {1}", fac, facNum);
        }
        public static double Factorial(double n)
        {
            double tot = 1;
            for (int i = 1; i <= n; i++)
            {
                tot = tot * i;
            }
            return tot;
        }
    }
}
