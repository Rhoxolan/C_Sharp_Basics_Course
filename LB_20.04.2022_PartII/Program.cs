using System;
using static MyClassLibrary.MyConsoleFunctional;
using MyClassLibrary;
using LB20042022ClassLibrary;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace program
{
    class Program
    {
        static void Main()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            BinaryFormatter binFormat = new BinaryFormatter();

            List<PC> pcs = null;
            using (Stream fStream = File.OpenRead(docPath + "/test.bin"))
            {
                pcs = (List<PC>)binFormat.Deserialize(fStream);
            }

            foreach(var pc in pcs)
            {
                Console.WriteLine(pc);
            }

            Console.WriteLine($"Запускаем ПК {pcs[1]}: ");
            pcs[1].Start();
            Console.WriteLine($"Перезапускаем ПК {pcs[1]}: ");
            pcs[1].Reboot();
        }
    }
}