using System;
using System.Linq;

namespace LinearOrdering
{
    internal static class NormalizationFunctions
    {
        public delegate double NormalizationFunction(double[] column, double value);

        public static double Standardization(double[] column, double value)
        {
            var average = column.Average();
            return (value - average) /
                   Math.Sqrt((column.Select(val => (val - average) * (val - average)).Sum()) / column.Length);
        }

        private static double QuotientTransformation(double[] column, double value)
        {
            return value / column.Select(Math.Abs).Max();
        }
    }
}