namespace Patterns.HeadFirst.Observer
{
    public interface IListener
    {
        void ReceiveUpdate(string update);
        void Unsubscribe();
    }
}