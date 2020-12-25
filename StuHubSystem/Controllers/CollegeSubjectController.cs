using AutoMapper;
using StuHubSystem.Contract.Interfaces.SubjectInterfaces.CollegeSubjectInterfaces;

namespace StuHubSystem.Controllers
{
    public class CollegeSubjectController : BaseController
    {
        public IMapper _mapper;
        public ICollegeSubjectRepository _collegeSubjectRepository;
        public CollegeSubjectController(IMapper mapper, ICollegeSubjectRepository collegeSubjectRepository)
        {
            _mapper = mapper;
            _collegeSubjectRepository = collegeSubjectRepository;
        }


    }
}
