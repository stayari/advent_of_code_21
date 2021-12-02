using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2020
{
    class Day1
    {
        private int[] lines;
        private int ans;
        public Day1(string[] lines)
        {
            //this.lines = lines;
            this.lines = Array.ConvertAll(lines, int.Parse);
            RemakeLinesSlidingWindow();
            ans = CountIncreases();

        }
        public int GetAns()
        {
            return ans;
        }
        private int CountIncreases()
        {
            int incCounter = 0;
            var val = lines[0];
            foreach (int line in lines)
            {
                if (val < line)
                {
                    incCounter++;
                }
                val = line;
            }
            return incCounter;
        }
        private void RemakeLinesSlidingWindow()
        {
            int slidingValue = 0;
            List<int> newList = new List<int>();

            for (int i = 0; i < lines.Length - 2; i++)
            {
                slidingValue = lines[i] + lines[i + 1] + lines[i + 2];
                newList.Add(slidingValue);
            }
            lines = newList.ToArray();
        }
    }
}
