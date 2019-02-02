using System;
using StatePattern.PaymentResources;

namespace StatePattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const int neededPayment = 5;
            var gate = new Gate(neededPayment);
            
            var gateCardEmpty = new GateCard(0);
            var gateCard = new GateCard(10);
            
            Console.WriteLine("Entering without payment");
            gate.Enter();
            Console.WriteLine();
            
            Console.WriteLine("Pay with empty card and try to enter");
            gate.Pay(gateCardEmpty);
            gate.Enter();
            Console.WriteLine();
            
            Console.WriteLine("Pay with valid card and try to enter twice");
            gate.Pay(gateCard);
            gate.Enter();
            gate.Enter();
            Console.WriteLine();
            
            Console.WriteLine("Pay twice with valid card and try to enter");
            gate.Pay(gateCard);
            gate.Pay(gateCard);
            gate.Enter();
            Console.WriteLine();
            
            Console.WriteLine("Pay with same card, which ran out of funds and try to enter");
            gate.Pay(gateCard);
            gate.Enter();
        }
    }
}