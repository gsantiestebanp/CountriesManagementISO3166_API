using CountriesManagementISO3166_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountriesManagementISO3166_API.Services.Interfaces
{
    public interface ISubdivisionService
    {
        IList<Subdivision> GetAllSubdivisions();
        Subdivision GetSubdivisionById(int id);
        void InsertSubdivision(Subdivision subdivision);
        void UpdateSubdivision(Subdivision subdivision);
        void DeleteSubdivision(Subdivision subdivision);
    }
}
