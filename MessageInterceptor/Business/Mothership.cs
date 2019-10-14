using System;
using MessageInterceptor.Interfaces;
using MessageInterceptor.Domain;

namespace MessageInterceptor.Business
{   
    public class Mothership: IMothership
    {
        public string Intercept() 
        {
            return string.Empty;
        }
    }
}