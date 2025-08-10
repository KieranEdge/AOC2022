using AOC2022_9.DataProcessor;

List<char> directionsList = new List<char>();
List<int> movesList  = new List<int>();
string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_9\\Data\\Data.txt";

(directionsList, movesList) = DataAccessor.fileToDirectionsAndMoves(filePath);

List<List<int>> headMoves = new List<List<int>>();
List<List<int>> tailMoves = new List<List<int>>();

List<int> headPosition = new List<int>() { 0, 0 };
List<int> tailPosition = new List<int>() { 0, 0 };

// Iterating over the directions
for(int i = 0;  i < directionsList.Count; i++)
{
    int numberOfSteps = movesList[i];

    for(int j = 0; j < numberOfSteps; j++)
    {
        if (directionsList[i] == 'U')
        {
            headPosition[1]++;
        }
        else if (directionsList[i] == 'D')
        {
            headPosition[1]--;
        }
        else if (directionsList[i] == 'R')
        {
            headPosition[0]++;
        }
        else if (directionsList[i] == 'L')
        {
            headPosition[0]--;
        }
        Console.WriteLine($"Head is at position: {headPosition[0]}, {headPosition[1]}");
        headMoves.Add(headPosition);
    }
}

