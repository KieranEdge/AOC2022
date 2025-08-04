using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_2.ResultsProcessor
{
    public static class ResultsProcessor
    {
        public static int ResultOfHand(string playerHand, string opponentHand)
        {
            int result = 0;
            if (playerHand == "Rock")
            {
                if (opponentHand == "Rock")
                {
                    result = 4;
                }
                else if (opponentHand == "Paper")
                {
                    result = 1;
                }
                else
                {
                    result = 7;
                }
            }
            else if (playerHand == "Paper")
            {
                if (opponentHand == "Rock")
                {
                    result = 8;
                }
                else if (opponentHand == "Paper")
                {
                    result = 5;
                }
                else
                {
                    result = 2;
                }
            }
            else if (playerHand == "Scissors")
            {
                if (opponentHand == "Rock")
                {
                    result = 3;
                }
                else if (opponentHand == "Paper")
                {
                    result = 9;
                }
                else
                {
                    result = 6;
                }
            }

            return result;
        }
    }
}
