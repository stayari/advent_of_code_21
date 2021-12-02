using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2020
{
    class Day2
    {   
        private string[] lines;
        private int ans; 
        public Day2(string[] lines)
        {
            this.lines = lines;
            Navigating2();

        }
        public int GetAns()
        {
            return ans; 
        }
        private int Navigating()
        {
            int forward = 0;
            int depth = 0;
            foreach (string line in lines)
            {
                string[] navigator = line.Split(' ');
                if (depth < 0)
                {
                    depth = 0;
                }
                int val = Int32.Parse(navigator[1]);
                switch (navigator[0])
                {
                    case "forward":
                        forward = forward + val;
                        //Console.WriteLine(navigator[1]);
                        break;
                    case "up":
                        //Console.WriteLine(navigator[1]);
                        depth = depth - val;
                        break;
                    case "down":
                        //Console.WriteLine(navigator[1]);
                        depth = depth + val;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("forward: {0} depth: {1}", forward, depth);
            ans = forward * depth;
            return ans; 
        }

        private int Navigating2()
        {

            int aim = 0;
            int forward = 0;
            int depth = 0;
            foreach (string line in lines)
            {
                if (depth < 0) depth = 0; 
                string[] navigator = line.Split(' ');

                int val = Int32.Parse(navigator[1]);
                switch (navigator[0])
                {
                    case "forward":
                        forward = forward + val;
                        depth = depth + Math.Abs(val * aim);
                        //Console.WriteLine(navigator[1]);
                        break;
                    case "up":
                        //Console.WriteLine(navigator[1]);
                        aim = aim - val;
                        break;
                    case "down":
                        //Console.WriteLine(navigator[1]);
                        aim = aim + val;
                        break;
                    default:
                        break;
                }

            }
            ans = depth * forward;
            return ans;
        }
    }
}