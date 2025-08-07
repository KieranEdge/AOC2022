using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_6.Data_Accessor
{
    public static class Data_Accessor
    {
        public static char[] TextFileToCharacterArray(string filePath)
        {
            string allText = File.ReadAllText(filePath);
            List<char> characters = new List<char>();
            foreach (char c in allText)
            {
                characters.Add(c);
            }
            return characters.ToArray();
        }
    }
}
