using AOC2022_9.DataProcessor;
using AOC2022_9.MoveProcessor;

List<char> directionsList = new List<char>();
List<int> movesList  = new List<int>();
string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_9\\Data\\Data.txt";

(directionsList, movesList) = DataAccessor.fileToDirectionsAndMoves(filePath);

List<List<int>> headMoves = new List<List<int>>();
List<List<int>> tailMoves = new List<List<int>>();

List<int> headPosition = new List<int>() { 0, 0 };
List<int> tailPosition = new List<int>() { 0, 0 };
var uniqueTailPositions = new HashSet<(int, int)>();
int ropeLength = 10;
var rope = new List<(int x, int y)>();
for (int i = 0; i < ropeLength; i++)
    rope.Add((0, 0));  // start at origin

var visitedPositions = new HashSet<(int, int)>();
visitedPositions.Add(rope[ropeLength - 1]); // starting position

for (int i = 0; i < directionsList.Count; i++)
{
    int steps = movesList[i];
    for (int step = 0; step < steps; step++)
    {
        // Move head
        var head = rope[0];
        if (directionsList[i] == 'U') head.y++;
        else if (directionsList[i] == 'D') head.y--;
        else if (directionsList[i] == 'L') head.x--;
        else if (directionsList[i] == 'R') head.x++;
        rope[0] = head;

        // Move other knots
        for (int k = 1; k < ropeLength; k++)
        {
            rope[k] = MoveProcessor.TailPositionMapper(rope[k - 1], rope[k]);
        }

        // Track last knot position
        visitedPositions.Add(rope[ropeLength - 1]);
    }
}

Console.WriteLine($"Unique positions visited by last knot: {visitedPositions.Count}");