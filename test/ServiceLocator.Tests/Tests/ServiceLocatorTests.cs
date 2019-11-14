using ServiceLocator.Tests.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ServiceLocator.Tests.Tests
{
    public class ServiceLocatorTests
    {
        [Fact]
        public void ServiceLocator_Should_ReturnSimpleImplementation()
        {
            var serviceLocator = ServiceLocator.Create()
                .Register<IVendorService, VendorService>()
                .Register<IUserService, UserService>();
            var userService = serviceLocator.Resolve<IUserService>();
            Assert.NotNull(userService);
        }

        [Fact]

        public void ServiceLocator_Should_ReturnSingleton()
        {
            var serviceLocator = ServiceLocator.Create()
                .RegisterAsSingleton<ISingletonService, SingletonService>();

            var instanceFirst = serviceLocator.Resolve<ISingletonService>();
            var instanceSecond = serviceLocator.Resolve<ISingletonService>();

            Assert.Equal(instanceFirst, instanceSecond);
        }
    }
}
