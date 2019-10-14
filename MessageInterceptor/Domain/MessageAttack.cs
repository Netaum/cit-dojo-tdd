namespace MessageInterceptor.Domain
{
    public class MessageAttack: Message
    {
        public Position Position1 { get; set; }
        public Position Position2 { get; set; }
        public Position Position3 { get; set; }
    }
}