namespace UiPath.Orchestrator.Domain.Models
{
    public class TokenPayload
    {
        public string usernameOrEmailAddress { get; set; }
        public string password { get; set; }
        public string tenancyName { get; set; }
    }
}
