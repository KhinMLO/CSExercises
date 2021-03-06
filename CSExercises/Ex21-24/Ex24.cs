using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            int N;
            Console.Write("Enter a number : ");
            N = Convert.ToInt32(Console.ReadLine());

            double G = new Random().Next(1, N + 1);
            while (G*G != N)
            {
                G = (G + (N / G)) / 2;
                G = Math.Round(G, 5);
            } 
            Console.WriteLine("You got it!.");
        }
    }
}
