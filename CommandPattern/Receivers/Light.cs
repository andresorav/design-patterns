namespace CommandPattern.Receivers
{
    public interface ILight
    {
        void On();
        void Off();
    }
    
    public class Light : ILight
    {
        public void On()
        {
            throw new System.NotImplementedException();
        }

        public void Off()
        {
            throw new System.NotImplementedException();
        }
    }
}