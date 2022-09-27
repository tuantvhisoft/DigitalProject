using System;
using DS.Core.EF;

namespace DS.ViewModel.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DsDbContext _context;

        
        //private IRoleRepository? _roles;
        //private IUserLoginTokenRepository? _userLoginTokens;
        //private IUserRepository? _users;
        //private IUserRoleRepository? _userRoles;

        public UnitOfWork(DsDbContext context)
        {
            _context = context;
        }


        //public IRoleRepository Roles => _roles ??= new RoleRepository(_context);

        //public IUserLoginTokenRepository UserLoginTokens => _userLoginTokens ??= new UserLoginTokenRepository(_context);

        //public IUserRepository Users => _users ??= new UserRepository(_context);

        //public IUserRoleRepository UserRoles => _userRoles ??= new UserRoleRepository(_context);


        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}


