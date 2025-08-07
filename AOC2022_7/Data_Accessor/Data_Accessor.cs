using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_8.Data_Accessor
{
    public static class Data_Accessor
    {
        public static int[,] FileToIntArray(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            int numberOfRows = lines.Length;
            int numberOfCols = lines[0].Length;
            int[,] integerArray = new int[numberOfRows, numberOfCols];
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfCols; j++)
                {
                    integerArray[i,j] = int.Parse(lines[i][j].ToString());
                }
            }
            return integerArray;
        }
    }
}
