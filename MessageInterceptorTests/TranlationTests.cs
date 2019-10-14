using System;
using Xunit;
using Moq;
using MessageInterceptor.Interfaces;
using MessageInterceptor.Business;

namespace MessageInterceptorTests
{
    public class TranlationTests
    {
        private Mock<ISubmarine> mockSubmarine;
        private Mock<IMothership> mockMothership;
        private Interceptor interceptor;
        public TranlationTests()
        {
            mockSubmarine = new Mock<ISubmarine>();
            mockMothership = new Mock<IMothership>();

            interceptor = new Interceptor(mockMothership.Object, mockSubmarine.Object);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
