using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnWPFApp.Library.Models
{
    public class LoggedInUserModel : ILoggedInUserModel
    {
        public string Token { get; set; }
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreatedDate { get; set; }

        public void ResetUserModel()
        {
            Token = "";
            Id = "";
            DisplayName = "";
            EmailAddress = "";
            FirstName = "";
            LastName = "";
            CreatedDate = "";
        }
    }
}
