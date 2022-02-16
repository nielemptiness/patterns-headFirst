namespace Patterns.HeadFirst.Observer
{
    public class Observer : IObserver
    {
        private readonly List<IListener> _listeners;
        private readonly string _update = "Hi there buddy!";

        public Observer()
        {
            _listeners = new List<IListener>();
        }

        public void Register(IListener listener)
        {
            _listeners.Add(listener);
        }

        public void Unregister(IListener listener)
        {
            if (_listeners.Contains(listener))
                _listeners.Remove(listener);
        }

        public void Notify()
        {
            foreach (var listener in _listeners)
            {
                listener.ReceiveUpdate(_update);
            }
        }
    }
}