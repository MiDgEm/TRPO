using System;
using System.Collections.Generic;

namespace Lab.Core
{
    class LinearEquation
    {
        
        private List<float> arrayResult;

        public List<float> GetLinearEquation(float a, float b)
        {
            if (a == 0)
                throw new NesterenkoException("делить на 0 нельзя");

            NesterenkoLog.I().Log("a = 0. Был вызван метод линейного уравнения");

            return arrayResult = new List<float>() { -b / a };
        }
    }
}
