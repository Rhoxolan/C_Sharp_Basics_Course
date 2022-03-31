using System;

namespace program
{
    internal class MoneyOperations
    {
        private Money money = new();

        protected void AddMoney(int pennies)
        {
            money += pennies;
        }

        protected void SubstractMoney(int pennies)
        {
            money -= pennies;
        }

        protected int GetMoney()
        {
            return money.GetMoney();
        }
    }
}
