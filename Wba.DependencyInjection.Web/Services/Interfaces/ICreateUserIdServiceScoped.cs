using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wba.DependencyInjection.Web.Services.Interfaces
{
    public interface ICreateUserIdServiceScoped
    {
        string GetUserId();
    }
}
