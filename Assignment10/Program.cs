using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][]; //inititalising jagged array
            studentScores[0] = new int[3] { 85, 92, 78 };
            studentScores[1] = new int[4] { 90, 87, 93, 89 };
            studentScores[2] = new int[2] { 76, 88 };

            int count = 0, studAvg, studSum, totalAvg, totalSum = 0;

            for (int i = 0; i < studentScores.Length; i++) //nested loops used to display the scores
            {
                studSum = 0;
                Console.WriteLine("Scores of Student "+(i+1));
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                    studSum += studentScores[i][j];
                    totalSum += studentScores[i][j];
                    count++;
                }
                Console.WriteLine();
                studAvg = studSum / studentScores[i].Length; //calculation of the average scores of each student
                Console.WriteLine("Average Score of Student "+(i+1)+": "+studAvg);
                Console.WriteLine();
            }
            totalAvg = totalSum / count; //calculation of the average of all the scores
            Console.WriteLine("Average of all the scorse of all students "+totalAvg);
            Console.ReadKey();
        }
    }
}
