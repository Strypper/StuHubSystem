using StuHubSystem.Contract.Interfaces.SubjectInterfaces.CollegeSubjectInterfaces;
using StuHubSystem.Core.Database;
using StuHubSystem.Core.Entities.Subjects.College;

namespace StuHubSystem.Repo.Subjects.College
{
    public class CollegeSubjectRepository : RepositoryBase<CollegeSubject>, ICollegeSubjectRepository
    {
        public CollegeSubjectRepository(StuHubContext repositoryContext): base(repositoryContext)
        {
        }
    }
}
