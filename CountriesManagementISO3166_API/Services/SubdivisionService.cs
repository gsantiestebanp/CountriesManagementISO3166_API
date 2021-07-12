using CountriesManagementISO3166_API.Context;
using CountriesManagementISO3166_API.Models;
using CountriesManagementISO3166_API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (subdivision != null)
            {
                _context.Subdivisions.Remove(subdivision);
            }
            else
                throw new ArgumentNullException(nameof(subdivision));
        }

        public IList<Subdivision> GetAllSubdivisions()
        {
            return _context.Subdivisions.ToList();
        }

        public Subdivision GetSubdivisionById(int id)
        {
            return _context.Subdivisions.FirstOrDefault(p => p.SubdivisionId == id);
        }

        public void InsertSubdivision(Subdivision subdivision)
        {
            if (subdivision != null)
            {
                _context.Subdivisions.Add(subdivision);
            }
            else
                throw new ArgumentNullException(nameof(subdivision));
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateSubdivision(Subdivision subdivision)
        {
            // Method intentionally left empty. 
        }
    }
}
