using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_2.DataProcessor
{
    internal static class DataAccessor_Part2
    {
        public static List<List<string>> DataSeparator(string filePath)
        {
            // Initialising the results lists
            List<List<string>> resultsList = new List<List<String>>();
            List<string> playerHand = new List<string>();
            List<string> opponentHand = new List<string>();
            List<string> temporaryResult = new List<string>();

            // Initialising the streamreader and getting the initial result
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine();
            temporaryResult = StringConverter(line);
            playerHand.Add(temporaryResult[0]);
            opponentHand.Add(temporaryResult[1]);

            while (line != null)
            {
                line = sr.ReadLine();
                temporaryResult = StringConverter(line);
                playerHand.Add(temporaryResult[0]);
                opponentHand.Add(temporaryResult[1]);
            }

            resultsList.Add(playerHand);
            resultsList.Add(opponentHand);

            return resultsList;

        }

        private static List<string> StringConverter(string line)
        {
            string lineToProcess = line;
            Console.WriteLine(lineToProcess);
            List<String> result = new List<String>();
            string playerHand = "";
            string opponentHand = "";


            if (lineToProcess != null)
            {
                playerHand = lineToProcess.Split(' ')[0];
                opponentHand = lineToProcess.Split(' ')[1];

                if (playerHand == "A")
                {
                    playerHand = "Rock";
                    
                    if(opponentHand == "X")
                    {
                        opponentHand = "Scissors";
                    }
                    else if (opponentHand == "Y")
                    {
                        opponentHand = playerHand;
                    }
                    else
                    {
                        opponentHand = "Paper";
                    }
                }
                else if (playerHand == "B")
                {
                    playerHand = "Paper";

                    if (opponentHand == "X")
                    {
                        opponentHand = "Rock";
                    }
                    else if (opponentHand == "Y")
                    {
                        opponentHand = playerHand;
                    }
                    else
                    {
                        opponentHand = "Scissors";
                    }
                }
                else if (playerHand == "C")
                {
                    playerHand = "Scissors";

                    if (opponentHand == "X")
                    {
                        opponentHand = "Paper";
                    }
                    else if (opponentHand == "Y")
                    {
                        opponentHand = playerHand;
                    }
                    else
                    {
                        opponentHand = "Rock";
                    }
                }

            }


            result.Add(playerHand);
            result.Add(opponentHand);
            return result;
        }
    }
}
