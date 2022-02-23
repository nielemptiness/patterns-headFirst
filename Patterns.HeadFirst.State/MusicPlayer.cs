namespace Patterns.HeadFirst.State
{
    public class MusicPlayer : IStateful
    {
        private IState _state;

        public MusicPlayer()
        {
            _state = new DisabledState(this);
        }
        public void Sound()
        {
            _state.Sound();
        }

        public void TurnOn()
        {
            _state.TurnOn();
        }

        public void SetState(IState state)
        {
            _state = state;
        }
    }
}