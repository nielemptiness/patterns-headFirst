namespace Patterns.HeadFirst.Observer
{
    public interface IObserver
    {
        void Register(IListener listener);
        void Unregister(IListener listener);
        void Notify();
    }
}