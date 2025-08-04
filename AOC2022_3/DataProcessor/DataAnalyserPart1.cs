using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_3.DataProcessor
{
    public static class DataAnalyserPart1
    {
        public static int FindSharedCharacter(string firstPart, string secondPart)
        {
            char commonCharacter = firstPart.Intersect(secondPart).FirstOrDefault();
            int sharedCharacterValue = 0;
            if (char.IsLower(commonCharacter))
            {
                sharedCharacterValue = commonCharacter - 'a' + 1;
            }
            else
            {
                sharedCharacterValue = commonCharacter - 'A' + 27;
            }

            return sharedCharacterValue;
        }
    }
}
