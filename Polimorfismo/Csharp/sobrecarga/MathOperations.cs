﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga
{
    public class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
