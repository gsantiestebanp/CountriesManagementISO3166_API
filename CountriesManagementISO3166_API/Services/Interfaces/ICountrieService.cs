using Countries_Management_ISO3166_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Countries_Management_ISO3166_API.Services
{
    public interface ICountrieService
    {
        Task<List<Countrie>> GetAllCountries();
        Task<Countrie> GetCountrieByCommonName(string commonName);
        Task<Countrie> GetCountrieByAlpha2Code(string alpha2Code);
        Task InsertCountrie(Countrie countrie);
        Task UpdateCountrie(Countrie countrie);
        Task DeleteCountrie(Countrie countrie);
    }
}
