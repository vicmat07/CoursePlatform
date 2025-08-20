using CoursePlatform.Server.Domain.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoursePlatform.Server.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    [Authorize]
    public class EnrollmentController(IEnrollmentService enrollmentService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var enrollments = await enrollmentService.GetAllByUserIdAsync(userId!);

            return Ok(enrollments);
        }
    }
}
