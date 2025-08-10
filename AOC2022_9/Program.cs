using AOC2022_9.DataProcessor;
using AOC2022_9.MoveProcessor;

List<char> directionsList = new List<char>();
List<int> movesList = new List<int>();
string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_9\\Data\\Data.txt";

(directionsList, movesList) = DataAccessor.fileToDirectionsAndMoves(filePath);

List<List<int>> headMoves = new List<List<int>>();
List<List<int>> tailMoves = new List<List<int>>();

int ropeLength = 10;
var rope = new List<List<int>>();

// Initialize rope knots at origin (0,0)
for (int k = 0; k < ropeLength; k++)
{
    rope.Add(new List<int>() { 0, 0 });
}

var uniqueLastKnotPositions = new HashSet<(int, int)>();

// Add starting position of last knot
uniqueLastKnotPositions.Add((rope[ropeLength - 1][0], rope[ropeLength - 1][1]));

for (int i = 0; i < directionsList.Count; i++)
{
    int numberOfSteps = movesList[i];

    for (int j = 0; j < numberOfSteps; j++)
    {
        // Move head (rope[0])
        if (directionsList[i] == 'U') rope[0][1]++;
        else if (directionsList[i] == 'D') rope[0][1]--;
        else if (directionsList[i] == 'R') rope[0][0]++;
        else if (directionsList[i] == 'L') rope[0][0]--;

        // Move each subsequent knot following the knot before it
        for (int k = 1; k < ropeLength; k++)
        {
            rope[k] = MoveProcessor.TailPositionMapper(rope[k - 1], rope[k]);
        }

        // Track last knot’s position
        uniqueLastKnotPositions.Add((rope[ropeLength - 1][0], rope[ropeLength - 1][1]));

        // Optional: track all knot moves if needed
        // headMoves.Add(new List<int>(rope[0]));
        // tailMoves.Add(new List<int>(rope[ropeLength - 1]));
    }
}

Console.WriteLine($"Unique positions visited by last knot: {uniqueLastKnotPositions.Count}");