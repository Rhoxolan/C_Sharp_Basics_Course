namespace program
{
    using System;

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }
        private string Addiction { get; set; }

        public override string ToString()
        {
            return $"{Profession} {Name}, {Age}";
        }
    }

    public class Collective
    {
        Person[] people;

        public Collective(int size)
        {
            people = new Person[size];
        }
        public int Length
        {
            get { return people.Length; }
        }

        public Person this[int index]
        {
            get
            {
                if (index < 0 && index > people.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return people[index];
            }
            set
            {
                if (index < 0 && index > people.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                people[index] = value;
            }
        }
    }
}
