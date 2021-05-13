using System;

namespace Elebris.Library.Units.Utils.CalculationObjects
{
    public class DecayMultiLowerFormula : IFormulaObject
    {
        // decaymultilower: (a, b, c) => (b * (a + 1)) / (a + 1 + c) - (b * a) / (a + c),
        public float Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
