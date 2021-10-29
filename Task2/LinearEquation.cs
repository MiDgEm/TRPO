using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class LinearEquation
    {
        List<float> arrayResult;

        public List<float> GetLinearEquation(float a, float b)
        {
            if (a == 0)
                return null;

            return arrayResult = new List<float>() { -b / a };
        }
    }
}
