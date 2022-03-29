namespace program
{
    using WordOfTanks;
    using System;
    using static MyClassLibrary.MyConsoleFunctional;

    class Program
    {
        static void Main()
        {
            string[] tanks = {"AT-7", "AT-8", "AT-15", "FV215B 183", "Cromwell B",
                "Black Prince", "IS-2", "WZ-131G FT", "WZ-113G FT", "Type 64", "T69",
                "T37", "Tortoise", "FV217 Badger"};

            Random random = new Random();

            Tank[] comand1 =
            {
                new(1, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(2, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(3, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(4, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(5, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(6, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(7, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100))
            };

            Tank[] comand2 =
            {
                new(1, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(2, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(3, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(4, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(5, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(6, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100)),
                new(7, tanks[random.Next(0, tanks.Length)], (short)random.Next(0, 100), (short)random.Next(0, 100),
                (short)random.Next(0, 100))
            };

            short comand1_count = 7;
            short comand2_count = 7;
            while (true)
            {
                Console.WriteLine("Ваша команда\t\t\t\t\tКоманда соперника");
                for (int i = 0; i < 7; i++)
                {
                    if (comand1[i].Activity)
                    {
                        Console.Write(comand1[i]);
                    }
                    Console.Write("\t\t\t\t\t");
                    if (comand2[i].Activity)
                    {
                        Console.Write(comand2[i]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n\nПожалуйста, выберите ваш танк:");
                int choice1;
                while(true)
                {
                    choice1 = NumberInput(1, 7);
                    choice1--;
                    if (comand1[choice1].Activity)
                        break;
                    Console.WriteLine("\nЭтот танк уже уничтожен!\n");
                }
                Console.WriteLine("\n\nПожалуйста, выберите танк, который будем атаковать:");
                int choice2;
                while (true)
                {
                    choice2 = NumberInput(1, 7);
                    choice2--;
                    if (comand2[choice2].Activity)
                        break;
                    Console.WriteLine("\nЭтот танк уже уничтожен!\n");
                }
                if(comand1[choice1] * comand2[choice2])
                {
                    Console.WriteLine("Вражеский так уничтожен!");
                    comand2[choice2].Activity = false;
                    comand2_count--;
                    AnyKey();
                    if (comand2_count == 0)
                        break;
                }
                else
                {
                    Console.WriteLine("Ваш так уничтожен!");
                    comand1[choice1].Activity = false;
                    comand1_count--;
                    AnyKey();
                    if (comand1_count == 0)
                        break;
                }
            }
            if (comand2_count == 0)
            {
                Console.WriteLine("Поздравляем! Ваша команда одержала безоговорочную победу!");
            }
            else
            {
                Console.WriteLine("Ваша воманда проиграла!");
            }
        }
    }
}

// 5/5