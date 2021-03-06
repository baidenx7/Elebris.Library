using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elebris.Data.Manager.Library.Models
{
    public class DBCharacterStatModel
    {
        public int Id { get; set; }
        public string StatName { get; set; }
        public float BaseValue { get; set; }
        public float GenericScale { get; set; }
    }
}
