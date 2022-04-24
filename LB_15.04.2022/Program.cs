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
                Console.WriteLine(File.ReadAllText(Path.Combine(docPath, "AsciiFile.txt"), Encoding.ASCII) + "\n\n");
            }

            //Класс FileStream
            {
                string text = "Текст FileStream";

                // запись в файл
                using (FileStream fstream = new FileStream(Path.Combine(docPath, "File2.txt"), FileMode.OpenOrCreate))
                {
                    byte[] buffer = Encoding.Default.GetBytes(text);
                    fstream.Write(buffer, 0, buffer.Length);
                }
                //Чтение из файла 
                using (FileStream fstream = File.OpenRead(Path.Combine(docPath, "File2.txt")))
                {
                    byte[] buffer = new byte[fstream.Length];
                    fstream.ReadAsync(buffer, 0, buffer.Length);
                    string textFromFile = Encoding.Default.GetString(buffer);
                    Console.WriteLine(textFromFile);
                }
            }

            //Класс StreamWriter
            {

            }
        }
    }
}