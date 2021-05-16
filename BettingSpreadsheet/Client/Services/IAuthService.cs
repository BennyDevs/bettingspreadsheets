using System;
using System.Threading.Tasks;
using BettingSpreadsheet.Shared;

namespace BettingSpreadsheet.Client.Services
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<string>> Login(UserLogin request);
    }
}
