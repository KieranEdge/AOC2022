using AOC2022_3.DataProcessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_3\\Data\\Data.Txt";

// Splitting the data into lists
List<List<string>> combinedList = DataAccessor.TextFileToListofSplitStrings(filePath);
List<string> firstColumn = combinedList[0];
List<string> secondColumn = combinedList[1];
int runningTotal = 0;

for (int i = 0;  i < firstColumn.Count; i++)
{
    runningTotal += DataAnalyser.FindSharedCharacter(firstColumn[i], secondColumn[i]);
}

Console.WriteLine($"Value of shared characters: {runningTotal}");