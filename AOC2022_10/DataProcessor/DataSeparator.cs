using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_10.DataProcessor
{
    internal static class DataSeparator
    {
        public static (List<string>, List<int>) LinesToInstructionsAndIntegers(string filePath)
        {
            List<string> instructions = new List<string>();
            List<int> numbers = new List<int>();
            string[] linesInFile = File.ReadAllLines(filePath);

            foreach (string line in linesInFile)
            {
                if (line.Contains("noop"))
                {
                    instructions.Add(line);
                    numbers.Add(0);
                }
                else if (line.Contains("addx"))
                {
                    instructions.Add(line.Split(' ')[0]);
                    numbers.Add(int.Parse(line.Split(' ')[1]));
                }

            }

            return (instructions, numbers);
        }
    }
}
