using DS.ViewModel.IRepositories;
using System;
namespace DS.ViewModel.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRoleRepository Roles { get; }
        IUserLoginTokenRepository UserLoginTokens { get; }
        IUserRepository Users { get; }
        IUserRoleRepository UserRoles { get; }
        Task<int> SaveChangeAsync();
    }
}


