using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.WebApp.Repo;
using Microsoft.Extensions.Configuration;
using POS.WebApp.Dtos.User;
using POS.WebApp.Data;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

namespace POS.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IConfiguration _config;

        public AuthController(IAuthRepository repo, IConfiguration config)
        {
            _repo = repo;
            _config = config;
        }

        /// <summary>
        /// Function for register new user
        /// </summary>
        /// <param name="userRegisterDto"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            userRegisterDto.Username = userRegisterDto.Username.ToLower();

            if (await _repo.UserExist(userRegisterDto.Username))
            {
                return BadRequest("Username already exist");
            }

            var userToCreate = new User
            {
                Username = userRegisterDto.Username,
                Name = userRegisterDto.Name,
                GenderId = userRegisterDto.GenderId,
                UserRoleId = userRegisterDto.UserRoleId,
                PhoneNumber = userRegisterDto.PhoneNumber,
                CreatedAt = DateTimeOffset.Now,
                CreatedBy = "ADMIN",
                UpdatedAt = DateTimeOffset.Now,
                UpdatedBy = "ADMIN"
            };

            var createdUser = await _repo.Register(userToCreate, userRegisterDto.Password);

            return Ok();
        }

        /// <summary>
        /// Function for user login
        /// </summary>
        /// <param name="userLoginDto"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            var userFromRepo = await _repo.Login(userLoginDto.Username.ToLower(),userLoginDto.Password);

            if (userFromRepo == null)
            {
                return Unauthorized();
            };

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
                new Claim(ClaimTypes.Name, userFromRepo.Username)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key,SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }

    }
}
