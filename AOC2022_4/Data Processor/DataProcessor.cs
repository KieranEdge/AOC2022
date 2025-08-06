using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_4.Data_Processor
{
    public static class DataProcessor
    {
        public static bool IntegerComparer_Part1(int seq1_start, int seq1_end, int seq2_start, int seq2_end)
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

        public static bool IntegerComparer_Part2(int seq1_start, int seq1_end, int seq2_start, int seq2_end)
        {
            bool result = false;

            if (seq1_start >= seq2_start && seq1_end <= seq2_end)
            {
                // seq 1 fully contained within seq 2
                result = true;
            }
            else if (seq2_start >= seq1_start && seq2_end <= seq1_end)
            {
                // seq 2 fully contained within seq 1
                result = true;
            }

            else if (seq1_start < seq2_start && seq1_end >= seq2_start && seq1_end <= seq2_end)
            {
                // seq1 overlaps seq 2 from the outside and into it
                result = true;
            }

            else if(seq1_start >= seq2_start && seq1_start <= seq2_end && seq1_end > seq2_end)
            {
                // seq1 overlaps seq 2 from inside it and out of it
                result = true;
            }

            else if (seq2_start < seq1_start && seq2_end >= seq1_start && seq2_end <= seq1_end)
            {
                // seq2 overlaps seq 1 from the outside and into it
                result = true;
            }

            else if (seq2_start >= seq1_start && seq2_start <= seq1_end && seq2_end > seq1_end)
            {
                // seq2 overlaps seq 1 from inside it and out of it
                result = true;
            }

            return result;
        }
    }
}
