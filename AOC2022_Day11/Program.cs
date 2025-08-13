using AOC2022_11.DataProcessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_Day11\\Data\\Data.txt";

// Breaking the text into monkey blocks of text
string[][] monkeyTextBlocks = DataExtractor.MonkeyDataExtractor(filePath);
List<string> monkeyNames = new List<string>();
Dictionary<int, MonkeyModel> monkeyDictionary = new Dictionary<int, MonkeyModel>();

for(int i = 0; i < monkeyTextBlocks.Length; i++)
{
    MonkeyModel temporaryMonkey = new MonkeyModel(monkeyTextBlocks[i]);
    monkeyDictionary[temporaryMonkey.Id] = temporaryMonkey;
}

Console.WriteLine(monkeyDictionary[1].Operation);