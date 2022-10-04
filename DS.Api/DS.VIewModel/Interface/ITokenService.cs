using System;
using DS.Core.Entity;

namespace DS.ViewModel.Interface
{
    public interface ITokenService
    {
        string CreateToken(User user);
        UserLoginToken GenerateRefreshToken(bool remember);
    }
}

