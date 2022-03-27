namespace WordOfTanks
{
    using System;

    public class Tank
    {
        public string Model { get; set; }
        public short Ammunition { get; set; }
        public short Armor { get; set; }
        public short Mobility { get; set; }

        public Tank(string model, short ammunition, short armor, short mobility)
        {
            Model = model;
            Ammunition = ammunition;
            Armor = armor;
            Mobility = mobility;
        }

        public static bool operator > (Tank tank1, Tank tank2)
        {
            int tank1_points = 0;
            int tank2_points = 0;
            if (tank1.Ammunition > tank2.Ammunition) tank1_points++; else tank2_points++;
            if (tank1.Armor > tank2.Armor) tank1_points++; else tank2_points++;
            if (tank1.Mobility > tank2.Mobility) tank1_points++; else tank2_points++;
            if ((tank1.Armor + tank1.Ammunition + tank1.Mobility) ==
                    (tank2.Armor + tank2.Ammunition + tank1.Mobility))
            {
                Random r = new();
                return r.Next(2) == 1;
            }
            if (tank1_points == tank2_points)
            {
                return true && ((tank1.Armor + tank1.Ammunition + tank1.Mobility) >
                    (tank2.Armor + tank2.Ammunition + tank1.Mobility));
            }
            if (tank1_points > tank2_points)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool operator <(Tank tank1, Tank tank2)
        {
            return !(tank1 > tank2);
        }

        public static Tank operator* (Tank tank1, Tank tank2)
        {
            if(tank1 > tank2)
            {
                return tank1;
            }
            else
            {
                return tank2;
            }
        }
    }
}