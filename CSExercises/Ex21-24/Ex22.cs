using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A, B, C, lcm, hcf;
            string str;
            Console.Write("Enter a number for A : ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for B : ");
            B = Convert.ToInt32(Console.ReadLine());
            C = A * B;

            do
            {
                if (A > B)
                {
                    A = A - B;
                }
                else
                {
                    B = B - A;
                }

                if (A == B)
                {
                    str = "X";
                    hcf = A;
                    if(str == "X")
                    { 
                        Console.WriteLine("HCF : "+hcf);
                        lcm = C / hcf;
                        Console.WriteLine("LCM : "+lcm);
                    }
                }
                    
            } while (A != B);
        }
    }
}
