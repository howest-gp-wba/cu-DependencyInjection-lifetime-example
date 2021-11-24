using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wba.DependencyInjection.Web.Services.Interfaces;

namespace Wba.DependencyInjection.Web.Services
{
    public class CreateUserIdService : ICreateUserIdServiceSingleton,
        ICreateUserIdServiceTransient,
        ICreateUserIdServiceScoped
    {
        private Guid _userId;
        public CreateUserIdService()
        {
            _userId = Guid.NewGuid();
        }
        public string GetUserId()
        {
            return _userId.ToString();
        }
    }
}
