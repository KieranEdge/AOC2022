using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_11.DataProcessor
{
    internal static class DataExtractor
    {
        public static string[][] MonkeyDataExtractor(string filePath)
        {
            string input = File.ReadAllText(filePath);

            // Split into blocks using double newline as the separator
            string[][] blocks = input
                .Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(b => b.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
                .ToArray();

            return blocks;
        }
    }
}
