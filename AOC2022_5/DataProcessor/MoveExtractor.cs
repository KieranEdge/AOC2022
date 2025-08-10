using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AOC2022_5.DataProcessor
{
    internal static class MoveExtractor
    {
        public static List<List<int>> LinesInFileToIntegers(string filePath)
        {
            string integerPattern = @"\d+";
            string[] stringsInFile = File.ReadAllLines(filePath);
            List<List<int>> moveValues = new List<List<int>>();

            foreach (string s in stringsInFile)
            {
                List<int> tempList = new List<int>();
                var matches = Regex.Matches(s, integerPattern);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        tempList.Add(int.Parse(match.Value));
                    }
                }
                moveValues.Add(tempList);
            }

            return moveValues;
        }
    }
}
