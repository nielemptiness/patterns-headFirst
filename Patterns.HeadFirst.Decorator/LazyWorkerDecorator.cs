using System;
using System.Threading.Tasks;

namespace Patterns.HeadFirst.Decorator
{
    public class LazyWorkerDecorator : IWorker
    {
        private const int RestDelaySeconds = 1;
        private readonly IWorker _worker;

        public LazyWorkerDecorator(IWorker worker)
        {
            _worker = worker;
        }
        public async Task DoWork()
        {
            await _worker.DoWork();
            Console.WriteLine("LazyWorker: ... Time to get some rest....");
            await Task.Delay(TimeSpan.FromSeconds(RestDelaySeconds));
            Console.WriteLine("LazyWorker: Now the day is finished, huh?");
        }
    }
}