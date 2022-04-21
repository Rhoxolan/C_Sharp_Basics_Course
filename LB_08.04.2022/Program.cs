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
            int[] intarr = { 1, 2, 3, 4, 5 };
            decimal[] marr = { -0.1m, 7m, 10.000000010m };
            Console.WriteLine($"Сумма элементов массива {intarr}: {GetArraySum(intarr)}");
            Console.WriteLine($"Сумма элементов массива {marr}: {GetArraySum(marr)}");
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

        static T GetArraySum<T>(T[] values) where T : INumber<T>
        {
            T sum = T.Zero;
            foreach(T value in values)
            {
                sum += value;
            }
            return sum;
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