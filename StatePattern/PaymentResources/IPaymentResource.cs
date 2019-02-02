namespace StatePattern.PaymentResources
{
    public interface IPaymentResource
    {
        bool HasFunds(int neededPayment);
        void SubtractPayment(int subtractPayment);
    }
}