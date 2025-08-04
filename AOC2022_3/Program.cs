using AOC2022_3.DataProcessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_3\\Data\\Data.Txt";

//Part 1
//Splitting the data into lists
List<List<string>> combinedList = DataAccessorPart1.TextFileToListofSplitStrings(filePath);
List<string> firstColumn = combinedList[0];
List<string> secondColumn = combinedList[1];
int runningTotal_part1 = 0;

for (int i = 0;  i < firstColumn.Count; i++)
{
    runningTotal_part1 += DataAnalyserPart1.FindSharedCharacter(firstColumn[i], secondColumn[i]);
}

Console.WriteLine($"Value of shared characters for part 1: {runningTotal_part1}");

List<List<string>> groupsOfThree = new List<List<string>>();

//Part 2
List<List<string>> groupedStrings = DataAccessorPart2.TextFileToListofSplitStrings(filePath);
int runningTotal_part2 = 0;

foreach (List<string> group in groupedStrings)
{
    runningTotal_part2 += DataAnalyserPart2.FindSharedCharacter(group);
}

Console.WriteLine($"Value of shared characters for part 2: {runningTotal_part2}");