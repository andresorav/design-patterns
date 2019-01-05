namespace BridgePattern
{
    public abstract class AbstractMessage
    {
        protected readonly string Body;
        
        public IMessageSender MessageSender { get; set; }
        public abstract void Send();

        protected AbstractMessage(string body)
        {
            Body = body;
        }
    }
}