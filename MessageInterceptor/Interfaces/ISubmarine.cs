using MessageInterceptor.Domain;

namespace MessageInterceptor.Interfaces
{
    public interface ISubmarine
    {
        void Send(Message message);
    }
}