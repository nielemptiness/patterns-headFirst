using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patterns.HeadFirst.Decorator
{
    public class SomeFabric
    {
        private readonly List<IWorker> _workers;
        
        public SomeFabric(IWorker oldWorker)
        {
            _workers = new List<IWorker> { oldWorker };
        }

        public void Hire(IWorker worker)
        {
            _workers.Add(worker);
        }

        public async Task StartWorkingDay()
        {
            Console.WriteLine("Day is starting... Employees should work! \n");

            foreach (var worker in _workers)
            {
                await worker.DoWork();
            }
        }
    }
}