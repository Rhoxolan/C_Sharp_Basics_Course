using System;


namespace program
{
    interface IWorker
    {
        string Name { get; set; }

        string Rank { get; }
        
        string Work { get; }
    }

    internal class Worker : IWorker
    {
        string name;

        public Worker(string name)
        {
            Name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Rank
        {
            get
            {
                return "Рабочий";
            }
        }

        public string Work
        {
            get
            {
                return "Работаю!";
            }
        }
    }

    internal class TeamLeader : IWorker
    {
        string name;

        public TeamLeader(string name)
        {
            Name = name;
        }
        
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        
        public string Rank
        {
            get
            {
                return "Бригадир";
            }
        }

        public string Work
        {
            get
            {
                return "Формирую отчет!";
            }
        }

        public string Report(List<IPart> parts)
        {
            int basements_count = 0,  walls_count = 0, doors_count = 0, windows_count = 0, roofs_count = 0;
            for (int i = 0; i < parts.Count(); i++)
            {
                if (parts[i].GetType() == typeof(Basement))
                {
                    basements_count++;
                }
                if (parts[i].GetType() == typeof(Wall))
                {
                    walls_count++;
                }
                if (parts[i].GetType() == typeof(Door))
                {
                    doors_count++;
                }
                if (parts[i].GetType() == typeof(Window))
                {
                    windows_count++;
                }
                if (parts[i].GetType() == typeof(Roof))
                {
                    roofs_count++;
                }
            }
            return $"\n\n\n{Work} {Rank} {Name} предоставил отчет:\n" +
                $"{basements_count} построенных фасадов;\n" +
                $"{walls_count} построенных стен;\n" +
                $"{doors_count} поставленных дверей;\n" +
                $"{windows_count} поставленных окон;\n" +
                $"{roofs_count} построенных крыш.";
        }
    }

    internal class Team
    {
        List<IWorker> workers;

        public Team()
        {
            workers = new List<IWorker>();
        }

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public List<IWorker> Workers
        {
            get { return workers; }
        }
    }
}
