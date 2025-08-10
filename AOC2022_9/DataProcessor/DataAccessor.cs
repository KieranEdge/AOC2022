using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_9.DataProcessor
{
    internal static class DataAccessor
    {
        public static (List<char>, List<int>) fileToDirectionsAndMoves(string filePath)
        {
            List<char> directionList= new List<char>();
            List<int> movesList = new List<int>();
            string[] linesInFile = File.ReadAllLines(filePath);

            foreach (string line in linesInFile)
            {
                directionList.Add(Char.Parse(line.Split(' ')[0]));
                movesList.Add(int.Parse(line.Split(" ")[1]));
            }

            return (directionList, movesList);
        }
    }
}
