using AutoMapper;
using CountriesManagementISO3166_API.Dtos;
using CountriesManagementISO3166_API.Dtos.Request;
using CountriesManagementISO3166_API.Models;
using CountriesManagementISO3166_API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CountriesManagementISO3166_API.Controllers
{
    [Route("api/Subdivision")]
    [ApiController]
    public class SubdivisionsController : Controller
    {
        private readonly ISubdivisionService _subdivisionService;
        private readonly IMapper _mapper;

        public SubdivisionsController(ISubdivisionService subdivisionService, IMapper mapper)
        {
            _subdivisionService = subdivisionService;
            _mapper = mapper;
        }

        [HttpGet("GetAllSubdivisions")]
        public ActionResult<IList<SubdivisionMS>> GetAllSubdivisions()
        {
            var countrieItems = _subdivisionService.GetAllSubdivisions();
            return Ok(_mapper.Map<IEnumerable<SubdivisionMS>>(countrieItems));
        }

        [HttpPost("GetSubdivisionById")]
        public ActionResult<SubdivisionMS> GetSubdivisionById(GetSubdivisionByIdME subdivision)
        {
            var subdivisionItem = _subdivisionService.GetSubdivisionById(subdivision.SubdivisionId);
            if (subdivisionItem != null)
            {
                return Ok(_mapper.Map<SubdivisionMS>(subdivisionItem));
            }
            return NotFound();
        }

        [HttpPost("InsertSubdivision")]
        public ActionResult<SubdivisionMS> InsertSubdivision(SubdivisionME subdivision)
        {
            var subdivisionModel = _mapper.Map<Subdivision>(subdivision);
            _subdivisionService.InsertSubdivision(subdivisionModel);
            return NoContent();
        }

        [HttpPut("UpdateSubdivision")]
        public ActionResult UpdateSubdivision(SubdivisionME subdivision)
        {
            var subdivisionModel = _subdivisionService.GetSubdivisionById(subdivision.SubdivisionId);
            if (subdivisionModel != null)
            {
                _mapper.Map(subdivision, subdivisionModel);
                _subdivisionService.UpdateSubdivision(subdivisionModel);
                _subdivisionService.SaveChanges();
                return NoContent();
            }
            else
                return NotFound();
        }

        [HttpDelete("DeleteSubdivision")]
        public ActionResult DeleteSubdivision(SubdivisionME subdivision)
        {
            var subdivisionModel = _subdivisionService.GetSubdivisionById(subdivision.SubdivisionId);
            if (subdivisionModel != null)
            {
                _subdivisionService.DeleteSubdivision(subdivisionModel);
                _subdivisionService.SaveChanges();
                return NoContent();
            }
            else
                return NotFound();
        }
    }
}
