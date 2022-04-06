using System;
using System.Threading;
using static MyClassLibrary.MyConsoleFunctional;

namespace program
{
    internal class HeightDeterminant
    {
        private delegate void ShowHeight(string message, int val);
        private delegate void ShowMessage(string message);
        private static ShowHeight showHeight = HeightMessage;
        private static ShowMessage showMessage = Message;

        private static void HeightMessage(string message, int height)
        {
            string wait = "Рассчитываем ваш рост";
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                if (i != 0)
                    Console.WriteLine(wait += ".");
                else
                    Console.WriteLine(wait);
                Thread.Sleep(700);
            }
            Console.WriteLine();
            Console.WriteLine(message + height + " см!");
        }

        private static void Message(string message)
        {
            Console.WriteLine(message);
        }

        public static void Run()
        {
            showMessage("Добро пожаловать в программу-определитель вашего роста!\n" +
                "Пожалуйста, введите ваш рост: ");
            int height = NumberInput(0, 300);
            showHeight("Ваш Рост: ", height);
            showMessage("\nСпасибо за ипользование программы определителя-роста!");
        }
    }
}
