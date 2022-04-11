﻿using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using System.Drawing;

namespace program
{
    public delegate T _delegate<out T>();

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
                Console.WriteLine("Пожалуйста, выбирите задание (1 - 6)\n0 - Выход\n\n");
                choice = NumberInput(0, 6);
                Console.Clear();
                if (choice > 5)
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
            } while (choice != 0);
        }

        static void Task1()
        {
            _delegate<Color> toColor = delegate
            {
                Console.WriteLine("Пожалуйста, введите первый цвет (R) в формате RGB:");
                byte R = Convert.ToByte(NumberInput(0, 255));
                Console.WriteLine("Пожалуйста, введите второй цвет (G) в формате RGB:");
                byte G = Convert.ToByte(NumberInput(0, 255));
                Console.WriteLine("Пожалуйста, введите второй цвет (B) в формате RGB:");
                byte B = Convert.ToByte(NumberInput(0, 255));
                Color color = new();
                color = Color.FromArgb(R, G, B);
                return color;
            };
            Color color = toColor();
            AnyKey();
        }

        static void Task2()
        {
            AnyKey();
        }

        static void Task3()
        {
            AnyKey();
        }

        static void Task4()
        {
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
    }
}