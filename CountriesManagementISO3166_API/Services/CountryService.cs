using CountriesManagementISO3166_API.Context;
using CountriesManagementISO3166_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CountriesManagementISO3166_API.Services
{
    public class CountryService : ICountryService
    {
        private readonly ApplicationDBContext _context;

        public CountryService(ApplicationDBContext context)
        {
            _context = context;          
        }

        public void DeleteCountry(Country country)
        {
            if (country != null)
            {
                _context.Countries.Remove(country);                
            }
            else
                throw new ArgumentNullException(nameof(country));
        }

        public IList<Country> GetAllCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountryByAlpha2Code(string alpha2Code)
        {
            return _context.Countries.FirstOrDefault(p => p.Alpha2Code == alpha2Code);
        }

        public Country GetCountryByCommonName(string commonName)
        {
            return _context.Countries.FirstOrDefault(p => p.CommonName == commonName);
        }

        public Country GetCountryById(int id)
        {
            return _context.Countries.FirstOrDefault(p => p.CountryId == id);
        }

        public void InsertCountry(Country country)
        {
            if (country != null)
            {
                _context.Countries.Add(country);                
            }
            else
                throw new ArgumentNullException(nameof(country));
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCountry(Country country)
        {
            // Method intentionally left empty. 
        }
    }
}
