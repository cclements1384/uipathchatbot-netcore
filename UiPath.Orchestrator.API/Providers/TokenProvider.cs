using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
using UiPath.Orchestrator.API;
using UiPath.Orchestrator.API.Models;

namespace UiPath.Orichestrator.API.Services
{
    public class TokenProvider : ITokenService
    {
        private readonly string _username;
        private readonly string _password;
        private string _tenantName;
        private readonly string _url;
      
        public TokenProvider(string url,
            string tenant,
            string username, 
            string password)
        {
            _username = username;
            _password = password;
            _tenantName = tenant;
            _url = url;
        }

        public Task<string> GetToken(string tenantName)
        {
            _tenantName = tenantName;
            return GetToken();
        }

        public async Task<string> GetToken()
        {
            AccessToken token;
            var response = string.Empty;

            using (var client = GetClient())
            {
                response = client.UploadString(_url, GetPayload());
                token = JsonConvert.DeserializeObject<AccessToken>(response);
            }

            return token.result;
        }

        private WebClient GetClient()
        {
            var client = new WebClient();
            client.Headers.Add("Content-type", "application/json");
            client.Headers.Add("Accept", "application/json");
            return client;
        }

        private string GetPayload()
        {
            var payload = new TokenPayload()
            {
                username = _username,
                password = _password,
                tenantName = _tenantName
            };

            return JsonConvert.SerializeObject(payload);
        }

    }
}
