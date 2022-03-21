using System;

namespace Journals
{
    class Journal
    {
        string journalName;
        double _EuroPrice;

        public Journal(string journalName, double euroPrice)
        {
            this.journalName = journalName;
            _EuroPrice = euroPrice;
        }

        public string JournalName
        {
            get { return journalName; }
            set { journalName = value; }
        }

        public double EuroPrice
        {
            get { return _EuroPrice; }
            set { _EuroPrice = value; }
        }
    }
}
