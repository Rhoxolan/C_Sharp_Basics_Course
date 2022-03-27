namespace program
{
    using WordOfTanks;
    using System;

    class Program
    {
        static void Main()
        {
            Random random = new();

            Tank[] UKtanks = {
                new("AT-7", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("AT-8", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("Cromwell B", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("Black Prince", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("FV215B 183", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
            };
            Tank[] CHINAtanks = {
                new("IS-2", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("WZ-131G FT", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("WZ-113G FT", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("WZ-120", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
                new("Type 64", (short)random.Next(0, 100), (short)random.Next(0, 100), (short)random.Next(0, 100)),
            };

            short UKtank_count = 5;
            short CHINAtank_count = 5;

            while (UKtank_count != 0 || CHINAtank_count != 0)
            {
                for (int i = 0; i < UKtank_count; i++)
                {
                    if(UKtanks[i].Activity)
                    {
                        for (int y = 0; y < CHINAtank_count; y++)
                        {
                            if (CHINAtanks[y].Activity)
                            {
                                if (UKtanks[i] * CHINAtanks[y])
                                {
                                    CHINAtanks[y].Activity = false;
                                    CHINAtank_count--;
                                    break;
                                }
                                else
                                {
                                    UKtanks[i].Activity = false;
                                    UKtank_count--;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            if (UKtank_count == 0)
            {
                Console.WriteLine("Команда Китая победила");
            }
            else
            {
                Console.WriteLine("Команда UK победила");
            }
        }
    }
}
