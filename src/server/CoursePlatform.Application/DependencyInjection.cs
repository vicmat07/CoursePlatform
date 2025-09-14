using CoursePlatform.Application.Services;
using CoursePlatform.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace CoursePlatform.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IEnrollmentService, EnrollmentService>();

            return services;
        }
    }
}
