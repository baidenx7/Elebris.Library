using System;
using System.Collections.Generic;
using System.Text;

namespace CaliburnWPFApp.Models
{
    public class CharacterStatModel
    {
        public int Id { get; set; }
        public string StatName { get; set; }
        public float BaseValue { get; set; }
        public float GenericScale { get; set; }

        internal void ResetModel()
        {
            StatName = Id.ToString();
            BaseValue = 0;
            GenericScale = 0;
        }
    }
}
