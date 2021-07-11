using Countries_Management_ISO3166_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesManagementISO3166_API.Context
{
    public class ApplicationDBContext : DBContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Countrie> Countries { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
    }
}
