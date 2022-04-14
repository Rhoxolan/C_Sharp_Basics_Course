namespace program
{
    using System;
    using static MyClassLibrary.MyConsoleFunctional;

    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("Пожалуйста, выберите задание (1 или 2)\n0 - Выход\n\n");
                choice = NumberInput(0, 2);
                Console.Clear();
                if (choice > 1)
                {
                    Task2();
                }
                else if (choice > 0)
                {
                    Task1();
                }
            } while (choice != 0);
        }

        static void Task1()
        {
            Journal journal1 = new("Otdokhni", "Netherland");
            Journal journal2 = new("Mirovaya Aviacia", "France");
            try
            {
                journal1--;
            }
            catch (IndexOutOfRangeException IOOREX)
            {
                Console.WriteLine(IOOREX.Message);
                journal1.Default();
            }
            try
            {
                for (int i = 0; i < 10000; i++)
                {
                    journal2++;
                }
            }
            catch (IndexOutOfRangeException IOOREX)
            {
                Console.WriteLine(IOOREX.Message);
                journal2.Default();
            }
            for (int i = 0; i < 99; i++)
            {
                journal1++;
            }
            for (int i = 0; i < 94; i++)
            {
                journal2++;
            }
            if (journal2 < journal1)
            {
                Console.WriteLine($"{journal2} с коллективом {journal2.NumberOfEmployees} человек более меньшая компания, " +
                    $"чем {journal1} с коллективом {journal1.NumberOfEmployees} человек");
            }
            journal1.Default();
            journal2.Default();
            for (int i = 0; i < 99; i++)
            {
                journal1++;
                journal2++;
            }
            if (journal2 == journal1)
            {
                Console.WriteLine($"{journal2} с коллективом {journal2.NumberOfEmployees} человек == " +
                    $"{journal1} с коллективом {journal1.NumberOfEmployees} человек");
            }
            AnyKey();
        }

        static void Task2()
        {
            BooksList booksList = new BooksList();
            booksList.Add("Приключения Тома Сойера", "Марк Твен");
            booksList.Add("Незнайка на Луне", "Н. Носов");
            booksList.Add("Учения Дона Джонса", "Карл Кастанетер");
            Console.WriteLine($"Следующая книга для прочтения: {booksList[0]}");
            booksList[1] = new Book("Незнайка на Луне", "Николай Носов");
            Console.WriteLine($"Следующая книга для прочтения: {booksList[1]}");
            AnyKey();
        }
    }
}

// 5/5