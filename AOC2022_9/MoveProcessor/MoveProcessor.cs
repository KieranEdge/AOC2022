using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022_9.MoveProcessor
{
    internal static class MoveProcessor
    {
        public static List<int> TailPositionMapper(List<int> headPosition, List<int> tailPosition)
        {
            var newTailPosition = new List<int>(tailPosition);

            int dx = headPosition[0] - tailPosition[0];
            int dy = headPosition[1] - tailPosition[1];

            // Tail moves only if more than 1 away in any direction
            if (Math.Abs(dx) > 1 || Math.Abs(dy) > 1)
            {
                newTailPosition[0] += Math.Sign(dx); // Move X by at most 1
                newTailPosition[1] += Math.Sign(dy); // Move Y by at most 1
            }

            return newTailPosition;
        }

    }
}
