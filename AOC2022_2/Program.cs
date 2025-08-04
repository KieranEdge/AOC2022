using AOC2022_2.DataProcessor;
using AOC2022_2.ResultsProcessor;

// Getting all the data
string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_2\\Data\\Data.txt";
List<List<string>> handsList = DataAccessor_Part2.DataSeparator(filePath);
List<string> playerHands = handsList[0];
List<string> opponentHands = handsList[1];

int runningTotal = 0;

for (int i = 0; i < playerHands.Count; i++)
{
    runningTotal += ResultsProcessor.ResultOfHand(opponentHands[i], playerHands[i]);
}
Console.WriteLine($"Total score: {runningTotal}");