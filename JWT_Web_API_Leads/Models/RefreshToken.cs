namespace JWT_Web_API_Leads.Models
{
    public class RefreshToken
    {
        // properties
        public string Token { get; set; } = string.Empty;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expires {  get; set; }
    }
}
