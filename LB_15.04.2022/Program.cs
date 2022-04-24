using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using System.Text.RegularExpressions;
using System.Text;

namespace program
{
    class Program
    {
        static void Main()
        {
            //Определение пути к папке документы
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Класс File
            {
                //Запись в файл текста с помощью класса File
                File.WriteAllText(Path.Combine(docPath, "File.txt"), "Строка");
                //Добавление текста в существующий файл без перезаписи с помощью класса File
                File.AppendAllText(Path.Combine(docPath, "File.txt"), "\nСтрока1\n");
                //Добавление целочисленного значения в существующий файл без перезаписи с помощью класса File
                File.AppendAllText(Path.Combine(docPath, "File.txt"), 1.ToString());

                //Считывание текста c файла с помощью класса File
                Console.WriteLine(File.ReadAllText(Path.Combine(docPath, "File.txt")));

                //Создаем, считываем и записываем ASCII фаил с помощью класса File
                File.WriteAllText(Path.Combine(docPath, "AsciiFile.txt"), "This is Ascii", Encoding.ASCII);
                Console.WriteLine(File.ReadAllText(Path.Combine(docPath, "AsciiFile.txt"), Encoding.ASCII));
            }


        }
    }
}