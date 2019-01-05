namespace BridgePattern
{
    public class InfoMessage : AbstractMessage
    {
        public InfoMessage(string body) : base(body)
        {
        }

        public override void Send()
        {
            MessageSender.SendMessage("Info", Body);
        }
    }
}