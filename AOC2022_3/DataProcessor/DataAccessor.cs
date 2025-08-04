using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_3.DataProcessor
{
    public static class DataAccessor
    {
        public static List<List<string>> TextFileToListofSplitStrings(string filePath)
        {
            // Initialising the columns
            List<string> firstColumn = new List<string>();
            List<string> secondColumn = new List<string>();
            List<List<string>> strings = new List<List<string>>();
            
            // Reading the lines to an array
            var arrayOfLines = File.ReadAllLines(filePath);
            int middleIndex = 0;

            foreach (var line in arrayOfLines) 
            {
                middleIndex = line.Length/2;
                firstColumn.Add(line.Substring(0, middleIndex));
                secondColumn.Add(line.Substring(middleIndex, line.Length - middleIndex));
            }

            strings.Add(firstColumn);
            strings.Add(secondColumn);
            return strings;
        }
    }
}
