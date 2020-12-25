using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StuHubSystem.Contract.Interfaces.SubjectInterfaces.CollegeSubjectInterfaces;
using StuHubSystem.Core.Entities.Subjects.College;
using StuHubSystem.DataObject.Entities.Subjects.College.CollegeSubjectRequestDTO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StuHubSystem.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class CollegeSubjectRequestController : BaseController
    {
        public IMapper _mapper;
        public ICollegeSubjectRequestRepository _collegeSubjectRequestRepository; 
        public CollegeSubjectRequestController(IMapper mapper, ICollegeSubjectRequestRepository collegeSubjectRequestRepository)
        {
            _mapper = mapper;
            _collegeSubjectRequestRepository = collegeSubjectRequestRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken = default)
        {
            var collegeSubjectRequests = await _collegeSubjectRequestRepository.FindAll().ToListAsync(cancellationToken);
            return Ok(_mapper.Map<IEnumerable<BaseCollegeSubjectRequestDTO>>(collegeSubjectRequests));
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(int id ,CancellationToken cancellationToken)
        {
            var collegeSubjectRequests = await _collegeSubjectRequestRepository.FindByIdAsync(id, cancellationToken);
            if (collegeSubjectRequests is null) return NotFound();
            return Ok(_mapper.Map<CollegeSubjectRequest>(collegeSubjectRequests));
        }


    }
}
