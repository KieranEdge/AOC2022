using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_3.DataProcessor
{
    internal class DataAnalyserPart2
    {
        public static int FindSharedCharacter(List<string> groupOfStrings)
        {
            string string1 = groupOfStrings[0];
            string string2 = groupOfStrings[1];
            string string3 = groupOfStrings[2];

            var hash1 = new HashSet<char>(string1);
            var hash2 = new HashSet<char>(string2);
            var hash3 = new HashSet<char>(string3);

            hash1.IntersectWith(hash2);
            hash1.IntersectWith(hash3);

            char commonCharacter = hash1.FirstOrDefault();
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
