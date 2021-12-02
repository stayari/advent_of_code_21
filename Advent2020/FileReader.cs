using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2020
{
    class FileReader
    {
        private string text;
        private string[] lines;

        public FileReader()
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = dir + @"\..\..\..\Inputs\day2.txt";
            lines = System.IO.File.ReadAllLines(path);
            //Console.WriteLine(lines);

        }
        public string[] GetLines()
        {
            return lines;
        }



    }
}
