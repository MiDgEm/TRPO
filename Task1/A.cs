using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class A
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
