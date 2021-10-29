﻿using System;
using System.Collections.Generic;

namespace Task2
{
    class QuadraticEquation : LinearEquation
    {
        protected float GetDisriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b, 2) - 4 * 2 * c;
        }

        List<float> arrayResult;

        public List<float> GetRoots(float a, float b, float c)
        {
            if (a == 0)
                return GetLinearEquation(b, c);

            float D = GetDisriminant(a, b, c);

            if (D == 0)
                return arrayResult = new List<float>() { (-(float)Math.Pow(b, 2)) / (2 * a) };

            if (D < 0)
                return null;

            return arrayResult = new List<float>() { (-b + (float)Math.Sqrt(D)) / (2 * a), (-b - (float)Math.Sqrt(D)) / (2 * a) };
        }
    }
}
