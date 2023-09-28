using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PLCMonitoring_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public UserController(IHttpContextAccessor _httpContext)
        {
            _contextAccessor = _httpContext;
        }

        [HttpGet]
        public string GetCurrentUserName ()
        {
            string? username = _contextAccessor.HttpContext.User.Identity.Name;
            return username ?? "Not found";
        }
    }
}
