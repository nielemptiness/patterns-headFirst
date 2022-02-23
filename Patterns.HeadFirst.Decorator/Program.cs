using System;
using System.Threading.Tasks;

namespace Patterns.HeadFirst.Decorator
{
    public static class Program
    {
        public static async Task Main()
        {
            var worker = new Worker();
            var fabric = new SomeFabric(worker);
            
            await fabric.StartWorkingDay();
            
            var lazyWorker = new LazyWorkerDecorator(worker);
            fabric.Hire(lazyWorker);
            
            Console.WriteLine("\nHired someone new. Lets see how hey work together. \n");
            await fabric.StartWorkingDay();
        }
    }
}