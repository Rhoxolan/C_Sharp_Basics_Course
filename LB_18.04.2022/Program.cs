using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;

namespace program
{
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
                Console.WriteLine("Пожалуйста, выберите задание (1 - 3)\n0 - Выход\n\n");
                choice = NumberInput(0, 3);
                Console.Clear();
                if (choice > 2)
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
            } while (choice != 0);
        }

        static void Task1()
        {
            int[] values1 = new int[5] { 1, 10, 5, 13, 4 };
            int[] values2 = new int[5] { 19, 1, 4, 9, 8 };
            int[] values3 = values1.Concat(values2).ToArray();
            foreach (int value in values3)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            int[] values4 = values3.Where(x => x % 2 == 0).ToArray();
            int average = 0;
            foreach (int value in values4)
            {
                average += value;
            }
            average /= values4.Count();
            Console.WriteLine(average);
            AnyKey();
        }

        static void Task2()
        {
            List<Good> goods1 = new()
            {
                new Good(1, "Nokia 1100", 450.99, "Mobile"),
                new Good(2, "Iphone 4", 5000, "Mobile"),
                new Good(3, "Refregirator 500", 2555, "Kitchen"),
                new Good(4, "Mixer", 150, "Kitchen"),
                new Good(5, "Magnitola", 1499, "Car"),
            };
            List<Good> goods2 = new()
            {
                new Good(6, "Samsung Galaxy", 3100, "Mobile"),
                new Good(7, "Auto cleaner", 2300, "Car"),
                new Good(8, "Owen", 700, "Kitchen"),
                new Good(9, "Siemens Turbo", 3199, "Mobile"),
                new Good(10, "Lighter", 150, "Car"),
            };

            var goods = goods1.Concat(goods2).ToList(); //Соединяем два Листа путем методов расширения Concat и ToList
            foreach (Good good in goods)//Выводим на экран товары
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("\n__________\n");

            var newgoods = goods.Where(i => i.Price > 1000).ToList(); //Где цена больше 1000, вариант 1
            foreach (Good good in newgoods)
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("\n__________\n");

            var inewgoods = from g in goods  //Где цена больше 1000, вариант 2
                            where g.Price > 1000
                            select g;
            newgoods = inewgoods.ToList();
            foreach (Good good in newgoods)
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("\n__________\n");

            newgoods = goods.Where(i => i.Price > 1000 && i.Category != "Kitchen").ToList(); //Где цена больше 1000 и не "Kitchen" Вариант 1
            foreach (Good good in newgoods)
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("\n__________\n");

            inewgoods = from g in goods //Где цена больше 1000 и не "Kitchen" Вариант 2
                        where g.Price > 1000 & g.Category != "Kitchen"
                        select g;
            newgoods = inewgoods.ToList();
            foreach (Good good in newgoods)
            {
                Console.WriteLine(good);
            }
            Console.WriteLine("\n__________\n");

            double max = goods.Max(a => a.Price); //Поиск максимума (Вариант 1)
            var result = goods.FirstOrDefault(a => a.Price == max);
            Console.WriteLine("Max = " + max.ToString());
            Console.WriteLine("\n__________\n");

            newgoods = goods.OrderBy(i => i.Price).ToList();  //Поиск максимума (Вариант 2)
            max = newgoods[newgoods.Count - 1].Price;
            Console.WriteLine("Max = " + max.ToString());
            Console.WriteLine("\n__________\n");

            double average = goods.Average(a => a.Price); //Среднее значение цен
            Console.WriteLine("Average = " + average.ToString());
            Console.WriteLine("\n__________\n");

            List<string> categories = new(); //Выводим категории без повторений
            foreach (Good good in goods)
            {
                categories.Add(good.Category);
            }
            categories = categories.Distinct().ToList();
            foreach (string category in categories)
            {
                Console.Write(category + ' '.ToString());
            }
            Console.WriteLine("\n__________\n");

            foreach (Good i in goods) //Вывести названия тех товаров, цены которых совпадают.
            {
                foreach (Good j in goods)
                {
                    if (i.Price == j.Price)
                    {
                        Console.WriteLine(j.Title + " " + j.Price);
                    }
                }
                Console.WriteLine("\n");
            }

            var qwerty = goods.OrderBy(i => i.Title).ToList(); //Вывести названия и категории товаров в алфавитном порядке, упорядоченных по названию
            foreach (var i in qwerty)
            {
                Console.Write(i.Title + " ");
            }
            Console.WriteLine("\n__________\n");

            if (goods.Any(g => g.Price > 1000 && g.Price < 2000)) //Проверить, содержит ли категория Car товары, с ценой от 1000 до 2000 грн.
            {
                Console.WriteLine("\nСодержит категория Car товары с ценой от 1000 до 2000 грн.\n");
            }
            else
            {
                Console.WriteLine("\nНе содержит категория Car товары с ценой от 1000 до 2000 грн.\n");
            }
            Console.WriteLine("\n__________\n");

            int CarNMobile = goods.Count(i => i.Category == "Car" || i.Category == "Mobile"); //Посчитать суммарное количество товаров категорий Сar и Mobile
            Console.WriteLine("Товаров в категориях CarNMobile - " + CarNMobile);
            Console.WriteLine("\n__________\n");

            var cats = from g in goods //Вывести список категорий и количество товаров каждой категории
                       group g by g.Category;
            foreach (var cat in cats)
            {
                Console.WriteLine(cat.Key + ":");
                foreach (var good in cat)
                {
                    Console.WriteLine(good.Title);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n__________\n");
            AnyKey();
        }

        static void Task3()
        {
            List<Department> departments = new List<Department>()
            {
                new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
                new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
                new Department(){ Id = 3, Country = "France", City = "Paris" },
                new Department(){ Id = 4, Country = "Russia", City = "Moscow" }
            };
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
                new Employee() { Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
                new Employee() { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
                new Employee() { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
                new Employee() { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
                new Employee() { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
                new Employee() { Id = 7, FirstName = "Nikita", LastName = "Krotov", Age = 27, DepId = 4 }
            };

            //1) Упорядочить имена и фамилии сотрудников по алфавиту, которые проживают в Украине.Выполнить запрос немедленно.
            var namelist = employees.Where(e => e.DepId == 1 || e.DepId == 2).OrderBy(e => e.FirstName).OrderBy(e => e.LastName).ToList();
            foreach(var employee in namelist)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("\n__________\n");

            //2) Отсортировать сотрудников по возрастам, по убыванию.Вывести Id, FirstName, LastName, Age. Выполнить запрос немедленно.
            var agelist = employees.OrderByDescending(e => e.Age).ToDictionary(e => e.GetHashCode()); //Для эксперемента преобразуем в Dictionary
            foreach (var employee in agelist)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("\n__________\n");

            //3) Сгруппировать студентов по возрасту. Вывести возраст и сколько раз он встречается в списке.
            var agelist2 = employees.GroupBy(e => e.Age).OrderBy(i => i.Key); //Дополнительно сортируем по возрасту
            foreach (var age in agelist2)
            {
                Console.WriteLine(age.Key + ":");
                foreach (var employee in age)
                {
                    Console.WriteLine(employee.ToString());
                }
                Console.WriteLine();
            }
            AnyKey();
        }
    }

    public record Good(int Id, string Title, double Price, string Category);

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int DepId { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Id} {Age} {DepId}";
        }
    }
    class Department
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}