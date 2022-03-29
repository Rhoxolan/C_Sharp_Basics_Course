namespace WordOfTanks
{
    using System;

    public class Tank
    {
        public string Model { get; set; }
        short ammunition;
        short armor;
        short mobility;
        public bool Activity { get; set; } = true;
        public int Number { get; set; }

        public Tank(int number, string model, short ammunition, short armor, short mobility)
        {
            Model = model;
            this.ammunition = ammunition;
            this.armor = armor;
            this.mobility = mobility;
            Number = number;
        }

        public static bool operator > (Tank tank1, Tank tank2)
        {
            short tank1_points = 0;
            short tank2_points = 0;
            if (tank1.ammunition > tank2.ammunition)
            {
                tank1_points++;
            }
            else
            {
                tank2_points++;
            }
            if (tank1.armor > tank2.armor)
            {
                tank1_points++;
            }
            else
            {
                tank2_points++;
            }
            if (tank1.mobility > tank2.mobility)
            {
                tank1_points++;
            }
            else
            {
                tank2_points++;
            }
            if ((tank1.armor + tank1.ammunition + tank1.mobility) ==
                    (tank2.armor + tank2.ammunition + tank1.mobility))
            {
                Random r = new();
                return r.Next(2) == 1;
            }
            if (tank1_points == tank2_points)
            {
                return true && ((tank1.armor + tank1.ammunition + tank1.mobility) >
                    (tank2.armor + tank2.ammunition + tank1.mobility));
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

        public static bool operator* (Tank tank1, Tank tank2)
        {
            if(tank1 > tank2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Number}. {Model}";
        }
    }
}