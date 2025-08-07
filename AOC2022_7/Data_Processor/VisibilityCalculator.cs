using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_8.Data_Processor
{
    public static class VisibilityCalculator
    {
        public static bool IsTreeVisible(int[] row, int[] col, int row_index, int col_index)
        {
            bool isVisibleRight = IsTreeVisibleRight(row, col_index);
            bool isVisibleLeft = IsTreeVisibleLeft(row, col_index);
            bool isVisibleTop = IsTreeVisibleTop(col, row_index);
            bool isVisibleBottom = IsTreeVisibleBottom(col, row_index);

            if (isVisibleRight || isVisibleLeft || isVisibleTop || isVisibleBottom)
            {
                return true;
            }

            return false;
        }

        private static bool IsTreeVisibleRight(int[] row, int col_index)
        {
            if(col_index != row.Length - 1)
            {
                int cellValue = row[col_index];
                int subArrayLength = row.Length - col_index - 1;
                int[] subArray = new int[subArrayLength];
                Array.Copy(row, col_index + 1, subArray, 0, subArrayLength);
                int maxValueInSubArray = subArray.Max();

                if (cellValue > maxValueInSubArray)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

            return true;
        }
        private static bool IsTreeVisibleLeft(int[] row, int col_index)
        {
            if (col_index > 0)
            {
                int cellValue = row[col_index];
                int subArrayLength = col_index;
                int[] subArray = new int[subArrayLength];
                Array.Copy(row, 0, subArray, 0, subArrayLength);
                int maxValueInSubArray = subArray.Max();
                if (cellValue > maxValueInSubArray)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsTreeVisibleTop(int[] col, int row_index)
        {
            if(row_index > 0)
            {
                int cellValue = col[row_index];
                int subArrayLength = row_index;

                int[] subArray = new int[subArrayLength];
                Array.Copy(col, 0, subArray, 0, subArrayLength);
                int maxValueInSubArray = subArray.Max();

                if (cellValue > maxValueInSubArray)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            return true;
        }

        private static bool IsTreeVisibleBottom(int[] col, int row_index)
        { 
            if(row_index != col.Length - 1)
            {
                int cellValue = col[row_index];
                int subArrayLength = col.Length - row_index - 1;
                int[] subArray = new int[subArrayLength];
                Array.Copy(col, row_index + 1, subArray, 0, subArrayLength);
                int maxValueInSubArray = subArray.Max();

                if (cellValue > maxValueInSubArray)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            

            return true;
        }
    }
}
