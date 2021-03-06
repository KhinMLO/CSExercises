using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Random ran = new Random();
            int[] arr = new int[10];
            for (int i = 0; i < 50; i++)
            {
                int num = ran.Next(0, 10);
                arr[num] = arr[num] + 1;
            }

            //Output for Part 1
            Console.WriteLine("Part 1");
            Console.WriteLine("Number \t Count");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + "\t" + arr[i].ToString().PadLeft(4));
            }

            //Output for Part 2
            Console.WriteLine("\nPart 2");
            Console.WriteLine("Number \t Count");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + "\t");
                int j = arr[i];
                for (int k = 0; k < j; k++)
                {
                    Console.Write("*");
                }                
                Console.WriteLine();
            }
        }
    }
}
