using AOC2022_4.Data_Accessor;

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022_4\\Data\\Data.txt";

List<int[,]> sequence1 = new List<int[,]>();
List<int[,]> sequence2 = new List<int[,]>();

(sequence1, sequence2) = DataAccessor.TextFileToIntegerArrays(filePath);