using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using SehirRehberi.API.Data;
using SehirRehberi.API.Dto;
using SehirRehberi.API.Models;

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
            var cityForReturn = _mapper.Map<List<CityListForDto>>(cities);

            ; return Ok(cityForReturn);
        }
        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]City city)
        {
            _repository.Add(city);
            _repository.SaveAll();
            return Ok(city);
        }


        [HttpGet]
        [Route("detail")]
        public ActionResult GetCityById(int id)
        {
            var city = _repository.GetCityById(id);
            var cityDetailForReturn = _mapper.Map<CityDetailForDto>(city);
            return Ok(cityDetailForReturn);
        }

        [HttpGet]
        [Route("photos")]
        public ActionResult GetPhotosByCityId(int cityId)
        {
            var city = _repository.GetPhotoByCityId(cityId);
            return Ok(city);
        }
    }
}