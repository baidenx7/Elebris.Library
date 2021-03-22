using Elebris.Data.Manager.Library.DataAccess;
using Elebris.Data.Manager.Library.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class StatController : ControllerBase
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

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            statData.SaveCharacterStat(statModel, userId);
        }
    }
}
