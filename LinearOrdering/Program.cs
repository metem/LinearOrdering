using System;
using System.Linq;

namespace LinearOrdering
{
    internal static  class Program
    {
        private static void Main(string[] args)
        {
            NormalizationFunctions.NormalizationFunction normalizationFunction = NormalizationFunctions.Standardization;
            DistanceFunctions.DistanceFunction distanceFunction = DistanceFunctions.Euclidean;

            Utils.SetCulture();
            const string fileName = "notebooks.csv";
            var data = Utils.GetData(fileName);
            var columnNames = Utils.GetFirstColumn(fileName);
            var dataSwaped = Utils.SwapRowWithColumns(data);

            var normalizedDataSwaped = dataSwaped.Select((col, i) =>
                col.Select(value => normalizationFunction(col, value)).ToArray()).ToArray();
            var normalizedData = Utils.SwapRowWithColumns(normalizedDataSwaped);

            var weights = new[] {0.3, 0.2, 0.05, 0.2, 0.2, 0.05}; // edit to fit your needs

            var referenceFunctions = new Func<double>[]
            {
                normalizedDataSwaped[0].Min, normalizedDataSwaped[1].Max, normalizedDataSwaped[2].Max,
                normalizedDataSwaped[3].Max, () => normalizationFunction(dataSwaped[4], 15.6),
                normalizedDataSwaped[5].Min
            }; // edit to fit your needs

            var distances = normalizedData.Select((doubles, i) =>
                distanceFunction(normalizedData[i], referenceFunctions, weights)).ToArray();

            Utils.PrintRanking(columnNames, distances);
            Console.ReadKey();
        }
    }
}