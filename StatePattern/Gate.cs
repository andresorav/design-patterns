using System;
using StatePattern.PaymentResources;
using StatePattern.States;

namespace StatePattern
{
    public interface IGate
    {
        void ChangeState(IGateState newState);
        void Enter();
        void Pay(IPaymentResource paymentResource);
    }
    
    public class Gate : IGate
    {
        private IGateState _state;
        private readonly int _neededPayment;

        public Gate(int neededPayment)
        {
            _neededPayment = neededPayment;
            _state = new ClosedGateState();
        }
        
        public void Enter()
        {
            if (_state is ClosedGateState)
            {
                Console.WriteLine("Payment needed for opening the gate, cannot enter!");
                return;
            }

            _state.Enter(this);
        }

        public void Pay(IPaymentResource paymentResource)
        {
            if (_state is OpenGateState)
            {
                Console.WriteLine("Payment already made, please enter the gate");
                return;
            }

            if (!paymentResource.HasFunds(_neededPayment))
            {
                Console.WriteLine($"Payment resource {paymentResource.GetType().Name} doesn't have enough funds");
                return;
            }
            
            paymentResource.SubtractPayment(_neededPayment);
            Console.WriteLine($"Payment successfully subtracted from {paymentResource.GetType().Name}");
            
            _state.PayOk(this);
        }

        public void ChangeState(IGateState newState)
        {
            Console.WriteLine($"Changing gate state to {newState.GetType().Name}");
            _state = newState;
        }
    }
}