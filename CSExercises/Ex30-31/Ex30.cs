using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int i,j;
            for (j = 1; j <= 10000; j++ )
            {
                int count = 0;
                for (i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                    }
                }

                if (count==2 && j>=5)
                    Console.WriteLine(j);
            }
        }
    }
}
