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
            int zero=0,one=0,two=0,three=0,four=0,five=0,six=0,seven=0,eight=0,nine=0;
            for (int i = 0; i < 50; i++)
            {
                int num = ran.Next(0, 10);
                switch (num)
                {
                    case 0: arr[0] = zero++; break;
                    case 1: arr[1] = one++; break;
                    case 2: arr[2] = two++; break;
                    case 3: arr[3] = three++; break;
                    case 4: arr[4] = four++; break;
                    case 5: arr[5] = five++; break;
                    case 6: arr[6] = six++; break;
                    case 7: arr[7] = seven++; break;
                    case 8: arr[8] = eight++; break;
                    case 9: arr[9] = nine++; break;
                }
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
