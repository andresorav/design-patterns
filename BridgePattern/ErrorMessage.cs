using System;

namespace BridgePattern
{
    public class ErrorMessage : AbstractMessage
    {
        public ErrorMessage(string body) : base(body)
        {
        }

        public override void Send()
        {
            var subject = string.Format("Got an error on {0}: ", DateTime.UtcNow);
            MessageSender.SendMessage(subject, Body);
        }
    }
}