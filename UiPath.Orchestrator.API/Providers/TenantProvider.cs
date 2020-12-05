using System;
using UiPath.Orchestrator.Domain.Services;
using System.Threading.Tasks;

namespace UiPath.Orchestrator.API.Providers
{
    public class TenantProvider : ITenantService
    {
        public Task<string> ListTenants()
        {
            throw new NotImplementedException();
        }
    }
}
