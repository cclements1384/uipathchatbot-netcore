using System;
using System.Collections.Generic;
using System.Text;

namespace UiPath.API.Services
{
    public class TokenProvider : ITokenService
    {
        private readonly string _username;
        private readonly string _password;
        private readonly string _tenant;
        const string _url = "https://cop-uipath-rpa-d.copapps.net";

        public TokenProvider(string username, string password, string tenant)
        {
            _username = username;
            _password = password;
            _tenant = tenant;
        }

        public string GetToken()
        {
            var token = string.Empty;
            return token;
        }
    }
}
