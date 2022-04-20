using System.Threading;
using static MyClassLibrary.MyConsoleFunctional;

namespace LB20042022ClassLibrary
{
    [Serializable]
    public record PC(string Type, string Mark, int SerialNumber)
    {
        public void Start()
        {
            Console.WriteLine("Запускаем ПК! Пожалуйста, подождите.");
            Thread.Sleep(3000);
            AnyKey();
        }

        public void Reboot()
        {
            Console.WriteLine("Перезапускаем ПК! Пожалуйста, подождите.");
            Thread.Sleep(5000);
            AnyKey();
        }

        public override string ToString()
        {
            return $"{Type} {Mark}, s/n{SerialNumber}.";
        }
    }
}