using AOC2022_11.DataProcessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_Day11\\Data\\Data.txt";

// Breaking the text into monkey blocks of text
string[][] monkeyTextBlocks = DataExtractor.MonkeyDataExtractor(filePath);
int[] howManyItemsHasEachMonkeyInspected = new int[monkeyTextBlocks.Length];
Dictionary<int, MonkeyModel> monkeyDictionary = new Dictionary<int, MonkeyModel>();


// Populating the data for the monkeys dictionary
for(int i = 0; i < monkeyTextBlocks.Length; i++)
{
    MonkeyModel temporaryMonkey = new MonkeyModel(monkeyTextBlocks[i]);
    monkeyDictionary[temporaryMonkey.Id] = temporaryMonkey;
}

long modulus = monkeyDictionary.Values
    .Select(m => (long)m.TestDivisibleBy)
    .Aggregate((a, b) => a * b);


for (int i = 0; i < 10000; i++)
{
    for (int j = 0; j < 8; j++)
    {
        // iterate over a snapshot to be extra safe if you want:
        // foreach (var worryItem in monkeyDictionary[j].StartingItems.ToArray())
        foreach (var worryItem in monkeyDictionary[j].StartingItems)
        {
            howManyItemsHasEachMonkeyInspected[j]++;

            long newWorryValue = WorryLogic.WorryFactor(
                (long)worryItem,
                (long)monkeyDictionary[j].WorryFactor,
                monkeyDictionary[j].Operation,
                monkeyDictionary[j].isSquare
            );

            // Part 2: no divide by 3, just modulo
            newWorryValue %= modulus;

            bool goesTrue = WorryLogic.WorryTest(newWorryValue, monkeyDictionary[j].TestDivisibleBy);

            int reduced = (int)newWorryValue; // safe: modulus = 9,699,690 fits in int
            if (goesTrue)
                monkeyDictionary[monkeyDictionary[j].IfTrueThrowTo].StartingItems.Add(reduced);
            else
                monkeyDictionary[monkeyDictionary[j].IfFalseThrowTo].StartingItems.Add(reduced);
        }

        monkeyDictionary[j].StartingItems.Clear();
    }
}

for (int i = 0; i < 8; i++)
{
    string monkeyName = $"Monkey {monkeyDictionary[i].Id}";
    string items = "";

    foreach(int item in monkeyDictionary[i].StartingItems)
    {
        items = String.Concat(items, ", ", item.ToString());
    }

    Console.WriteLine(monkeyName);
    Console.WriteLine(items);
}

foreach (int countedItem in howManyItemsHasEachMonkeyInspected)
{
    Console.WriteLine(countedItem);
}