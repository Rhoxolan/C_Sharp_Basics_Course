namespace PasportNamespace
{
    public class ForeignPassport
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string passportNumber { get; set; }

        public ForeignPassport(string name, string surname, string passportNumber)
        {
            this.name = name;
            this.surname = surname;
            this.passportNumber = passportNumber;
        }

    }
}
