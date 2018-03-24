using System;
using System.Linq;

namespace LinearOrdering
{
    internal static class DistanceFunctions
    {
        public delegate double DistanceFunction(double[] row, Func<double>[] wzorce, double[] weights);

        public static double Euclidean(double[] row, Func<double>[] wzorce, double[] weights)
        {
            var temp = row.Select((t, i) => Math.Pow(t - wzorce[i](), 2) * weights[i]);
            return Math.Sqrt(temp.Sum());
        }

        public static double Max(double[] row, Func<double>[] wzorce, double[] weights)
        {
            var temp = row.Select((t, i) => Math.Abs(t - wzorce[i]()) * weights[i]);
            return temp.Max();
        }
    }
}