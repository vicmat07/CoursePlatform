using CoursePlatform.Api.DTOs;
using CoursePlatform.Application.Services;
using CoursePlatform.Domain.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoursePlatform.Api.Controllers
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
