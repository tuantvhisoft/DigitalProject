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
    public class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(DsDbContext context) : base(context)
        {
        }
    }
}