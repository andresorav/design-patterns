namespace StatePattern.States
{
    public class OpenGateState : IGateState
    {
        public void Enter(IGate gate)
        {
            gate.ChangeState(new ClosedGateState());
        }

        public void PayOk(IGate gate)
        {
        }
    }
}