namespace program
{
    internal class FinancialInstitutionClient
    {
        public string name { get; set; }
        Money money;

        public FinancialInstitutionClient(string name)
        {
            this.name = name;
            money = new();
        }

        public void AddMoney(int pennies) //Указываем к-во в копейках
        {
            for (int i = 0; i < pennies; i++)
            {
                money++;
            }
        }

        public void SubstractMoney(int pennies) //Указываем к-во в копейках
        {
            for (int i = 0; i < pennies; i++)
            {
                money--;
            }
        }

        public void ShowMoneyInfo()
        {
            decimal moneyValue = (decimal)money.GetMoney() / 100;
            Console.WriteLine(string.Format("{0} has {1:F2} USD", name, moneyValue));
        }

        //public override bool Equals(object obj)
        //{
        //    return this.ToString() == obj.ToString();
        //}

        //public override int GetHashCode()
        //{
        //    return this.ToString().GetHashCode();
        //}

        public static bool operator ==(FinancialInstitutionClient client1, FinancialInstitutionClient client2)
        {
            return client1.money == client2.money;
        }

        public static bool operator !=(FinancialInstitutionClient client1, FinancialInstitutionClient client2)
        {
            return client1.money != client2.money;
        }


    }
}
