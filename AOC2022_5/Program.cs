using AOC2022_5.DataProcessor;

// Separating the file paths for the starting positions and moves
string startingPositionFilePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_5\\Data\\StartingPositions.txt";
string movesListFilePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_5\\Data\\Moves.txt";

// Initialising the starting positions to a dictionary
Console.WriteLine("Original Positions");
Dictionary<int, List<char>> positions = StartingPositionExtractor.GetCratesStartingPositions(startingPositionFilePath);

// Getting the lists of moves to generate
List<List<int>> movesList = MoveExtractor.LinesInFileToIntegers(movesListFilePath);

foreach (List<int> move in movesList)
{
    List<char> tempList = new List<char>();
    
    for (int i = 0; i < move[0]; i++)
    {
        // Creating the stack of crates
        tempList.Add(positions[move[1]][i]);
    }

    positions[move[1]].RemoveRange(0, move[0]);
    
    tempList.Reverse();
    foreach(char c in tempList)
    {
        positions[move[2]].Insert(0, c);
    }

}

// Example output
Console.WriteLine("Final positions");
foreach (var kvp in positions)
{
    Console.WriteLine($"Stack {kvp.Key}: {string.Join("", kvp.Value)}");
}