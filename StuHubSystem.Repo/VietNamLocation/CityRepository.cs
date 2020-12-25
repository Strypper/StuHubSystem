using StuHubSystem.Contract.Interfaces;
using StuHubSystem.Core.Database;
using StuHubSystem.Core.Entities.VietNamLocation;

namespace StuHubSystem.Repo.VietNamLocation
{
    public class CityRepository : RepositoryBase<City>, ICityRepository
    {
        public CityRepository(StuHubContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
