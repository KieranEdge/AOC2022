using AOC2022_10.DataProcessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_10\\Data\\Data.txt";

List<string> instructions = new List<string>();
List<int> values = new List<int>();
int totalValue = 1;

List<int> valueAtCycle = new List<int>();

(instructions, values) = DataSeparator.LinesToInstructionsAndIntegers(filePath);

int[] spritePosition = new int[] { 0, 2 };
string[] rowOutputs = new string[6];

for (int i = 0; i < instructions.Count; i++)
{
    valueAtCycle.Add(totalValue);
    if (instructions[i] == "addx")
    {
        valueAtCycle.Add(totalValue);
        totalValue += values[i];
    }
}

for (int i = 1; i <= 240; i++)
{
    int horizontalPos = (i - 1) % 40;
    spritePosition[0] = valueAtCycle[i - 1] - 1;
    spritePosition[1] = valueAtCycle[i - 1] + 1;

    string crtCharacter = (horizontalPos >= spritePosition[0] && horizontalPos <= spritePosition[1])
        ? "#" : ".";

    rowOutputs[(i - 1) / 40] += crtCharacter;
}

foreach (string row in rowOutputs)
{
    Console.WriteLine(row);
}