namespace Patterns.HeadFirst.State
{
    public interface IStateful : IState
    {
        void SetState(IState state);
    }
}