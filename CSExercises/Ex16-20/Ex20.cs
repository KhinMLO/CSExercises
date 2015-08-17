using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            double tv, dvd, mp3;
            double cost, dis;
            Console.Write("Enter quantity for TV : ");
            tv = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity for DVD : ");
            dvd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter quantity for MP3 : ");
            mp3 = Convert.ToDouble(Console.ReadLine());
            cost = tv + dvd + mp3;
            if (cost > 5000 && cost <= 10000)
            {
                dis = (tv + dvd) * 0.1;
                dis = cost - dis;
                Console.WriteLine("Total price for this order is {0:C}", dis);
            }
            else if (cost > 10000)
            {
                dis = (tv + dvd) * 0.15;
                dis = cost - dis;
                Console.WriteLine("Total price for this order is {0:C}", dis);
            }
            else
                Console.WriteLine("Total price for this order is {0:C}", cost);
            
        }
    }
}