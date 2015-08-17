using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            string name, gender, gen;
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.Write("Enter your gender (M/F) : ");
            gender = Console.ReadLine();
            if (gender.ToUpper() == "M")
            {
                gen = "Mr.";
                Console.WriteLine("Good Morning {0} {1}", gen, name);
            }
            else if (gender.ToUpper() == "F")
            {
                gen = "Ms.";
                Console.WriteLine("Good Morning {0} {1}", gen, name);
            }
            else
                Console.WriteLine("Please Enter M and F for \"gender\"");
        }
    }
}