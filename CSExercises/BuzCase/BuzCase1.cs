using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCase
{
    class BuzCase1
    {
        public static int count = 0;
        public static string[] unit = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        public static string[] ten = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public static void Main(string[] args)
        {
            double bill = 0;
            string retWord = "";
            Console.WriteLine("Please enter bill amount less than 10000.");
            bool result = double.TryParse(Console.ReadLine(), out bill);
            if (result)
            {
                if (bill > 10000)
                    Console.WriteLine("Please make sure your amount no more than 10000.");
                else
                {
                    string getWord = NumberToWord(bill);
                    retWord = getWord;
                    if (retWord == "Wrong")
                        Console.WriteLine("Bill amount cannot exceed 99 cents.");
                    else
                        Console.WriteLine(retWord + " only");
                    //Console.ReadLine();
                }
            }
            else
                Console.WriteLine("Please enter only number.");
        }

        static string NumberToWord(double number)
        {
            string word = "";
            int intPart = 0;
            int decPart = 0;

            if (number == 0)
                return "Zero";
            else if (number < 0)
                return "Minus " + NumberToWord(Math.Abs(number)).ToString();

            //try
            //{
            if (number.ToString().Contains('.'))
            {
                string[] splitter = number.ToString().Split('.');
                intPart = Int32.Parse(splitter[0]);
                word = IntPartToWords(intPart);
                decPart = Int32.Parse(splitter[1]);
                if (decPart > 99)
                {
                    return "Wrong";
                }
                else if (intPart > 0)
                    word += " and Cent " + DecPartToWords(decPart);
                else
                    word += "Cent " + DecPartToWords(decPart);
            }
            else
            {
                intPart = (int)number;
                word = IntPartToWords(intPart);
            }
            return word;
        }

        static string IntPartToWords(int number)
        {
            string word = "";
            if (number / 1000 > 0)
            {
                int num = number / 1000;
                word += IntPartToWords((number / 1000)) + " Thousand ";
                number %= 1000;
                count++;
            }

            if (number / 100 > 0)
            {
                word += IntPartToWords((number / 100)) + " Hundred";
                number %= 100;
                count++;
            }

            if (number > 0)
            {
                if (word != "") 
                    word += " and ";
                else if(word == "" && count == 0)
                    word += "Dollar ";

                if (number < 20)
                {
                    word += unit[number];
                }
                else
                {
                    word += ten[number / 10];
                    if (number % 10 > 0)
                    {
                        word += " " + unit[number % 10];
                    }

                }
            }

            return word;
        }

        static string DecPartToWords(int number)
        {
            string word = "";
            if (number > 0)
            {
                if (number < 20)
                {
                    word += unit[number];
                }
                else
                {
                    word += ten[number / 10];
                    if (number % 10 > 0)
                    {
                        word += " " + unit[number % 10];
                    }
                }
            }
            return word;
        }
    }
}
