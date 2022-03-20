using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        short choice;
        do
        {
            Console.WriteLine("Пожалуйста, выбирите задание (от 1-го до 7-и)\n0 - Выход\n\n");
            choice = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            if (choice > 7)
            {
                Console.WriteLine("Такого задания нет!");
                AnyKey();
            }
            else if (choice > 6)
            {
                Task7();
            }
            else if (choice > 5)
            {
                Task6();
            }
            else if (choice > 4)
            {
                Task5();
            }
            else if (choice > 3)
            {
                Task4();
            }
            else if (choice > 2)
            {
                Task3();
            }
            else if (choice > 1)
            {
                Task2();
            }
            else if (choice > 0)
            {
                Task1();
            }
            else if (choice < 0)
            {
                Console.WriteLine("Такого задания нет!");
                AnyKey();
            }
        } while (choice != 0);
    }

    static void Task1()
    {
        Console.WriteLine("Пожалуйста, введите начало диапазона: ");
        int left = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Пожалуйста, введите конец диапазона: ");
        int right = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Результат: {Multiplier(left, right)}");
        AnyKey();
    }

    static void Task2()
    {
        Console.WriteLine("Пожалуйста, введите ваше число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(IsFibonacci(num))
        {
            Console.WriteLine("Число Фибоначчи!");
        }
        else
        {
            Console.WriteLine("Число Не-Фибоначчи!");
        }
        AnyKey();
    }

    static void Task3()
    {
        Random rand = new Random();
        List<int> l = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            l.Add(rand.Next(-70, 95));
        }
        foreach (var i in l)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\nПожалуйста, выбрите:\n1 - отсортировать массив по убыванию" +
            "\n2 - отсортировать массив по возрастанию");
        short choice = Convert.ToInt16(Console.ReadLine());
        if (choice == 1)
        {
            l.Sort();
            l.Reverse();
            foreach (var i in l)
            {
                Console.Write(i + " ");
            }
        }
        if (choice == 2)
        {
            l.Sort();
            foreach (var i in l)
            {
                Console.Write(i + " ");
            }
        }
        if (choice != 1 && choice != 2)
        {
            Console.WriteLine("Ой, вы ошиблись!");
        }
        AnyKey();
    }

    static void Task4()
    {
        List<string> districts = new List<string>() { "City Centre", "North", "West", "Right-Bank" };
        Town town = new Town("Szczecin", "Poland", 401907, 4891, districts);
        Console.WriteLine($"Название города: {town.GetTownName()}");
        Console.WriteLine($"Название страны: {town.GetCountryName()}");
        Console.WriteLine($"Население: {town.GetPeopleAmount()}");
        Console.WriteLine($"Телефонный код: {town.GetNumberCode()}");
        Console.Write("Районы города: ");
        foreach(var district in town.GetDistricts())
        {
            Console.Write(district + "\t");
        }
        Console.WriteLine();
        AnyKey();
    }

    static void Task5()
    {
        AnyKey();
    }

    static void Task6()
    {
        AnyKey();
    }

    static void Task7()
    {
        AnyKey();
    }

    static long Multiplier(int left, int right)
    {
        long res = left;
        for (int i = left; i < right; i++)
        {
            res *= i;
        }
        return res;
    }

    static bool IsFibonacci(int num)
    {
        List<int> al = new List<int>();
        al.Add(0);
        al.Add(1);
        for (int i = 0; i < num; i++)
        {
            al.Add(al[al.Count - 1] + al[al.Count - 2]);
        }
        if(al.Contains(num))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void AnyKey()
    {
        Console.WriteLine("\nPress any key");
        Console.ReadKey();
        Console.Clear();
    }
}

class Town
{
    string townName;
    string countryName;
    int peopleAmount;
    int numberCode;
    List<string> districts;

    public Town(string townName, string countryName, int peopleAmount, int numberCode, List<string> districts)
    {
        this.townName = townName;
        this.countryName = countryName;
        this.peopleAmount = peopleAmount;
        this.numberCode = numberCode;
        this.districts = districts;
    }

    public string GetTownName()
    {
        return townName;
    }

    public string GetCountryName()
    {
        return countryName;
    }

    public int GetPeopleAmount()
    {
        return peopleAmount;
    }

    public int GetNumberCode()
    {
        return numberCode;
    }

    public List<string> GetDistricts()
    {
        return districts;
    }
}