using CountriesManagementISO3166_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesManagementISO3166_API.Dtos.Response
{
    public class AuthenticateMS
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public AuthenticateMS(User user, string token)
        {
            Id = user.Id;
            Email = user.Email;
            Token = token;
        }
    }
}
