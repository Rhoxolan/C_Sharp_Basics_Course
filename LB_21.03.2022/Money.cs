namespace program
{
    public class Money
    {
        private int pennies;

        public static Money operator ++(Money money)
        {
            money.pennies++;
            return money;
        }

        public static Money operator --(Money money)
        {
            money.pennies--;
            return money;
        }

        public static Money operator +(Money money1, Money money2)
        {
            return new Money { pennies = money1.pennies + money2.pennies };
        }

        public static Money operator -(Money money1, Money money2)
        {
            return new Money { pennies = money1.pennies - money2.pennies };
        }

        public static Money operator *(Money money, int number)
        {
            money.pennies *= number;
            money.pennies *= number;
            return money;
        }

        public static Money operator *(int number, Money money)
        {
            return money * number;
        }

        public static Money operator /(Money money, int number)
        {
            if (number == 0)
            {
                throw new DivideByZeroException("Попытка деления на ноль!"); //Протестировать!
            }
            money.pennies /= number;
            money.pennies /= number;
            return money;
        }

        public static Money operator /(int number, Money money)
        {
            return money / number;
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Money money1, Money money2)
        {
            return money1.Equals(money2);
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !(money1 == money2);
        }

        public int GetMoney()
        {
            return pennies;
        }


    }
}
