using System;

namespace Elebris.Library.Units.Utils.CalculationObjects
{
    public class DecayLowerFormula : IFormulaObject
    {
        //decaylower: (a, b, c) => (b * (a + 1)) / (a + 1 + c) - (b * a) / (a + c),
        public float Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
