using CountriesManagementISO3166_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountriesManagementISO3166_API.Services.Interfaces
{
    public interface ISubdivisionService
    {
        bool SaveChanges();
        IList<Subdivision> GetAllSubdivisions();
        Subdivision GetSubdivisionById(int id);
        IList<Subdivision> GetSubdivisionsByCountryId(int id);
        void InsertSubdivision(Subdivision subdivision);
        void UpdateSubdivision(Subdivision subdivision);
        void DeleteSubdivision(Subdivision subdivision);
    }
}
