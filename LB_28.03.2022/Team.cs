using System;


namespace program
{
    interface IWorker
    {
        string GetWork();
    }

    internal class Worker : IWorker
    {
        public string GetWork()
        {
            return "Работаю!";
        }
    }

    internal class TeamLeader : IWorker
    {
        public string GetWork()
        {
            return "Формирую отчет!";
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
