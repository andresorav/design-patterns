namespace StatePattern.PaymentResources
{
    public class GateCard : IPaymentResource
    {
        private int _funds;

        public GateCard(int funds)
        {
            _funds = funds;
        }
        
        public bool HasFunds(int neededPayment)
        {
            return _funds >= neededPayment;
        }

        public void SubtractPayment(int payment)
        {
            _funds -= payment;
        }
    }
}