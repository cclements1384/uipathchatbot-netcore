using System;
using System.Threading.Tasks;

namespace UiPath.Orchestrator.Domain.Services
{
    public interface ITokenService
    {
        Task<string> GetToken();
        Task<string> GetToken(string tenantName);
    }
}
