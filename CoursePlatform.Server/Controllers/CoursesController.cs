using CoursePlatform.Server.Domain.Abstractions;
using CoursePlatform.Server.DTOs;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromBody] CreateCourseRequest request)
        {
            return Created();
        }

        [HttpGet("{courseId}")]
        public async Task<IActionResult> GetCourseDetailsById(int courseId)
        {
            return Ok();
        }
    }
}
