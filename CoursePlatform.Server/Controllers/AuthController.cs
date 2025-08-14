using CoursePlatform.Server.Domain;
using CoursePlatform.Server.DTOs;
using CoursePlatform.Server.Models;
using CoursePlatform.Server.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoursePlatform.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(
        UserManager<ApplicationUser> userManager,
        RoleManager<ApplicationRole> roleManager,
        IJwtService jwtService) : ControllerBase
    {

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var existingUser = await userManager.FindByEmailAsync(request.Email);
            if (existingUser != null)
                return BadRequest("Email already registered");

            var user = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email
            };

            var result = await userManager.CreateAsync(user, request.Password);
            if (!result.Succeeded)
                return BadRequest(result.Errors);

            // Sempre registra como Student por padrão
            if (!await roleManager.RoleExistsAsync("Student"))
                await roleManager.CreateAsync(new ApplicationRole { Name = "Student" });

            await userManager.AddToRoleAsync(user, "Student");

            var roles = await userManager.GetRolesAsync(user);
            var token = jwtService.GenerateToken(user, roles);

            return Ok(new { token });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await userManager.FindByEmailAsync(request.Email);
            if (user == null)
                return Unauthorized("Invalid user or password");

            var isPasswordValid = await userManager.CheckPasswordAsync(user, request.Password);
            if (!isPasswordValid)
                return Unauthorized("Invalid user or password");

            var roles = await userManager.GetRolesAsync(user);
            var token = jwtService.GenerateToken(user, roles);

            return Ok(new { token });
        }
    }
}
