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
            CreateMap<Countrie, CountrieMS>();
            CreateMap<Subdivision, SubdivisionMS>();

            //Target -> Source
            CreateMap<CountrieMS, Countrie>();
            CreateMap<SubdivisionMS, Subdivision>();
        }
    }
}
