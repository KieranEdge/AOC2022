using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_5.DataProcessor
{
    internal static class StartingPositionExtractor
    {
        public static Dictionary<int, List<char>> GetCratesStartingPositions(string filePath)
        {
            // Figure out the column positions (e.g., 1, 5, 9, ...)
            var firstLine = File.ReadLines(filePath).First();
            var columnPositions = Enumerable.Range(0, (firstLine.Length + 1) / 4)
                .Select(i => 1 + i * 4)
                .ToList();

            // Create dictionary with an empty list for each column
            var columns = columnPositions
                .Select((pos, idx) => new { idx, pos })
                .ToDictionary(x => x.idx + 1, x => new List<char>()); // 1-based stack number

            foreach (var line in File.ReadLines(filePath))
            {
                foreach (var (pos, stackIndex) in columnPositions.Select((p, i) => (p, i + 1)))
                {
                    if (pos < line.Length && char.IsLetter(line[pos]))
                    {
                        columns[stackIndex].Add(line[pos]);
                    }
                }
            }

            // Example output
            foreach (var kvp in columns)
            {
                Console.WriteLine($"Stack {kvp.Key}: {string.Join("", kvp.Value)}");
            }

            return columns;
        }
    }
}
