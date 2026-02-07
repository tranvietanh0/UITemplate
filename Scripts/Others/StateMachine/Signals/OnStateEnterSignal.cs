namespace UITemplate.Scripts.Others.StateMachine.Signals
{
    using UITemplate.Scripts.Others.StateMachine.Interface;

    public class OnStateEnterSignal
    {
        public IState State { get; }

        public OnStateEnterSignal(IState state)
        {
            this.State = state;
        }
    }
}