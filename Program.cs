using System;
using System.Collections.Generic;
using System.Globalization;

namespace StaticClassWithNew
{
    public static class Om21Parameter1
    {
        public static readonly Dictionary<string, double> CoefficientToOhm;
        public static readonly CultureInfo CultureInfo;

        static Om21Parameter1()
        {
            CoefficientToOhm = new Dictionary<string, double> { { _microOhm, 1E-6 }, { _milliOhm, 1E-3 }, { _ohm, 1 } };
            CultureInfo = new CultureInfo("en-US");
        }

        private static readonly string _microOhm = "UOHM";
        private static readonly string _milliOhm = "MOHM";
        private static readonly string _ohm = "OHM";
    }

    public static class Om21Parameter2
    {
        public static readonly Dictionary<string, double> CoefficientToOhm = new Dictionary<string, double> { { _microOhm, 1E-6 }, { _milliOhm, 1E-3 }, { _ohm, 1 } };
        public static readonly CultureInfo CultureInfo = new CultureInfo("en-US");

        private static readonly string _microOhm = "UOHM";
        private static readonly string _milliOhm = "MOHM";
        private static readonly string _ohm = "OHM";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> coefficientToOhm1 = new Dictionary<string, double>();
            Dictionary<string, double> coefficientToOhm2 = new Dictionary<string, double>();
            CultureInfo cultureInfo1 = new CultureInfo(1);
            CultureInfo cultureInfo2 = new CultureInfo(1);
            try
            {
                coefficientToOhm1 = Om21Parameter1.CoefficientToOhm;
                cultureInfo1 = Om21Parameter1.CultureInfo;
            }
            catch
            {

            }

            try
            {
                coefficientToOhm2 = Om21Parameter2.CoefficientToOhm;
                cultureInfo2 = Om21Parameter2.CultureInfo;
            }
            catch
            {
            }
            coefficientToOhm1.TryGetValue("UOHM", out double coefficientToOhm1uohm);
            coefficientToOhm2.TryGetValue("UOHM", out double coefficientToOhm2uohm);

            Console.WriteLine($"coefficientToOhm1uohm : {coefficientToOhm1uohm}");
            Console.WriteLine($"cultureInfo1 : {cultureInfo1}");
            Console.WriteLine($"coefficientToOhm2uohm : {coefficientToOhm2uohm}");
            Console.WriteLine($"cultureInfo2 : {cultureInfo2}");

        }
    }
}
