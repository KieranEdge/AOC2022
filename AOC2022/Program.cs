using AOC2022_1.DataProcessor;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string filePath = "C:\\Users\\Kieran Edge\\source\\repos\\AOC2022\\AOC2022\\Data\\Data.txt";

DataAccessor.FileReader(filePath);

/*TO DO
 * Read data from file line by line and convert to int
 * initialise a list of sums
 * Add int to rolling sum
 * If blank line set commit rolling sum to zero and add previous sum to the list
 * Return max value in the list
 */