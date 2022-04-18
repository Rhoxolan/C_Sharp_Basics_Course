using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using System.Text.RegularExpressions;

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
                Console.WriteLine("Пожалуйста, выберите задание (1 - 5)\n0 - Выход\n\n");
                choice = NumberInput(0, 5);
                Console.Clear();
                if (choice > 4)
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
            } while (choice != 0);
        }

        static void Task1()
        {
            Console.WriteLine(GetMax(1, -7, 100));
            Console.WriteLine(GetMax(1m, -7m, 100m));
            Console.WriteLine(GetMax(-7, 100, 1));
            Console.WriteLine(GetMax((short)-7, (short)100, (short)-1));
            Console.WriteLine(GetMax((short)100, (short)100, (short)-1));
            Console.WriteLine(GetMax((short)0, (short)0, (short)-1));
            AnyKey();
        }

        static void Task2()
        {
            Console.WriteLine(GetMin(1, -7, 100));
            Console.WriteLine(GetMin(1m, -7m, 100m));
            Console.WriteLine(GetMin(-7, 100, 1));
            Console.WriteLine(GetMin((short)-7, (short)100, (short)-1));
            Console.WriteLine(GetMin((short)100, (short)100, (short)-1));
            Console.WriteLine(GetMin((short)0, (short)0, (short)-1));
            AnyKey();
        }

        static void Task3()
        {
            MyList<CalcInt> list = new();
            list.Add(new CalcInt(10));
            list.Add(new CalcInt(7));
            list.Add(new CalcInt(8));
            list.Add(new CalcInt(4));
            list.Add(new CalcInt(2));
            Console.WriteLine(list.Sum());
            AnyKey();
        }

        static void Task4()
        {
            MyStack<byte> bytestack = new();
            bytestack._Push(1);
            bytestack._Push(2);
            bytestack._Push(3);
            Console.WriteLine(bytestack._Peek());
            AnyKey();
        }

        static void Task5()
        {
            AnyKey();
        }

        static T GetMax<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            T max = num1;
            if (num2 is not null && num2.CompareTo(max) > 0)
            {
                max = num2;
            }
            if (num3 is not null && num3.CompareTo(max) > 0)
            {
                max = num3;
            }
            return max;
        }

        static T GetMin<T>(T num1, T num2, T num3) where T : IComparable<T>
        {
            T min = num1;
            if (num2 is not null && num2.CompareTo(min) < 0)
            {
                min = num2;
            }
            if (num3 is not null && num3.CompareTo(min) < 0)
            {
                min = num3;
            }
            return min;
        }

    }

    interface ICalc<T>
    {
        T Sum(T item);
    }

    class CalcInt : ICalc<CalcInt>
    {
        private int number;
        public CalcInt Sum(CalcInt item)
        {
            return new CalcInt(this.number + item.number);
        }

        public CalcInt(int num)
        {
            number = num;
        }

        public override string ToString()
        {
            return number.ToString();
        }
    }

    class MyList<T> where T: ICalc<T>
    {
        List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }


        public T Sum()
        {
            if (list.Count == 0)
                return default(T);
            T res = list[0];
            for (int i = 1; i < list.Count; i++)
                res = res.Sum(list[i]);
            return res;
        }
    }

    class MyStack<T>
    {
        private Stack<T> stack;

        public MyStack()
        {
            stack = new Stack<T>();
        }

        public T _Pop()
        {
            return stack.Pop();
        }

        public void _Push(T val)
        {
            stack.Push(val);
        }

        public T _Peek()
        {
            return stack.Peek();
        }

        public int _Count()
        {
            return stack.Count();
        }
    }
}