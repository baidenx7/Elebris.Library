using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnWPFApp.Library.Models
{
    public class StagedCharacterStatModel
    {
        public int Id { get; set; }
        public string StatName { get; set; }
        public float BaseValue { get; set; }
        public float GenericScale { get; set; }
    }
}
