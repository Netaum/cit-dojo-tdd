namespace MessageInterceptor.Domain
{
    public class MessageChangePosition: Message
    {
        public Position Position { get; set; }
    }
}