using Elebris.Data.Manager.Library.DataAccess;
using Elebris.Data.Manager.Library.Models;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Http;

namespace Elebris.Data.Manager.Controllers
{
    [Authorize]
    public class StatController : ApiController
    {
        [HttpGet]
        public List<DBCharacterStatModel> Get()
        {
            StatData statData = new StatData();
            return statData.GetStatData();
        }
        [Route("GetStatById")]
        public DBCharacterStatModel GetById(int id)
        {
            StatData statData = new StatData();
            return statData.GetStatById(id);
        }
        [HttpPost]

        [Authorize(Roles = "Admin,Manager")]
        public void Post(DBCharacterStatModel statModel)
        {
            StatData statData = new StatData();

            string userId = RequestContext.Principal.Identity.GetUserId();
            statData.SaveCharacterStat(statModel, userId);
        }
    }
}
