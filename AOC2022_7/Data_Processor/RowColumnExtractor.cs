using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_8.Data_Processor
{
    public static class RowColumnExtractor
    {
        public static int[] GetRow(int[,] array, int rowIndex)
        {
            int cols = array.GetLength(1);
            int[] row = new int[cols];
            for (int i = 0; i < cols; i++)
            {
                row[i] = array[rowIndex, i];
            }
            return row;
        }

        public static int[] GetColumn(int[,] array, int colIndex)
        {
            int rows = array.GetLength(0);
            int[] col = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                col[i] = array[i, colIndex];
            }
            return col;
        }
    }
}
