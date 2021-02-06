using CaliburnWPFApp.Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaliburnWPFApp.Library.Api
{
    public interface ICharacterStatEndpoint
    {
        Task<List<CharacterStatModel>> GetAll();
    }
}