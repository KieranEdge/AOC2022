using AOC2022_8.Data_Accessor;
using AOC2022_8.Data_Processor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_7\\Data\\Data.txt";

int[,] integersArray = Data_Accessor.FileToIntArray(filePath);
Console.WriteLine("Array generated");

// Iterating over the array but only the external indices
int rowEnd = integersArray.GetLength(0);
int colEnd = integersArray.GetLength(1);
Console.WriteLine($"The array has dimensions on {rowEnd} x {colEnd}");
int visibleTrees = 0;

List<int> scenicScores = new List<int>();

for (int row = 0; row < rowEnd; row++)
{
    for (int col = 0; col < colEnd; col++)
    {
        int[] currentRow = RowColumnExtractor.GetRow(integersArray, row);
        int[] currentCol = RowColumnExtractor.GetColumn(integersArray, col);

        bool isVisible = VisibilityCalculator.IsTreeVisible(currentRow, currentCol, row, col);
        scenicScores.Add(ScenicScore.CalculateScenecity(currentRow, currentCol, row, col));

        if (isVisible)
        {
            visibleTrees++;
        }
    }
}

Console.WriteLine($"The number of visible trees from the edges: {visibleTrees}");
Console.WriteLine($"The most scenic spot has a score of: {scenicScores.Max()}");
