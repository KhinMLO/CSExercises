using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] Name = new string[]{"John","Venkat","Mary","Victor","Betty"};
            int[] Mark = new int[] {63,29,75,82,55};
            int temp;

            Console.WriteLine("Sorted descending Order of the Marks...");
            for (int i = 0; i < Mark.Length - 1; i++)
            {
                for (int j = i + 1; j < Mark.Length; j++)
                {
                    if (Mark[i] < Mark[j])
                    {
                        temp = Mark[i];
                        Mark[i] = Mark[j];
                        Mark[j] = temp;
                    }
                }
                Console.WriteLine("{0} \t", Mark[i]);
            }

            string str="";
            Console.WriteLine("\nSorted student names alphabetically...");
            for (int i = 0; i < Name.Length - 1; i++)
            {
                for (int j = i + 1; j < Name.Length; j++)
                {
                    if (Name[i].CompareTo(Name[j]) == 1)
                    {
                        str = Name[i];
                        Name[i] = Name[j];
                        Name[j] = str;
                    }
                }
                Console.WriteLine("{0} \t", Name[i]);
            }
        }
    }
}
