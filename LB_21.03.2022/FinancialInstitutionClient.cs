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

        public void HirePurchase(int months)
        {
            try
            {

                Money credit_money = new(money);
                credit_money /= months;
                decimal moneyValue = (decimal)credit_money.GetMoney() / 100;
                Console.WriteLine(string.Format("Регулярный платеж {0} на {1} месяцев - {2:F2} USD", name, months, moneyValue));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
