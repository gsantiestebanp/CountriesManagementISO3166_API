using CountriesManagementISO3166_API.Context;
using CountriesManagementISO3166_API.Dtos.Request;
using CountriesManagementISO3166_API.Dtos.Response;
using CountriesManagementISO3166_API.Helpers;
using CountriesManagementISO3166_API.Models;
using CountriesManagementISO3166_API.Services.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace CountriesManagementISO3166_API.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDBContext _context;
        private readonly AppSettings _appSettings;

        public UserService(ApplicationDBContext context, IOptions<AppSettings> appSettings)
        {
            _context = context;
            _appSettings = appSettings.Value;
        }

        public AuthenticateMS Authenticate(AuthenticateME requestUser)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == requestUser.Email && u.Password == requestUser.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateMS(user, token);
        }        

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        private string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
