using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_3.DataProcessor
{
    public static class DataAccessorPart2
    {
        public static List<List<string>> TextFileToListofSplitStrings(string filePath)
        {
            // Initialising the columns
            List<List<string>> groups = new List<List<string>>();

            // Reading the lines to an array
            var arrayOfLines = File.ReadAllLines(filePath);
            int numberOfLines = arrayOfLines.Length;

            for (int i = 0; i < numberOfLines; i += 3)
            {
                List<string> group = arrayOfLines.Skip(i).Take(3).ToList();
                groups.Add(group);
            }

            return groups;
        }
    }
}
