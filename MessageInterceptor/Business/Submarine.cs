using System;
using MessageInterceptor.Interfaces;
using MessageInterceptor.Domain;

namespace MessageInterceptor.Business
{
    public class Submarine: ISubmarine
    {
        public void Send(Message message)
        {
            Console.WriteLine($"Message received: {message}");
        }
    }
}