using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_8.Data_Processor
{
    internal class ScenicScore
    {
        public static int CalculateScenecity(int[] row, int[] col, int rowIndex, int colIndex)
        {
            int scoreRight = ScoreRight(row, colIndex);
            int scoreLeft = ScoreLeft(row, colIndex);
            int scoreUp = ScoreUp(col, rowIndex);
            int scoreDown = ScoreDown(col, rowIndex);

            return scoreRight * scoreLeft * scoreUp * scoreDown;
        }

        private static int ScoreRight(int[] row, int colIndex)
        {
            int score = 0;
            int height = row[colIndex];

            for (int i = colIndex + 1; i < row.Length; i++)
            {
                score++;
                if (row[i] >= height)
                    break;
            }

            return score;
        }

        private static int ScoreLeft(int[] row, int colIndex)
        {
            int score = 0;
            int height = row[colIndex];

            for (int i = colIndex - 1; i >= 0; i--)
            {
                score++;
                if (row[i] >= height)
                    break;
            }

            return score;
        }

        private static int ScoreUp(int[] col, int rowIndex)
        {
            int score = 0;
            int height = col[rowIndex];

            for (int i = rowIndex - 1; i >= 0; i--)
            {
                score++;
                if (col[i] >= height)
                    break;
            }

            return score;
        }

        private static int ScoreDown(int[] col, int rowIndex)
        {
            int score = 0;
            int height = col[rowIndex];

            for (int i = rowIndex + 1; i < col.Length; i++)
            {
                score++;
                if (col[i] >= height)
                    break;
            }

            return score;
        }
    }
}