using System;
using System.Threading.Tasks;

namespace Patterns.HeadFirst.Decorator
{
    public class Worker : IWorker
    {
        private const int DelaySeconds = 1;
        public async Task DoWork()
        {
            await Task.Delay(TimeSpan.FromSeconds(DelaySeconds));
            Console.WriteLine("Ooof, some hard work here!");
        }
    }
}