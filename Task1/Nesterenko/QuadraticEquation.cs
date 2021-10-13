using Nesterenko;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesterenko
{
    class QuadraticEquation : LinearEquation, EquationInterface
    {
        protected float GetDisriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b, 2) - 4 * 2 * c;
        }

        List<float> arrayResult;

        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
                return GetLinearEquation(b, c);

            float D = GetDisriminant(a, b, c);

            if (D < 0)
            {
                NesterenkoLog.I().Log("Был вызван метод квадратного уравнения");
                throw new NesterenkoException("Корней нет!");
            }

            NesterenkoLog.I().Log("Был вызван метод квадратного уравнения");

            if (D == 0)
                return arrayResult = new List<float>() { (-(float)Math.Pow(b, 2)) / (2 * a) };

            return arrayResult = new List<float>() { (-b + (float)Math.Sqrt(D)) / (2 * a), (-b - (float)Math.Sqrt(D)) / (2 * a) };
        }
    }
}
