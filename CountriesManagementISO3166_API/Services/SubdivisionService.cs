using CountriesManagementISO3166_API.Context;
using CountriesManagementISO3166_API.Models;
using CountriesManagementISO3166_API.Services.Interfaces;
using System.Collections.Generic;

namespace CountriesManagementISO3166_API.Services
{
    public class SubdivisionService : ISubdivisionService
    {
        private readonly ApplicationDBContext _context;

        public SubdivisionService(ApplicationDBContext context)
        {
            _context = context;
        }

        public void DeleteSubdivision(Subdivision subdivision)
        {
            throw new System.NotImplementedException();
        }

        public IList<Subdivision> GetAllSubdivisions()
        {
            throw new System.NotImplementedException();
        }

        public Subdivision GetSubdivisionById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void InsertSubdivision(Subdivision subdivision)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateSubdivision(Subdivision subdivision)
        {
            throw new System.NotImplementedException();
        }
    }
}
