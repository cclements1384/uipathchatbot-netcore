using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UiPath.Orchestrator.Domain.Services
{
    public interface ITenantService
    {
        Task<string> ListTenants();
    }
}
