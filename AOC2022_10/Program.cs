using AOC2022_10.DataProcessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_10\\Data\\Data.txt";

List<string> instructions = new List<string>();
List<int> values = new List<int>();
int totalValue = 1;

List<int> valueAtCycle = new List<int>();

(instructions, values) = DataSeparator.LinesToInstructionsAndIntegers(filePath);

for (int i = 0; i < instructions.Count; i++)
{
    valueAtCycle.Add(totalValue);
    if (instructions[i] == "addx")
    {
        valueAtCycle.Add(totalValue);
        totalValue += values[i];
    }
}

int cycle20 = valueAtCycle[19] * 20;
int cycle60 = valueAtCycle[59] * 60;
int cycle100 = valueAtCycle[99] * 100;
int cycle140 = valueAtCycle[139] * 140;
int cycle180 = valueAtCycle[179] * 180;
int cycle220 = valueAtCycle[219] * 220;

int cycleSum = cycle20 + cycle60 + cycle100 + cycle140 + cycle180 + cycle220;
Console.WriteLine(cycleSum);
