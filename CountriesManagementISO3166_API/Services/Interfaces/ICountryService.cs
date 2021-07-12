using CountriesManagementISO3166_API.Models;
using System.Collections.Generic;

namespace CountriesManagementISO3166_API.Services
{
    public interface ICountryService
    {
        bool SaveChanges();
        IList<Country> GetAllCountries();
        Country GetCountryById(int id);
        Country GetCountryByCommonName(string commonName);
        Country GetCountryByAlpha2Code(string alpha2Code);
        void InsertCountry(Country country);
        void UpdateCountry(Country country);
        void DeleteCountry(Country country);
    }
}
