using System;
using System.Collections.Generic;

namespace SchoolSchedule
{
    public class Estimation
    {
        public List<string> GetMarks(DateTime now, List<string> student)
        {
            List<string> people = new List<string>();

            Random rnd = new Random();

            for (int i = 0; i < student.Count; i++)
            {
                int[] numbers = { rnd.Next(2, 6), rnd.Next(2, 6), rnd.Next(2, 6), rnd.Next(2, 6), rnd.Next(2, 6), rnd.Next(2, 6), rnd.Next(2, 6), rnd.Next(2, 6), rnd.Next(2, 6), rnd.Next(2, 6) };
                int g = 0;
                for(int y = 0; y < 9; y++)
                {
                    g = g + numbers[y];
                }
                float z = g / numbers.Length;
                people.Add(student[i] + " - " + numbers[0] + ", " + numbers[1] + ", " + numbers[2] + ", " + numbers[3] + ", " + numbers[4] + ", " + numbers[5] + ", " + numbers[6] + ", " + numbers[7] + ", " + numbers[8] + ", " + numbers[9] + " = " + z);
            }

            return people;
        }
    }
}
