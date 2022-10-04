using DS.Core.EF;
using DS.Core.Entity;
using DS.ViewModel.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS.ViewModel.Repositories
{
    public class UserLoginTokenRepository : RepositoryBase<UserLoginToken>, IUserLoginTokenRepository
    {
        public UserLoginTokenRepository(DsDbContext context) : base(context)
        {
        }
    }
}
