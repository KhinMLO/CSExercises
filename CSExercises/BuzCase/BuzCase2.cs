using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCase
{
    class BuzCase2
    {
        public static void Main(string[] args)
        {
            string[] address = new string[] { "1852 BLK 839", "1582 BLOCK 337D" };

            Console.WriteLine("Old Code".PadRight(15) + "New Code".PadLeft(10));
            Console.WriteLine("==============================");
            string[] split = new string[address.Length];
            for (int i = 0; i < split.Length; i++)
            {
                Console.Write(address[i].PadRight(15));
                split[i] = address[i].Substring(2, 2);
                string replace = address[i].Replace(" ", "");
                int index = replace.ToUpper().IndexOf("K");
                string str = replace.Substring(index + 1, 3);
                if (replace.Length - index == 4)
                {
                    split[i] += "0" + str;
                }
                else
                {
                    int num = blk(replace.Substring(replace.Length - 1, 1));
                    split[i] += num.ToString() + str;
                }
                Console.WriteLine(split[i].PadLeft(10));
            }
        }

        static int blk(string str)
        {
            int blkNo = 0;
            switch (str)
            {
                case "A": blkNo = 1; break;
                case "B": blkNo = 2; break;
                case "C": blkNo = 3; break;
                case "D": blkNo = 4; break;
                case "E": blkNo = 5; break;
                case "F": blkNo = 6; break;
                case "G": blkNo = 7; break;
                case "H": blkNo = 8; break;
            }
            return blkNo;
        }
    }
}
