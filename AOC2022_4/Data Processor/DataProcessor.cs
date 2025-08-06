using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_4.Data_Processor
{
    public static class DataProcessor
    {
        public static bool IntegerComparer(int seq1_start, int seq1_end, int seq2_start, int seq2_end)
        {
            bool result = false;

            if (seq1_start >= seq2_start && seq1_end <= seq2_end)
            {
                result = true;
            }
            else if (seq2_start >= seq1_start && seq2_end <= seq1_end)
            {
                result = true;
            }

            return result;
        }
    }
}
