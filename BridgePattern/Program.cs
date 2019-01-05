using System;
using System.Collections.Generic;

namespace BridgePattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var messageSenders = new List<IMessageSender>
            {
                new EmailSender("admin@somesite.ee"),
                new SmsSender("+3720010012")
            };

            var messages = new List<AbstractMessage>
            {
                new ErrorMessage("Not enough space"),
                new InfoMessage("System is stable now")
            };

            foreach (var message in messages)
            {
                foreach (var messageSender in messageSenders)
                {
                    message.MessageSender = messageSender;
                    message.Send();
                    
                    Console.WriteLine();
                }
            }
        }
    }
}