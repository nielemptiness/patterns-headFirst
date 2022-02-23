namespace Patterns.HeadFirst.State
{
    public class DisabledState : IState
    {
        private readonly IStateful _stateful;

        public DisabledState(IStateful stateful)
        {
            _stateful = stateful;
        }

        public void Sound()
        {
            Console.WriteLine("Can't play now!");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on...");
            _stateful.SetState(new EnabledState());
        }
    }
}