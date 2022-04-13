using System;

namespace program
{
    internal record Person(string Name, int Age);

    internal static class PersonListExtension
    {
        public static int MinAge(this List<Person> people)
        {
            int age = int.MaxValue;
            foreach(var p in people)
            {
                if(p.Age < age)
                {
                    age = p.Age;
                }
            }
            return age;
        }

        public static int MaxAge(this List<Person> people)
        {
            int age = int.MinValue;
            foreach (var p in people)
            {
                if (p.Age > age)
                {
                    age = p.Age;
                }
            }
            return age;
        }

        public static int AgeMean(this List<Person> people)
        {
            int average = 0;
            int count = 0;
            foreach (var p in people)
            {
                average += p.Age;
                count++;
            }
            return average / count;
        }
    }
}
