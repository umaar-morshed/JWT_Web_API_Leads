using System.Security.Claims;

namespace JWT_Web_API_Leads.Services.UserService
{
    // UserService implements IUserService Interface
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor) 
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetMyUsername()
        {
            var result = string.Empty;
            if(_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }

            return result;
        }
    }
}
