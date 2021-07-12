using AutoMapper;
using CountriesManagementISO3166_API.Dtos;
using CountriesManagementISO3166_API.Dtos.Request;
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

        [HttpGet("GetAllCountries")]
        public ActionResult<IEnumerable<CountryMS>> GetAllCountries()
        {
            var countrieItems = _countryService.GetAllCountries();
            return Ok(_mapper.Map<IEnumerable<CountryMS>>(countrieItems));
        }

        [HttpPost("GetCountryByCommonName")]
        public ActionResult<CountryMS> GetCountrieByCommonName(GetCountryByCommonNameME countrie)
        {
            var countrieItem = _countryService.GetCountryByCommonName(countrie.CommonName);
            if (countrieItem != null)
            {
                return Ok(_mapper.Map<CountryMS>(countrieItem));
            }
            return NotFound();
        }

        [HttpPost("GetCountryByAlpha2Code")]
        public ActionResult<CountryMS> GetCountrieByAlpha2Code(GetCountryByAlpha2CodeME countrie)
        {
            var countrieItem = _countryService.GetCountryByCommonName(countrie.Alpha2Code);
            
            if (countrieItem != null)
            {
                return Ok(_mapper.Map<CountryMS>(countrieItem));
            }
            return NotFound();
        }

        [HttpPost("InsertCountry")]
        public ActionResult<CountryMS> InsertCountrie(CountryME countrie)
        {
            var countrieModel = _mapper.Map<Country>(countrie);
            _countryService.InsertCountry(countrieModel);
            _countryService.SaveChanges();
            return NoContent();            
        }

        [HttpPut("UpdateCountry")]
        public ActionResult UpdateCountrie(CountryME countrie)
        {
            var countrieModel = _countryService.GetCountryById(countrie.CountryId);
            if (countrieModel != null)
            {
                _mapper.Map(countrie, countrieModel);
                _countryService.UpdateCountry(countrieModel);
                _countryService.SaveChanges();
                return NoContent();
            }
            else
               return NotFound();
        }

        [HttpDelete("DeleteCountry")]
        public ActionResult DeleteCountrie(CountryME countrie)
        {
            var countrieModel = _countryService.GetCountryById(countrie.CountryId);
            if (countrieModel != null)
            {
                _countryService.DeleteCountry(countrieModel);
                _countryService.SaveChanges();
                return NoContent();
            }
            else 
                return NotFound();
        }
    }
}
