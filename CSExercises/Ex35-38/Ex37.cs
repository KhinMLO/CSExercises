using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string str,s="";
            string str2 = "", str3 = "";
            Console.Write("Enter a sentence : ");
            str = Console.ReadLine();
            string[] str1 = str.Split(' ');
            
            for(int i =0; i < str1.Length ; i++)
            {
                str2 = str1[i];
                s = str2.Substring(0, 1).ToUpper() + str2.Substring(1,str2.Length - 1);
                str3 += s + " ";
            }
            Console.WriteLine(str3);
        }
    }
}
