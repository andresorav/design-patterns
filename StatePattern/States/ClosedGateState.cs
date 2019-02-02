namespace StatePattern.States
{
    public class ClosedGateState : IGateState
    {
        public void Enter(IGate gate)
        {
            gate.ChangeState(new ClosedGateState());
        }

        public void PayOk(IGate gate)
        {
            gate.ChangeState(new OpenGateState());
        }
    }
}