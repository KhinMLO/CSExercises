using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            string[] str = new string[] { "a", "e", "i", "o", "u" };
            Console.Write("Please enter a phrase. ");
            string str1 = Console.ReadLine();
            string str2 = str1.ToLower();

            int count = 0;
            for(int i=0 ; i < str.Length ; i++)
            {
                for (int j = 0; j < str1.Length;j++ )
                {
                    if (str[i] == str2.Substring(j, 1))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Total number of vowels: "+count);

            
            for (int i = 0; i < str.Length; i++)
            {
                int c = 0;
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str[i] == str2.Substring(j, 1))
                    {
                        c++;
                    }
                }
                Console.WriteLine("Number of {0}: {1}",str[i],c);
            }
            
        }
    }
}
