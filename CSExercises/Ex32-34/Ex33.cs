using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int temp;
            int[] arr = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            Console.WriteLine("Descending Order..............");
            for(int i = 0; i<arr.Length-1;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write("{0} \t" , arr[i]);
            }
            Console.WriteLine();
        }
    }
}
