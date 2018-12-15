namespace AdapterPattern
{
    public class Client
    {
        private readonly ITarget _target;

        public Client(ITarget target)
        {
            _target = target;
        }

        public string Request()
        {
            var response = _target.Request();
            
            return string.Format(
                "Name: {0}, State: {1}",
                response["name"],
                response["state"]
            );
        }
    }
}