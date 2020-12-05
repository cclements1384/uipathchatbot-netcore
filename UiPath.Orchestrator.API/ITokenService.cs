using System;
using System.Threading.Tasks;

namespace UiPath.Orchestrator.API
{
    public interface ITokenService
    {
        Task<string> GetToken();
        Task<string> GetToken(string tenantName);
    }
}
