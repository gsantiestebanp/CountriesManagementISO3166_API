using CountriesManagementISO3166_API.Dtos.Request;
using CountriesManagementISO3166_API.Dtos.Response;
using CountriesManagementISO3166_API.Models;
using System.Collections.Generic;

namespace CountriesManagementISO3166_API.Services.Interfaces
{
    public interface IUserService
    {
        AuthenticateMS Authenticate(AuthenticateME model);
        User GetById(int id);
    }
}
