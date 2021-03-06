using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] marks = new int[12, 4] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            int subj = marks.GetLength(0);
            int std = marks.GetLength(1);
            int sum;

            //To compute the total marks for each student
            for(int i=0;i<subj;i++)
            {
                sum = 0;
                for(int j=0;j<std;j++)
                {
                    sum += marks[i, j];
                }
                Console.WriteLine("Total marks of each student is {0}.",sum);
            }

            //To compute the class average and standard deviation of Marks for each subject
            double avg=0;
            for (int i = 0; i < std; i++)
            {
                sum = 0;
                for (int j = 0; j < subj; j++)
                {
                    sum += marks[j, i];
                    avg = sum / 12.0;
                }
                Console.WriteLine("Average class and standard deviation of Mark is {0:0.000}.", avg);
            }

            //To compute the overall average of marks
            sum = 0;
            avg = 0;
            for (int i = 0; i < std; i++)
            {
                for (int j = 0; j < subj; j++)
                {
                    sum += marks[j, i];
                }
            }
            avg = sum / 48.0;
            Console.WriteLine("Overall Average class of Mark is {0:0.000}.", avg);
        }
    }
}
