using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StuHubSystem.Contract.Interfaces;
using StuHubSystem.Core.Entities.VietNamLocation;
using StuHubSystem.DataObject.Entities.VietNamLocation.CityDTO;

namespace StuHubSystem.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class CityController : BaseController
    {
        public IMapper _mapper;
        public ICityRepository _cityRepository;
        public CityController(IMapper mapper, ICityRepository cityRepository)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
        {
            var cities = await _cityRepository.FindAll().ToListAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<CityDTO>>(cities));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            var city = await _cityRepository.FindByIdAsync(id, cancellationToken);
            if (city is null) return NotFound();
            return Ok(_mapper.Map<CityDTO>(city));
        }
        [HttpPost]
        public async Task<IActionResult> Create(CityDTO dto, CancellationToken cancellationToken)
        {
            var city = _mapper.Map<City>(dto);
            _cityRepository.Create(city);
            await _cityRepository.SaveChangesAsync(cancellationToken);
            return CreatedAtAction(nameof(Get), new { city.Id }, _mapper.Map<CityDTO>(city));
        }
        [HttpPut]
        public async Task<IActionResult> Update(CityDTO dto, CancellationToken cancellationToken) 
        {
            var city = await _cityRepository.FindByIdAsync(dto.Id, cancellationToken);
            if (city is null) return NotFound();
            _mapper.Map(dto, city);
            await _cityRepository.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
        [HttpDelete("id")]
        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var city = await _cityRepository.FindByIdAsync(id, cancellationToken);
            if (city is null) return NotFound();
            _cityRepository.Delete(city);
            await _cityRepository.SaveChangesAsync(cancellationToken);
            return NoContent();
        }
    }
}
