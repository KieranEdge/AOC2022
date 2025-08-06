using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_4.Data_Accessor
{
    public static class DataAccessor
    {
        public static (List<int[,]>, List<int[,]>) TextFileToIntegerArrays(string filePath)
        {
            // Reading the file
            var linesInFile = File.ReadLines(filePath);
            int lengthOfArray = linesInFile.Count();
            List<int[,]> integers1 = new List<int[,]>();
            List<int[,]> integers2 = new List<int[,]>();

            foreach( string line in linesInFile )
            {
                var (values1, values2) = StringParser(line);
                integers1.Add(values1);
                integers2.Add(values2);
            }

            return (integers1, integers2);
        }

        private static (int[,], int[,]) StringParser(string str)
        {
            string sequence1 = str.Split(",")[0];
            string sequence2 = str.Split(",")[1];
            int[,] integers1 = { { int.Parse(sequence1.Split("-")[0]) }, { int.Parse(sequence1.Split("-")[1]) } };
            int[,] integers2 = { { int.Parse(sequence2.Split("-")[0]) }, { int.Parse(sequence2.Split("-")[1]) } };

            return (integers1, integers2);
        }
    }
}
