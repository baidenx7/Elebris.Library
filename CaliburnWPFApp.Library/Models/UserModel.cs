using System.Collections.Generic;
using System.Linq;

namespace CaliburnWPFApp.Library.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Email { get; set; }

        public Dictionary<string, string> Roles { get; set; }
        public string RoleList
        {
            get
            {
                return string.Join(", ", Roles.Select(x => x.Value));
            }
        }
    }
}
