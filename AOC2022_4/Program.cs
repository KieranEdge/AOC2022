using AOC2022_4.Data_Accessor;
using AOC2022_4.Data_Processor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_4\\Data\\Data.txt";

List<int[,]> sequence1 = new List<int[,]>();
List<int[,]> sequence2 = new List<int[,]>();
int runningTotal = 0;

(sequence1, sequence2) = DataAccessor.TextFileToIntegerArrays(filePath);

for (int i = 0; i < sequence1.Count; i++)
{
    int sequence1Start = sequence1[i][0,0];
    int sequence1End = sequence1[i][1,0];
    int sequence2Start = sequence2[i][0,0];
    int sequence2End = sequence2[i][1,0];

    bool result = DataProcessor.IntegerComparer(sequence1Start, sequence1End, sequence2Start, sequence2End);
    if (result)
    {
        runningTotal++;
    }
}

Console.WriteLine($"Number of sequences contained = {runningTotal}");