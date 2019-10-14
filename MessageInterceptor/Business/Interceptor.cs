using System;
using MessageInterceptor.Interfaces;
using MessageInterceptor.Domain;

namespace MessageInterceptor.Business
{   
    public class Interceptor
    {
        private IMothership mothership;
        private ISubmarine submarine;

        public Interceptor(IMothership mothership,
                                  ISubmarine submarine) 
        {
            this.mothership = mothership;
            this.submarine = submarine;
        }

        public void Translate()
        {
            var message = mothership.Intercept();

            submarine.Send(new Message());
        }
    }
}