
using System.Collections.Generic;

namespace Elebris.Database.Manager
{
    public interface IStatData
    {
        List<DBStatModel> GetAllStatModels();
    }
}