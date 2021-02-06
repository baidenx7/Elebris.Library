using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elebris.Data.Manager.Library.Models
{
    public class CharacterStatModel
    {
        int Id { get; set; }
        string StatName { get; set; }
        float BaseValue { get; set; }
        float GenericScale { get; set; }
    }
}
