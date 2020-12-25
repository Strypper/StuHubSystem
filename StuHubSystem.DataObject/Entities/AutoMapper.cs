using AutoMapper;
using StuHubSystem.Core.Entities.EducationSystem;
using StuHubSystem.Core.Entities.Subjects.College;
using StuHubSystem.Core.Entities.VietNamLocation;
using StuHubSystem.DataObject.Entities.EducationSystem;
using StuHubSystem.DataObject.Entities.EducationSystem.SchoolDTO;
using StuHubSystem.DataObject.Entities.Subjects.College.CollegeSubjectDTO;
using StuHubSystem.DataObject.Entities.Subjects.College.CollegeSubjectRequestDTO;
using StuHubSystem.DataObject.Entities.VietNamLocation.CityDTO;
using StuHubSystem.DataObject.Entities.VietNamLocation.DistrictDTO;

namespace StuHubSystem.DataObject.Entities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<School, SchoolDTO>()
                .ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<City, CityDTO>()
                .ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<District, DistrictDTO>()
                .ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<StudyField, StudyFieldDTO>()
                .ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<StudyGroup, StudyGroupDTO>()
                .ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<CollegeSubject, BaseCollegeSubjectDTO>()
                .ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore());

            CreateMap<CollegeSubjectRequest, BaseCollegeSubjectRequestDTO>()
                .ReverseMap()
                .ForMember(d => d.Id, o => o.Ignore());
        }
    }
}
