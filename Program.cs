﻿using System.Collections.Generic;

namespace StaticClassWithNew
{
    public static class Om21Parameter1
    {
        public static readonly Dictionary<string, double> CoefficientToOhm;
        static Om21Parameter1() => CoefficientToOhm = new Dictionary<string, double> { { _microOhm, 1E-6 } };
        private static readonly string _microOhm = "UOHM";
    }

    public static class Om21Parameter2
    {
        private static readonly string _microOhm = "UOHM";
        public static readonly Dictionary<string, double> CoefficientToOhm = new Dictionary<string, double> { { _microOhm, 1E-6 } };
    }

    class Program
    {
        static void Main(string[] args)
        {
            var coefficientToOhm1 = Om21Parameter1.CoefficientToOhm;
            var coefficientToOhm2 = Om21Parameter2.CoefficientToOhm;
        }
    }
}