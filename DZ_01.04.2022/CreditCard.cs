﻿using System;
using MyClassLibrary;
using static MyClassLibrary.MyConsoleFunctional;

namespace CreditCardV1
{
    public delegate void Message(string message);

    internal class CreditCard
    {
        Message? message;

        public string? CardNumber { get; set; }

        public string? FullName { get; set; }

        public string? Date { get; set; }

        string? pin;
        int creditLimit;
        int moneyAmount;

        public CreditCard(string? cardNumber, string? fullName, string? date, string? pin)
        {
            message = null;
            CardNumber = cardNumber;
            FullName = fullName;
            Date = date;
            this.pin = pin;
            creditLimit = 0;
            moneyAmount = 0;
        }

        public int CreditLimit
        {
            set
            {
                creditLimit = value;
            }
        }

        public void RegisterHandler(Message mes)
        {
            message += mes;
        }

        public void UnregisterHandler(Message mes)
        {
            message -= mes;
        }

        public void AddMoney(int sum)
        {
            moneyAmount += sum;
            message?.Invoke($"На счет зачислено {sum} у.е.");
        }

        public void SubMoney(int sum)
        {
            if ((moneyAmount - sum) > (0 - creditLimit) ||
                (moneyAmount - sum) == (0 - creditLimit))
            {
                moneyAmount -= sum;
                message?.Invoke($"Со счета списано {sum} у.е.");
            }
            if ((moneyAmount - sum) < (0 - creditLimit))
            {
                message?.Invoke($"Недостаточно средств на счету!");
            }
            throw new MyExceptionToString("Неизветная ошибка!");
        }

        public void ShowMoney()
        {
            message?.Invoke($"На вашем счету {moneyAmount} у.е.\n" +
                $"Ваш кредитный лимит {creditLimit}");
        }

        public void SetPin()
        {
            message?.Invoke($"Пожалуйста, введите новый пин:");
            string? pin = Console.ReadLine();
            this.pin = pin;
            message?.Invoke($"Ваш pin успешно изменён!");
        }
    }
}
