using System;
using System.Collections.Generic;

namespace anonymousschoolroaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Random students = new Random();
            // Console.Write(students.Next(1, 21));
            List<int> score = new List<int>();

            for (int i = 0; i < students.Next(1, 21); i++)
            {
                score.Add(students.Next(1, 100));
            }

            Console.WriteLine("1) Total Number of students that participated in the Exam: " + score.Count + ".");

            int passedStudents = 0;
            int averageStudents = 0;
            int failedStudents = 0;

             for(int i = 0; i < score.Count; i++)
            {
                if(score[i] > 70)
                {
                    passedStudents++;
                }

                if(score[i] >= 50 && score[i] < 70)
                {
                    averageStudents++;
                }

                if(score[i] < 40)
                {
                    failedStudents++;
                }
            }

            Console.WriteLine("2) Total number of students that passed above 70: " + passedStudents + ".");
           
            Console.WriteLine("3) Total number of students that got an average score: " + averageStudents + ".");
            
            Console.WriteLine("4) Total number of students that failed: " + failedStudents + ".");
           
          
        }
    }
}
