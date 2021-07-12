using CountriesManagementISO3166_API.Models;
using CountriesManagementISO3166_API.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesManagementISO3166_API.Services
{
    public class CountrieService : ICountrieService
    {
        private readonly ApplicationDBContext _context;

        public CountrieService(ApplicationDBContext context)
        {
            _context = context;          
        }

        public void DeleteCountrie(Countrie countrie)
        {
            throw new NotImplementedException();
        }

        public IList<Countrie> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Countrie GetCountrieByAlpha2Code(string alpha2Code)
        {
            throw new NotImplementedException();
        }

        public Countrie GetCountrieByCommonName(string commonName)
        {
            throw new NotImplementedException();
        }

        public Countrie GetCountrieById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertCountrie(Countrie countrie)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCountrie(Countrie countrie)
        {
            throw new NotImplementedException();
        }
    }
}
