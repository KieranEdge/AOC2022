using AOC2022_4.Data_Accessor;
using AOC2022_4.Data_Processor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_4\\Data\\Data.txt";

List<int[,]> sequence1 = new List<int[,]>();
List<int[,]> sequence2 = new List<int[,]>();
int runningTotal_Part1 = 0;
int runningTotal_Part2 = 0;

(sequence1, sequence2) = DataAccessor.TextFileToIntegerArrays(filePath);

for (int i = 0; i < sequence1.Count; i++)
{
    int sequence1Start = sequence1[i][0,0];
    int sequence1End = sequence1[i][1,0];
    int sequence2Start = sequence2[i][0,0];
    int sequence2End = sequence2[i][1,0];

    bool result_1 = DataProcessor.IntegerComparer_Part1(sequence1Start, sequence1End, sequence2Start, sequence2End);
    if (result_1)
    {
        runningTotal_Part1++;
    }

    bool result_2 = DataProcessor.IntegerComparer_Part2(sequence1Start, sequence1End, sequence2Start, sequence2End);
    if (result_2) 
    { 
        runningTotal_Part2++; 
    }
}

Console.WriteLine($"Number of sequences fully contained = {runningTotal_Part1}");
Console.WriteLine($"Number of sequences partially contained = {runningTotal_Part2}");