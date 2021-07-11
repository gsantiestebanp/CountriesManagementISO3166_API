using Countries_Management_ISO3166_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Countries_Management_ISO3166_API.Services.Interfaces
{
    public interface ISubdivisionService
    {
        Task<List<Subdivision>> GetAllSubdivisions();
        Task<Subdivision> GetSubdivisionById(int id);
        Task InsertSubdivision(Subdivision subdivision);
        Task UpdateSubdivision(Subdivision subdivision);
        Task DeleteSubdivision(Subdivision subdivision);
    }
}
