namespace program
{
    public class FinancialInstitutionClient
    {
        public string name { get; set; }
        Money money;

        public FinancialInstitutionClient(string name)
        {
            this.name = name;
            money = new();
        }

        public void AddMoney(int pennies)
        {
            for (int i = 0; i < pennies; i++)
            {
                money++;
            }
        }

        public void SubstractMoney(int pennies)
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

        public static void MoneyTransfer(FinancialInstitutionClient client1, FinancialInstitutionClient client2, int pennies)
        {
            client1.money -= pennies;
            client2.money += pennies;
        }

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
