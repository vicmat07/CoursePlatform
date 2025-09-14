using CoursePlatform.Application.Services;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace CoursePlatform.Infrastructure
{
    internal class ContextService(IHttpContextAccessor httpContextAccessor) : IContextService
    {
        public string CurrentUserId => httpContextAccessor.HttpContext.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? throw new ArgumentException();

        public string CurrentUserName => httpContextAccessor.HttpContext.User?.Identity?.Name ?? throw new ArgumentException();
    }
}
