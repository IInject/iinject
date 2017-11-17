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
            var registry = new Registry(null);
            var request = new Mock<IRegistrationRequest>();
            registry.Register(request.Object);
        }
    }
}
