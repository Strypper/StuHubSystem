using StuHubSystem.Contract.Interfaces.SubjectInterfaces.CollegeSubjectInterfaces;
using StuHubSystem.Core.Database;
using StuHubSystem.Core.Entities.Subjects.College;

namespace StuHubSystem.Repo.Subjects.College
{
    public class CollegeSubjectRequestRepository : RepositoryBase<CollegeSubjectRequest>, ICollegeSubjectRequestRepository
    {
        public CollegeSubjectRequestRepository(StuHubContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
