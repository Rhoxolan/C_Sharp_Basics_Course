namespace program
{
    using WordOfTanks;
    using System;
    class Program
    {
        static void Main()
        {
            Random random = new();

            List<Tank> UKtanks = new()
            {
                new("AT-7", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("AT-8", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("Cromwell B", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("Black Prince", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("FV215B 183", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
            };
            List<Tank> CHINAtanks = new()
            {
                new("IS-2", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("WZ-131G FT", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("WZ-113G FT", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("WZ-120", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("Type 64", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
            };

            while (true)
            {

            }
        }
    }
}
