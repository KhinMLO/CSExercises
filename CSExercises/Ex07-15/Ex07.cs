﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double sal;
            double house;
            double tran;
            double income;
            Console.Write("Enter your salary : ");
            sal = Convert.ToDouble(Console.ReadLine());
            house = (sal / 100) * 10;
            tran = (sal / 100) * 3;
            income = sal + house + tran;
            Console.WriteLine("Your total income is {0:C}" , income);
        }
    }
}
