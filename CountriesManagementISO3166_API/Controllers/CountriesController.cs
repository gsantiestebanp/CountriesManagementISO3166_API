using Countries_Management_ISO3166_API.Models;
using Countries_Management_ISO3166_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries_Management_ISO3166_API.Controllers
{
    [Route("api/Countrie")]
    [ApiController]
    public class CountriesController : Controller
    {
        private readonly ICountrieService _countrieService;

        public CountriesController(ICountrieService countrieService)
        {
            _countrieService = countrieService;
        }

        [HttpGet("GetAllCountries")]
        public Task<List<Countrie>> GetAllCountries() => _countrieService.GetAllCountries();
        
        [HttpGet("GetCountrieByCommonName")]
        public Task<Countrie> GetCountrieByCommonName(string commonName) => _countrieService.GetCountrieByCommonName(commonName);

        [HttpGet("GetCountrieByAlpha2Code")]
        public Task<Countrie> GetCountrieByAlpha2Code(string alpha2Code) => _countrieService.GetCountrieByCommonName(alpha2Code);

        

    }
}
