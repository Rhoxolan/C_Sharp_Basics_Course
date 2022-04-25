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

            //Классы StreamWriter и StreamReader
            {
                //Запись
                using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, "File3.txt"), false)) //false - файл перезаписывается заново
                {
                    writer.WriteLine("Строка");
                    writer.Write("Без строки");
                    writer.WriteLine("Строка");
                }
                //Добавление
                using (StreamWriter writer = new StreamWriter(Path.Combine(docPath, "File3.txt"), true)) //true - файл не перезаписывается заново
                {
                    writer.WriteLine("Строка");
                }
                //Чтение
                using (StreamReader reader = new StreamReader(Path.Combine(docPath, "File3.txt")))
                {
                    string text = reader.ReadToEnd();
                    Console.WriteLine(text);
                }
                //Чтение
                using (StreamReader reader = new StreamReader(Path.Combine(docPath, "File3.txt")))
                {
                    List<string> lines = new();
                    string? buf;
                    while ((buf = reader.ReadLine()) != null)
                    {
                        lines.Add(buf.ToString());
                    }
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("End lines\n\n");
                }
            }

            //Классы BinaryWriter и BinaryReader
            {
                //Запись
                using (BinaryWriter writer = new BinaryWriter(File.Open(Path.Combine(docPath, "BinFile.dat"), FileMode.OpenOrCreate)))
                {
                    writer.Write("Bin Строка");
                }
                //Считывание
                using (BinaryReader reader = new BinaryReader(File.Open(Path.Combine(docPath, "BinFile.dat"), FileMode.Open)))
                {
                    // считываем из файла строку
                    string _str = reader.ReadString();
                    Console.WriteLine(_str);
                }
            }

            //Задание 1 (Lab_16)
            {
                int[,] ints = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
                double[,] doubles = { { 1.5, 2.5 }, { 3.5, 4.5 }, { 5.5, 6.5 } };
                string family = "family";
                string name = "name";
                string patronymic = "patronymic";
                DateTime dateOfBirth = new(1990, 1, 1);

                try
                {
                    FileStream fs = new(Path.Combine(docPath, "PW_File.txt"), FileMode.CreateNew);
                    using (StreamWriter sw = new(fs))
                    {
                        sw.Write(family + " " + name + " " + patronymic + Environment.NewLine);
                        sw.Write(dateOfBirth.ToString());
                        sw.WriteLine();
                        for (int i = 0; i < ints.GetLength(0); i++)
                        {
                            for(int j = 0; j < ints.GetLength(1); j++)
                            {
                                sw.Write(ints[i, j].ToString() + " ");
                            }
                            sw.WriteLine();
                        }
                        sw.WriteLine();
                        for (int i = 0; i < doubles.GetLength(0); i++)
                        {
                            for (int j = 0; j < doubles.GetLength(1); j++)
                            {
                                sw.Write(doubles[i, j].ToString() + " ");
                            }
                            sw.WriteLine();
                        }
                        sw.WriteLine(Environment.NewLine + DateTime.Now.ToString());
                    }
                }
                catch (IOException IOEX)
                {
                    Console.WriteLine(IOEX.Message);
                }
            }
        }
    }
}