using System;

namespace BridgePattern
{
    public class EmailSender : IMessageSender
    {
        private readonly string _email;

        public EmailSender(string email)
        {
            _email = email;
        }
        
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Sending e-mail to: {0}", _email);
            Console.WriteLine("{0}: {1}", subject, body);
        }
    }
}