using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnWPFApp.Library.Models
{
    public class CharacterStatModel
    {
        int Id { get; set; }
        string StatName { get; set; }
        float BaseValue { get; set; }
        float GenericScale { get; set; }
    }
}
