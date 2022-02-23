namespace Patterns.HeadFirst.State
{
    public class EnabledState : IState
    {
        public void Sound()
        {
            Console.WriteLine("Badoom-ts!");
        }

        public void TurnOn()
        {
            Console.WriteLine("Already turned on!");
        }
    }
}