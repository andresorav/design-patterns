using System;

namespace BridgePattern
{
    public class SmsSender : IMessageSender
    {
        private readonly string _phoneNumber;

        public SmsSender(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }
        
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Sending SMS to: {0}", _phoneNumber);
            Console.WriteLine("{0}: {1}", subject, body);
        }
    }
}