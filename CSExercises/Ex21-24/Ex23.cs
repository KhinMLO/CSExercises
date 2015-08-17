using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random ran = new Random();
            int SecretNum = ran.Next(0, 10);
            int GuessNum;
            int count=0;
            do
            {
                count++;
                Console.Write("Think of a number : ");
                GuessNum = Convert.ToInt32(Console.ReadLine());
                if (GuessNum == SecretNum)
                {
                    Console.WriteLine("Congratulation!!");
                    Console.WriteLine("Total attempts : " + count);
                    if (count <= 2)
                        Console.WriteLine("You are a Wizard!");
                    else if (count > 2 && count <= 5)
                        Console.WriteLine("You are a good guess!");
                    else
                        Console.WriteLine("You are lousy!");
                }
                else
                    Console.WriteLine("Try again!");
            } while (SecretNum != GuessNum);
        }
    }
}
