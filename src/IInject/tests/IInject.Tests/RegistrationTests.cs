using Moq;
using System;
using Xunit;

namespace IInject.Tests
{
    public class RegistrationTests
    {
        [Fact]
        public void Test1()
        {
            var registry = new Registry();
            var request = new Mock<IRegistrationRequest>();
            registry.Add(request.Object);
        }
    }
}
