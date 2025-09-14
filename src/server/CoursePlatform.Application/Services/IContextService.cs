
namespace CoursePlatform.Application.Services
{
    public interface IContextService
    {
        public string CurrentUserId { get; }

        public string CurrentUserName { get; }
    }
}
