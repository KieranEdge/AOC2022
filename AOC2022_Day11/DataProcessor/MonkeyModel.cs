using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_11.DataProcessor
{
    public class MonkeyModel
    {
        public int Id { get; set; }
        public List<int> StartingItems { get; set; }
        
        public int WorryFactor { get; set; }
        
        public bool isSquare {  get; set; }
        public char Operation { get; set; }
        public int TestDivisibleBy { get; set; }
        public int IfTrueThrowTo { get; set; }
        public int IfFalseThrowTo { get; set; }

        public MonkeyModel(string[] monkeyBlock)
        {
            Id = int.Parse(monkeyBlock[0].Split(' ')[1].TrimEnd(':'));
            
            StartingItems = monkeyBlock[1]
                .Replace("Starting items:", "")
                .Split(',')
                .Select(s => int.Parse(s.Trim()))
                .ToList();

            if (monkeyBlock[2].Split(" ")[7] == "old")
            {
                isSquare = true;
                WorryFactor = 0;
            }
            else
            {
                isSquare = false;
                WorryFactor = int.Parse(monkeyBlock[2].Split(" ")[7]);
            }
            

            Operation = monkeyBlock[2].Split(' ')[6][0];

            TestDivisibleBy = int.Parse(monkeyBlock[3].Split(' ').Last());

            IfTrueThrowTo = int.Parse(monkeyBlock[4].Split(' ').Last());

            IfFalseThrowTo = int.Parse(monkeyBlock[5].Split(' ').Last());
        }
    }
}
