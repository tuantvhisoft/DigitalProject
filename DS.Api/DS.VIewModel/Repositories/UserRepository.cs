using DS.Core.EF;
using DS.Core.Entity;
using DS.ViewModel.IRepositories;

namespace DS.ViewModel.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DsDbContext context) : base(context)
        {
        }
    }
}