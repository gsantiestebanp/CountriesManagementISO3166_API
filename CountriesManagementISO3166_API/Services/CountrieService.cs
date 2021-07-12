using Countries_Management_ISO3166_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries_Management_ISO3166_API.Services
{
    public class CountrieService : ICountrieService
    {
        public Task DeleteCountrie(Countrie countrie)
        {
            throw new NotImplementedException();
        }

        public Task<List<Countrie>> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Task<Countrie> GetCountrieByAlpha2Code(string alpha2Code)
        {
            throw new NotImplementedException();
        }

        public Task<Countrie> GetCountrieByCommonName(string commonName)
        {
            throw new NotImplementedException();
        }

        public Task InsertCountrie(Countrie countrie)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCountrie(Countrie countrie)
        {
            throw new NotImplementedException();
        }
    }
}
