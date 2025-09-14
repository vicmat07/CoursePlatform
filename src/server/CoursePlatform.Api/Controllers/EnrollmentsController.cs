using CoursePlatform.Api.DTOs;
using CoursePlatform.Application.Services;
using CoursePlatform.Domain.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoursePlatform.Api.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    [Authorize]
    public class EnrollmentsController(IEnrollmentService enrollmentService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var enrollments = await enrollmentService.GetAllByUserIdAsync(userId!);

            return Ok(enrollments);
        }

        [HttpPost]
        public async Task<IActionResult> Enroll(EnrollRequest request)
        {
            var enrollment = await enrollmentService.EnrollAsync(request.CourseId, "userId");

            return Ok(enrollment);
        }
    }
}
