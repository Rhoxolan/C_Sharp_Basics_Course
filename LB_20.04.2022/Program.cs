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

            List<PC> pcs = new() { new("PC", "LG", 12345), new("Laptop", "Huawei", 54321) };
            pcs.Add(new("Ultrabook", "Asus", 56789));
            pcs.Add(new("PC", "Asus", 98765));

            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = File.Create(docPath + "/test.bin"))
            {
                binFormat.Serialize(fStream, pcs);
            }
        }
    }
}