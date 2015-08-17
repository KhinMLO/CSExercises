using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            int mark;
            Console.Write("Enter your mark : ");
            bool res = Int32.TryParse(Console.ReadLine(), out mark);
            if (res == true)
            {
                if (mark >= 0 && mark <= 100)
                {
                    if (mark >= 80 && mark <= 100)
                        Console.WriteLine("A");
                    else if (mark >= 60 && mark <= 79)
                        Console.WriteLine("B");
                    else if (mark >= 40 && mark <= 59)
                        Console.WriteLine("C");
                    else if (mark >= 0 && mark <= 39)
                        Console.WriteLine("F");
                }
                else
                    Console.WriteLine("Please enter your mark between 0 and 100.");
            }
            else
                Console.WriteLine("Please enter number for mark.");
        }
    }
}