using CaliburnWPFApp.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaliburnWPFApp.Library.Api
{
    public interface IUserEndpoint
    {
        Task<List<UserModel>> GetAll();
        Task AddUserToRole(string userid, string rolename);
        Task<Dictionary<string, string>> GetAllRoles();
        Task RemoveUserFromRole(string userid, string rolename);
    }
}