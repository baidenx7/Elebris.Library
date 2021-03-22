using Elebris.Data.Manager.Library.DataAccess;
using Elebris.Data.Manager.Library.Models;
using ElebrisApi.Data;
using ElebrisApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ElebrisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _usermanager;

        public UserController(ApplicationDbContext context, UserManager<IdentityUser> usermanager)
        {
            _context = context;
            _usermanager = usermanager;
        }

        [HttpGet]
        public UserModel GetById()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            UserData data = new UserData();
            return data.GetUserById(userId).First();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("User/Admin/GetAllUsers")]
        public List<ApplicationUserModel> GetAllUsers()
        {

            List<ApplicationUserModel> output = new List<ApplicationUserModel>();
          
            var users = _context.Users.ToList();
            //From the user* roles(admin, manager etc) join with Roles on Ids and return a list of all matching users/roles
            var userRoles = from ur in _context.UserRoles
                            join r in _context.Roles on ur.RoleId equals r.Id
                            select new { ur.UserId, ur.RoleId, r.Name };

            foreach (var user in users)
            {
                ApplicationUserModel u = new ApplicationUserModel
                {
                    Id = user.Id,
                    Email = user.Email
                };
                //per user, from the list generated above, split out the relevant roles to add.
                u.Roles = userRoles.Where(x => x.UserId == u.Id).ToDictionary(key => key.RoleId, value => value.Name);
                //foreach (var r in user.Roles)
                //{
                //    u.Roles.Add(r.RoleId, roles.Where(x => x.Id == r.RoleId).First().Name);
                //}

                output.Add(u);

            }
            
            return output;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        [Route("User/Admin/GetAllUsers")]
        public Dictionary<string, string> GetAllRoles()
        {
                var roles = _context.Roles.ToDictionary(k => k.Id, v => v.Name);

                return roles;
            
        }


        [Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("User/Admin/AddRole")]
        public async Task AddRole(UserRolePairModel pairing)
        {
            var user = await _usermanager.FindByIdAsync(pairing.UserId);
            await _usermanager.AddToRoleAsync(user, pairing.RoleName);

        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [Route("User/Admin/RemoveRole")]
        public async Task RemoveRole(UserRolePairModel pairing)
        {
            var user = await _usermanager.FindByIdAsync(pairing.UserId);
            await _usermanager.RemoveFromRoleAsync(user, pairing.RoleName);
        }

    }
}
