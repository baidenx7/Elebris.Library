using System;
using System.Collections.Generic;
using System.Text;

namespace CaliburnWPFApp.Models
{
    public class CharacterStatModel
    {
        int Id { get; set; }
        string StatName { get; set; }
        float BaseValue { get; set; }
        float GenericScale { get; set; }
    }
}
