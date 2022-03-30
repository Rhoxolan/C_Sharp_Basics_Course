namespace program
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Простой человек {Name} в возрасте {Age}";
        }
    }

    internal class Builder : Human
    {
        public string Qualification { get; set; }

        public int Salary { get; set; }

        public Builder(string name, int age, string qualification, int salary) : base(name, age)
        {
            Qualification = qualification;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Строитель-{Qualification} {Name} с зарплаттой {Salary} в возрасте {Age}";
        }
    }

    internal class Pilot : Human
    {
        public string Speciality { get; set; }

        public string WorkingPlane { get; set; }

        public int Salary { get; set; }

        public Pilot(string name, int age, string speciality, string working_plane, int salary) : base(name, age)
        {
            Speciality = speciality;
            WorkingPlane = working_plane;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Летчик {Name} в возрасте {Age}, работающий в сфере {Speciality}, имеющий рабочий самолёт {WorkingPlane}, " +
                $"получающий зарплату {Salary}";
        }

    }
}
