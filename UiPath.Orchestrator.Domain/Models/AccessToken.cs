﻿namespace UiPath.Orchestrator.Domain.Models
{
    public class AccessToken
    {
        public string result { get; set; }
        public string targetUrl { get; set; }
        public string success { get; set; }
        public string error { get; set; }
        public string unauthorizedRequest { get; set; }
    }
}
