namespace UITemplate.Scripts.Others.StateMachine.Signals
{
    using UITemplate.Scripts.Others.StateMachine.Interface;

    public class OnStateExitSignal
    {
        public IState State { get; }

        public OnStateExitSignal(IState state)
        {
            this.State = state;
        }
    }
}