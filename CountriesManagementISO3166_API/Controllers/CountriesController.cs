using AutoMapper;
using CountriesManagementISO3166_API.Dtos;
using CountriesManagementISO3166_API.Dtos.Request;
using CountriesManagementISO3166_API.Helpers;
using CountriesManagementISO3166_API.Models;
using CountriesManagementISO3166_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CountriesManagementISO3166_API.Controllers
{
    [Route("api/Country")]
    [ApiController]
    public class CountriesController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public CountriesController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet("GetAllCountries")]
        public ActionResult<IEnumerable<CountryMS>> GetAllCountries()
        {
            var countryItems = _countryService.GetAllCountries();
            return Ok(_mapper.Map<IEnumerable<CountryMS>>(countryItems));
        }

        [Authorize]
        [HttpPost("GetCountryByCommonName")]
        public ActionResult<CountryMS> GetCountryByCommonName(GetCountryByCommonNameME country)
        {
            var countryItem = _countryService.GetCountryByCommonName(country.CommonName);
            if (countryItem != null)
            {
                return Ok(_mapper.Map<CountryMS>(countryItem));
            }
            return NotFound();
        }

        [Authorize]
        [HttpPost("GetCountryByAlpha2Code")]
        public ActionResult<CountryMS> GetCountryByAlpha2Code(GetCountryByAlpha2CodeME country)
        {
            var countryItem = _countryService.GetCountryByAlpha2Code(country.Alpha2Code);
            
            if (countryItem != null)
            {
                return Ok(_mapper.Map<CountryMS>(countryItem));
            }
            return NotFound();
        }

        [Authorize]
        [HttpPost("InsertCountry")]
        public ActionResult InsertCountry(CountryME country)
        {
            var countryModel = _mapper.Map<Country>(country);
            _countryService.InsertCountry(countryModel);
            _countryService.SaveChanges();
            return NoContent();            
        }

        [Authorize]
        [HttpPut("UpdateCountry")]
        public ActionResult UpdateCountry(CountryME country)
        {
            var countryModel = _countryService.GetCountryById(country.CountryId);
            if (countryModel != null)
            {
                _mapper.Map(country, countryModel);
                _countryService.UpdateCountry(countryModel);
                _countryService.SaveChanges();
                return NoContent();
            }
            else
               return NotFound();
        }

        [Authorize]
        [HttpDelete("DeleteCountry")]
        public ActionResult DeleteCountry(CountryME country)
        {
            var countryModel = _countryService.GetCountryById(country.CountryId);
            if (countryModel != null)
            {
                _countryService.DeleteCountry(countryModel);
                _countryService.SaveChanges();
                return NoContent();
            }
            else 
                return NotFound();
        }
    }
}
