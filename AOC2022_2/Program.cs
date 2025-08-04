using AOC2022_2.DataProcessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_2\\Data\\Data.txt";
List<List<string>> handsList = DataAccessor.DataSeparator(filePath);
List<string> playerHands = handsList[0];
List<string> opponentHands = handsList[1];

Console.WriteLine(playerHands[0]);