using System;
using System.Collections.Generic;
using System.Text;

namespace UiPath.API.Models
{
    public class TokenPayload
    {
        public string username { get; set; }
        public string password { get; set; }
        public string tenantName { get; set; }
    }
}
