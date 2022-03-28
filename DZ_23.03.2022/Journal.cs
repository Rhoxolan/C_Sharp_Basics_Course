namespace program
{
    using System;

    public class Journal
    {
        public string JournalName { get; set; }
        public string StateLegalAddress { get; set; }
        public int NumberOfEmployees { get; set; } = 1;

        public Journal(string journalName, string stateLegalAddress)
        {
            JournalName = journalName;
            StateLegalAddress = stateLegalAddress;
        }

        public static Journal operator ++(Journal journal)
        {
            if (journal.NumberOfEmployees == 10000)
            {
                throw new IndexOutOfRangeException("Не допускается работа более чем 10000-и человек!");
            }
            journal.NumberOfEmployees++;
            return journal;
        }

        public static Journal operator --(Journal journal)
        {
            if (journal.NumberOfEmployees == 1)
            {
                throw new IndexOutOfRangeException("В компании не может работать менее 1-го человека!");
            }
            journal.NumberOfEmployees--;
            return journal;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Journal))
            {
                return false;
            }
            else
            {
                return NumberOfEmployees == ((Journal)obj).NumberOfEmployees;
            }
        }

        public override int GetHashCode()
        {
            return NumberOfEmployees;
        }

        public static bool operator ==(Journal journal1, Journal journal2)
        {
            return Object.Equals(journal1, journal2);
        }

        public static bool operator !=(Journal journal1, Journal journal2)
        {
            return !Object.Equals(journal1, journal2);
        }

        public static bool operator >(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfEmployees > journal2.NumberOfEmployees;
        }

        public static bool operator <(Journal journal1, Journal journal2)
        {
            return !(journal1 > journal2);
        }

        public override string ToString()
        {
            return JournalName;
        }

        public void Default()
        {
            NumberOfEmployees = 1;
        }
    }
}
