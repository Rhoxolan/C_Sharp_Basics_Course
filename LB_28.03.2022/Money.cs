using System;

namespace program
{
    internal class Money
    {
        private int pennies = 0;

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

        public static Money operator +(Money money1, int number)
        {
            return new Money { pennies = money1.pennies + number };
        }

        public static Money operator -(Money money1, Money money2)
        {
            return new Money { pennies = money1.pennies - money2.pennies };
        }

        public static Money operator -(Money money1, int number)
        {
            return new Money { pennies = money1.pennies - number };
        }

        public static Money operator *(Money money, int number)
        {
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
                throw new DivideByZeroException("Попытка деления на ноль! Операция отброшена!");
            }
            money.pennies /= number;
            return money;
        }

        public static Money operator /(int number, Money money)
        {
            return money / number;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Money))
            {
                return false;
            }
            else
            {
                return pennies == ((Money)obj).pennies;
            }
        }

        public override int GetHashCode()
        {
            return pennies;
        }

        public static bool operator ==(Money money1, Money money2)
        {
            return Object.Equals(money1, money2);
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !Object.Equals(money1, money2);
        }

        public virtual int GetMoney()
        {
            return pennies;
        }

    }
}
