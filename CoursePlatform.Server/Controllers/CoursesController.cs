using CoursePlatform.Server.Domain.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursePlatform.Server.Controllers
{
    [Route("api/courses")]
    [ApiController]
    [Authorize]
    public class CoursesController(ICourseService courseService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var courses = await courseService.GetAllAsync();

            return Ok(courses);
        }
    }
}
