using System;
using System.Threading.Tasks;

namespace UiPath.API
{
    public interface ITokenService
    {
        Task<string> GetToken();
    }
}
