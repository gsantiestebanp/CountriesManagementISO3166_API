using CountriesManagementISO3166_API.Dtos;
using CountriesManagementISO3166_API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountriesManagementISO3166_API.Dtos.Request;
using CountriesManagementISO3166_API.Models;

namespace CountriesManagementISO3166_API.Controllers
{
    [Route("api/Countrie")]
    [ApiController]
    public class CountriesController : Controller
    {
        private readonly ICountrieService _countrieService;
        private readonly IMapper _mapper;

        public CountriesController(ICountrieService countrieService, IMapper mapper)
        {
            _countrieService = countrieService;
            _mapper = mapper;
        }

        [HttpGet("GetAllCountries")]
        public ActionResult<IEnumerable<CountrieMS>> GetAllCountries()
        {
            var countrieItems = _countrieService.GetAllCountries();

            return Ok(_mapper.Map<IEnumerable<CountrieMS>>(countrieItems));
        }

        [HttpGet("GetCountrieByCommonName")]
        public ActionResult<CountrieMS> GetCountrieByCommonName(GetCountrieByCommonNameME countrie)
        {
            var countrieItem = _countrieService.GetCountrieByCommonName(countrie.CommonName);
            if (countrieItem != null)
            {
                return Ok(_mapper.Map<CountrieMS>(countrieItem));
            }
            return NotFound();
        }

        [HttpGet("GetCountrieByAlpha2Code")]
        public ActionResult<CountrieMS> GetCountrieByAlpha2Code(GetCountrieByAlpha2CodeME countrie)
        {
            var countrieItem =  _countrieService.GetCountrieByCommonName(countrie.Alpha2Code);
            
            if (countrieItem != null)
            {
                return Ok(_mapper.Map<CountrieMS>(countrieItem));
            }
            return NotFound();
        }

        [HttpPost("InsertCountrie")]
        public ActionResult<CountrieMS> InsertCountrie(CountrieME countrie)
        {
            var countrieModel = _mapper.Map<Countrie>(countrie);
            _countrieService.InsertCountrie(countrieModel);

            var countrieModelMS = _mapper.Map<CountrieMS>(countrieModel);

            return CreatedAtRoute(nameof(GetCountrieByCommonName), new { countrieModelMS.CommonName }, countrieModelMS);
        }

        [HttpPut("UpdateCountrie")]
        public ActionResult UpdateCountrie(GetCountrieByIdME countrie)
        {
            var countrieModel = _countrieService.GetCountrieById(countrie.CountrieId);
            if (countrieModel != null)
            {
                //_mapper.Map(CountrieME, countrieModel);

                _countrieService.UpdateCountrie(countrieModel);

                _countrieService.SaveChanges();

                return NoContent();
            }
            else
               return NotFound();
        }

        [HttpDelete("DeleteCountrie")]
        public ActionResult DeleteCountrie(CountrieME countrie)
        {
            var countrieModel = _countrieService.GetCountrieById(countrie.CountrieId);
            if (countrieModel != null)
            {
                _countrieService.DeleteCountrie(countrieModel);
                _countrieService.SaveChanges();

                return NoContent();
            }
            else 
                return NotFound();
        }
    }
}
