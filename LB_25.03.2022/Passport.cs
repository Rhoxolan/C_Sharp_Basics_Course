using System;
using MyClassLibrary;

namespace program
{
    internal class Passport
    {
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Patronymic { get; set; }
		public string Number { get; set; }
		public string Issuedby { get; set; }
		public int[] Date { get; set; }

        public Passport(string name, string surname, string patronymic, string number, string issuedby, int[] date)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Number = number;
            Issuedby = issuedby;
            Date = date;
        }
    }

    internal class ForeignPassport
    {
        public string FName { get; set; }
        public string FSurname { get; set; }
        public string FNumber { get; set; }
        public int[] FDate { get; set; }        
        List<string> visas;

        public ForeignPassport(string fNumber, int[] fDate, Passport passport)
        {
            FName = passport.Name;
            FSurname = passport.Surname;
            FNumber = fNumber;
            FDate = fDate;
            visas = new();
        }

        public void AddVisas(string Visa)
        {
            visas.Add(Visa);
        }

        public List<string> GetVisas()
        {
            return visas;
        }

    }

    internal class Person
    {
        public Passport passport;
        public ForeignPassport foreign_passport;

        public void AddPassport(string name, string surname, string patronymic, string number, string issuedby, int[] date)
        {
            passport = new(name, surname, patronymic, number, issuedby, date);
        }

        public void AddForeignPassport(string fNumber, int[] fDate)
        {
            if (passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет паспорта, он не может получить загран паспорт!");
            }
            foreign_passport = new ForeignPassport(fNumber, fDate, passport);
        }

        public string GetPassportName()
        {
            if (passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет паспорта!");
            }
            return passport.Name;
        }

        public string GetForeignPassportName()
        {
            if (foreign_passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет загранпаспорта!");
            }
            return foreign_passport.FName;
        }

        public string GetPassportSurname()
        {
            if (passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет паспорта!");
            }
            return passport.Surname;
        }

        public string GetForeignPassportSurname()
        {
            if (foreign_passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет загранпаспорта!");
            }
            return foreign_passport.FSurname;
        }

        public string GetPassportPatronymic()
        {
            if (passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет паспорта!");
            }
            return passport.Patronymic;
        }

        public string GetPassportNumber()
        {
            if (passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет паспорта!");
            }
            return passport.Number;
        }

        public string GetForeignPassportNumber()
        {
            if (foreign_passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет загранпаспорта!");
            }
            return foreign_passport.FNumber;
        }

        public string GetPassportIssuedBy()
        {
            if (passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет паспорта!");
            }
            return passport.Issuedby;
        }

        public int[] GetPassportDate()
        {
            if (passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет паспорта!");
            }
            return passport.Date;
        }

        public int[] GetForeignPassportDate()
        {
            if (foreign_passport is null)
            {
                throw new MyExceptionToString("У человека пока-что нет загранпаспорта!");
            }
            return foreign_passport.FDate;
        }

        public void AddVisas(string Visa)
        {
            foreign_passport.AddVisas(Visa);
        }

        public List<string> GetVisas()
        {
            return foreign_passport.GetVisas();
        }
    }

}
