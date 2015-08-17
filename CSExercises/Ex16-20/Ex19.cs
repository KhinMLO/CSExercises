using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double cost = 2.4, dist;
            Console.Write("Enter distance by km : ");
            bool res = double.TryParse(Console.ReadLine(), out dist);
            double dist1 = Math.Ceiling(dist * 10);
            if(res == true)
            {
                if (dist1 > 90)
                {
                    cost = cost + (85 * 0.04) + ((dist1 - 90) * 0.05);
                    Console.WriteLine("Total cost of the distance {0:C}" , cost);
                }
                else if (dist1 > 0.5 && dist1 < 90)
                {
                    cost = cost + (85 * 0.04);
                    Console.WriteLine("Total cost of the distance {0:C}" , cost);
                }
                else
                    Console.WriteLine("Total cost of the distance {0:C}" , cost);
            }
            Console.WriteLine("Please enter only double value");
        }
    }
}