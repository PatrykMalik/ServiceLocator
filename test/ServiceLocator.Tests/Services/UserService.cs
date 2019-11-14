using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLocator.Tests.Services
{
    public interface IUserService
    {

    }
    public class UserService : IUserService
    {
        private readonly IVendorService _vendorService;

        public UserService (IVendorService vendorService)
        {
            this._vendorService = vendorService;
        }
    }
}
