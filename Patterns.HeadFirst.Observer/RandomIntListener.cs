namespace Patterns.HeadFirst.Observer
{
    public class RandomIntListener : IListener
    {
        private readonly int _randomMaxValue = 99999;
        private readonly IObserver _observer;
        private readonly Random _random;
        
        public RandomIntListener(IObserver observer)
        {
            _observer = observer;
            _observer.Register(this);
            _random = new Random();
        }
        
        public void ReceiveUpdate(string update)
        {
            Console.WriteLine("Received update: \'" + update + "\' and created: " + _random.Next(_randomMaxValue));
        }

        public void Unsubscribe()
        {
            _observer.Unregister(this);
        }
    }
}