using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.API.Data;
using SehirRehberi.API.Dto;

namespace SehirRehberi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private IAppRepository _repository;
        private IMapper _mapper;

        public CitiesController(IAppRepository repository, IMapper mapper)
        {
            this._repository = repository;
            _mapper = mapper;
        }

        public ActionResult GetCities()
        {
            var cities = _repository.GetCities();
            var cityForDtos = _mapper.Map<List<CityListForDto>>(cities);

;            return Ok(cityForDtos);
        }
    }
}