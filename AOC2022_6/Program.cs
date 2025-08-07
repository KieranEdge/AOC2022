using AOC2022_6.Data_Accessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_6\\Data\\Data.txt";

char[] charactersInFile = Data_Accessor.TextFileToCharacterArray(filePath);

List<char> recentCharacters = new List<char>();
int processingInt = 0;
bool stopProcessing = false;

while (!stopProcessing)
{
    if (recentCharacters.Contains(charactersInFile[processingInt]))
    {
        // Clearing the list and adding the new character
        recentCharacters.Clear();
        recentCharacters.Add(charactersInFile[processingInt]);
        processingInt++;
    }
    else
    {
        // Adding the new character
        recentCharacters.Add(charactersInFile[processingInt]);
        if (recentCharacters.Count == 14)
        {
            break;
        }
        processingInt++;
    }
}

Console.WriteLine(processingInt + 1);