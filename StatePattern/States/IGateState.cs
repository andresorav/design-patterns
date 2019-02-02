namespace StatePattern.States
{
    public interface IGateState
    {
        void Enter(IGate gate);
        void PayOk(IGate gate);
    }
}