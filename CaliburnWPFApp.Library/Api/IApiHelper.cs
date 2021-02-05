
using CaliburnWPFApp.Models;
using System.Threading.Tasks;

namespace CaliburnWPFApp.Library.Api
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}