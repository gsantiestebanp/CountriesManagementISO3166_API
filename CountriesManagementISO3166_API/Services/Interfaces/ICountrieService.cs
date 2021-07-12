using CountriesManagementISO3166_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountriesManagementISO3166_API.Services
{
    public interface ICountrieService
    {
        bool SaveChanges();
        IList<Countrie> GetAllCountries();
        Countrie GetCountrieById(int id);
        Countrie GetCountrieByCommonName(string commonName);
        Countrie GetCountrieByAlpha2Code(string alpha2Code);
        void InsertCountrie(Countrie countrie);
        void UpdateCountrie(Countrie countrie);
        void DeleteCountrie(Countrie countrie);
    }
}
