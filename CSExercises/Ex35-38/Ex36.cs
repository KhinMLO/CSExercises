using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string str, str1;
            bool flag=false;
            Console.Write("Enter a phrase: ");
            str = Console.ReadLine();
            str1 = str.ToLower();
            //b
            char[] c = new char[] { '.', ';', '!', '&', '%', '/', ',', '\\',' '};
            for(int k = 0; k < str1.Length ; k++)
            {
                for (int l = 0; l < c.Length; l++ )
                {
                    if (c[l].ToString() == str1.Substring(k, 1))
                    {
                        str1 = str1.Replace(c[l].ToString(), "");
                        break;
                    }
                    
                }
            }

            int i = 0;
            int j = str1.Length - 1;
            do
            {
                if (str1[i] == str1[j])
                    flag = true;
                else
                {
                    flag = false;
                    break;
                }
                   
                i++;
                j--;
            } while (i < j);

            if (flag == true)
                Console.WriteLine("{0} is Palindrome.", str);
            else
                Console.WriteLine("{0} is not Palindrome.", str);
        }
    }
}
