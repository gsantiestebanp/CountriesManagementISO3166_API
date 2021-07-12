using AutoMapper;
using CountriesManagementISO3166_API.Dtos;
using CountriesManagementISO3166_API.Dtos.Request;
using CountriesManagementISO3166_API.Models;

namespace CountriesManagementISO3166_API.MapperConfigurator
{
    public class AutoMapperConfiguratorProfile : Profile
    {
        public AutoMapperConfiguratorProfile()
        {      
            //Source -> Target
            CreateMap<Country, CountryME>();
            CreateMap<Subdivision, SubdivisionME>();
            CreateMap<Country, CountryMS>();
            CreateMap<Subdivision, SubdivisionMS>();

            //Target -> Source
            CreateMap<CountryME, Country>();
            CreateMap<SubdivisionME, Subdivision>();
            CreateMap<CountryMS, Country>();
            CreateMap<SubdivisionMS, Subdivision>();
        }
    }
}
