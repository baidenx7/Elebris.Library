using Elebris.Data.Manager.Library.DataAccess;
using Elebris.Data.Manager.Library.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Elebris.Data.Manager.Controllers
{
    //[Authorize]
    public class StatController : ApiController
    {
        [HttpGet]
        public List<CharacterStatModel> Get()
        {
            StatData statData = new StatData();
            return statData.GetStatData();
        }
    }
}
