using System;

namespace program
{
    internal record StudentMarks(string Name, List<int> Marks);

    internal static class StudentMarksExtension
    {
        public static (int Average, int Max) GetMarksInfo(this StudentMarks student)
        {
            int max = int.MinValue;
            int average = 0;
            foreach (var mark in student.Marks)
            {
                if (mark > max)
                {
                    max = mark;
                }
                average += mark;
            }
            return (average / student.Marks.Count, max);
        }
    }
}
