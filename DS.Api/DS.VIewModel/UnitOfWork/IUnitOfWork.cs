using System;
namespace DS.ViewModel.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //IRoleRepository Roles { get; }
        //IUserLoginTokenRepository UserLoginTokens { get; }
        //IUserRepository Users { get; }
        //IUserRoleRepository UserRoles { get; }
        //IWishListRepository WishLists { get; }

        Task<int> SaveChangeAsync();
    }
}


