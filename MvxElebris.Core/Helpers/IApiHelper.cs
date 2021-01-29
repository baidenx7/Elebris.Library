using System.Threading.Tasks;

namespace MvxElebris.Core.Helpers
{
    public interface IApiHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}