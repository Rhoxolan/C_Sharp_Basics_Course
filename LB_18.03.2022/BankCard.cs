using System;

namespace Bank
{
    public class BankCard
    {
        public string full_name { get; set; }
        public string card_number { get; set; }
        List<int> dateto { get; set; }

        public BankCard(string full_name, string card_number, List<int> dateto)
        {
            this.full_name = full_name;
            this.card_number = card_number;
            this.dateto = dateto;
        }

    }
}
