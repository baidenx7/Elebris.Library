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
        [HttpPost]
        public void Post(DBCharacterStatModel statModel)
        {
            StatData statData = new StatData();

            string userId = RequestContext.Principal.Identity.GetUserId();
            statData.SaveCharacterStat(statModel, userId);
        }
    }
}
