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
            double sqrt;
            int N;
            int count = 0;
            Console.Write("Enter a number : ");
            N = Convert.ToInt32(Console.ReadLine());
            sqrt = Math.Sqrt(N);

            double G = new Random().Next(1, N + 1);
            while (G*G != N)
            {
                count++;
                G = (G + (N / G)) / 2;
                G = Math.Round(G, 5);
            } 
            Console.WriteLine("You got it!."+count);
        }
    }
}
