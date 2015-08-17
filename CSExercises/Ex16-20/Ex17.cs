using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            string name, gender, gen;
            int age;
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.Write("Enter your gender (M/F) : ");
            gender = Console.ReadLine();
            Console.Write("Enter your age : ");
            //age =Convert.ToInt32(Console.ReadLine());
            bool res = Int32.TryParse(Console.ReadLine(), out age);
            if (res == true)
            {
                if (gender.ToUpper() == "M")
                {
                    if (age > 0 && age <= 40)
                    {
                        gen = "Mr.";
                        Console.WriteLine("Good Morning {0} {1}", gen, name);
                    }
                    else if (age > 40 && age < 120)
                    {
                        gen = "Uncle";
                        Console.WriteLine("Good Morning {0} {1}", gen, name);
                    }
                    else
                        Console.WriteLine("Your age is wrong.");
                }
                else if (gender.ToUpper() == "F")
                {
                    if (age > 0 && age < 40)
                    {
                        gen = "Ms.";
                        Console.WriteLine("Good Morning {0} {1}", gen, name);
                    }
                    else if (age > 40 && age < 120)
                    {
                        gen = "Aunty";
                        Console.WriteLine("Good Morning {0} {1}", gen, name);
                    }
                    else
                        Console.WriteLine("Your age is wrong.");
                }
                else
                    Console.WriteLine("Please Enter M and F for \"gender\"");
            }
            else
                Console.WriteLine("Please enter number for age.");
        }
    }
}