using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace LinearOrdering
{
    internal static class Utils
    {
        public static double[][] GetData(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            var rawDaa = lines
                .Skip(1) // remove header row
                .Select(line => line
                    .Replace(',', '.')
                    .Split(';')
                    .Skip(1));

            return rawDaa.Select(line => line.Select(double.Parse).ToArray()).ToArray();
        }

        public static string[] GetFirstColumn(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            var rawDaa = lines
                .Skip(1) // remove header row
                .Select(line => line
                    .Replace(',', '.')
                    .Split(';')
                    .FirstOrDefault());

            return rawDaa.ToArray();
        }

        public static void SetCulture()
        {
            var culture = new CultureInfo("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }

        public static double[][] SwapRowWithColumns(double[][] data)
        {
            var rowLength = data.First().Length;

            var result = new double[rowLength][];
            for (var r = 0; r < result.Length; r++)
            {
                result[r] = new double[data.Length];
            }

            for (var r = 0; r < data.Length; r++)
            {
                for (var c = 0; c < result.Length; c++)
                {
                    result[c][r] = data[r][c];
                }
            }

            return result;
        }

        public static void PrintRanking(string[] columnNames, double[] distances)
        {
            var sorted = columnNames.Select((x, i) => new KeyValuePair<string, double>(x, distances[i]))
                .OrderBy(x => x.Value);

            Console.WriteLine($"Ranking:\n{string.Join(",\n", sorted)}");
        }
    }
}