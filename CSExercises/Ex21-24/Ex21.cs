using System;

namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int SecretNum = 88;
            int GuessNum;
            do
            {
                Console.Write("Enter a integer number : ");
                GuessNum = Convert.ToInt32(Console.ReadLine());
                if (SecretNum == GuessNum)
                    Console.WriteLine("Lucky you....");
                else
                    Console.WriteLine("Please enter another integer.");
            } while (SecretNum != GuessNum);
        }
    }
}
