namespace PasportNamespace
{
    public class ForeignPassport
    {
        string name;
        string surname;
        string passportNumber;
        int[] dateIssue;

        string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
}
