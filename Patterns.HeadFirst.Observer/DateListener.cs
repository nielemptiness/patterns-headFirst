namespace Patterns.HeadFirst.Observer
{
    public class DateListener : IListener
    {
        private readonly IObserver _observer;
        public DateListener(IObserver observer)
        {
            _observer = observer;
            _observer.Register(this);
        }
        
        public void ReceiveUpdate(string update)
        {
            Console.WriteLine("Received update: \'" + update + "\' at " + DateTime.UtcNow);
        }

        public void Unsubscribe()
        {
            _observer.Unregister(this);
        }
    }
}