using Elebris.Data.Manager.Library.DataAccess;
using Elebris.Data.Manager.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Claims;

namespace ElebrisApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StatController : ControllerBase
    {
        IConfiguration _config;
        public StatController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        public List<DBCharacterStatModel> Get()
        {
            StatData statData = new StatData(_config);
            return statData.GetStatData();
        }
        [Route("GetStatById")]
        public DBCharacterStatModel GetById(int id)
        {
            StatData statData = new StatData(_config);
            return statData.GetStatById(id);
        }
        [HttpPost]

        [Authorize(Roles = "Admin,Manager")]
        public void Post(DBCharacterStatModel statModel)
        {
            StatData statData = new StatData(_config);

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            statData.SaveCharacterStat(statModel, userId);
        }
    }
}
