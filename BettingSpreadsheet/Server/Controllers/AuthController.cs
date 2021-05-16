using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BettingSpreadsheet.Server.Data;
using BettingSpreadsheet.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BettingSpreadsheet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var response = await _authRepo.Register(
                new User
                {
                    Username = request.Username,
                    Email = request.Email,
                    IsConfirmed = request.IsConfirmed,
                    Bio = request.Bio
                }, request.Password
            );

            return !response.Success ? BadRequest(response) : Ok(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var response = await _authRepo.Login(request.Email, request.Password);

            return !response.Success ? BadRequest(response) : Ok(response);
        }
    }
}
