using DS.ViewModel.VModel.Authentication;
using DS.ViewModel.VModel.User;
using System;
namespace DS.ViewModel.Interface
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> Login(LoginViewModel loginVm);
        Task<AuthenticationResponse> Register(RegisterViewModel registerVm);
        Task<AuthenticationResponse> RefreshToken();
        Task<UserViewModel> GetCurrentUser();
    }
}

