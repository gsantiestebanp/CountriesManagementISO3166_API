using CountriesManagementISO3166_API.Models;
using Microsoft.EntityFrameworkCore;

namespace CountriesManagementISO3166_API.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
    }
}
 