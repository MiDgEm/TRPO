using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesterenko
{
    class LinearEquation
    {
        List<float> arrayResult;
        public List<float> GetLinearEquation(float a, float b)
        {
            if (a == 0)
                throw new NesterenkoException("делить на 0 нельзя");

            NesterenkoLog.I().Log("a = 0. Был вызван метод линейного уравнения");

            return arrayResult = new List<float>() { -b / a };
        }
    }
}
