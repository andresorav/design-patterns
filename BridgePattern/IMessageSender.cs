namespace BridgePattern
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }
}