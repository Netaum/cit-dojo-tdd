namespace MessageInterceptor.Domain
{
    public class MessageGetCow: Message
    {
        public Position Position { get; set; }
        public int Rating { get; set; }
    }
}