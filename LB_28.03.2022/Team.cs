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
