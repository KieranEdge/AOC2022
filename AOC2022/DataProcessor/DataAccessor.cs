using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_1.DataProcessor
{
    public static class DataAccessor
    {
        public static void FileReader(string filePath)
        {
            // Initialising the streamreader and results list
            StreamReader sr = new StreamReader(filePath);
            List<int> resultsList = new List<int>();

            // Reading the first line and parsing it to an int
            string line = sr.ReadLine();
            int rollingSum = int.Parse(line);

            // Continuing to read the lines
            while (line != null)
            {
                // Read the next line
                line = sr.ReadLine();
                Console.WriteLine(line);
                // If it's not an empty string, add to the rolling sum
                if (line != "" && line != null)
                {
                    rollingSum += int.Parse(line);
                }

                // If it's a gap add the rolling sum to the list and reset the sum to zero
                else
                {
                    resultsList.Add(rollingSum);
                    rollingSum = 0;
                }
            }

            sr.Close();

            Console.WriteLine(resultsList.Max());

        }
    }
}
