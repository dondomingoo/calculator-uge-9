﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Calculator
    {
        public int Add(int a, int b) // denne metode tager to integers og returnerer summen af dem som en integer.
        {
            return a + b;
        }

        public int Subtract(int a, int b) // Denne metode tage to integers og subtrahere dem.
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            return (double)a / (double)b;
        }


    }
}