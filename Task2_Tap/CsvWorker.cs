using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Task2_Tap
{
    class CsvReader
    {
        public List<string> ReadTable(string fileName)
        {
            var fileText = new StreamReader(fileName);
            string results = fileText.ReadToEnd();
            fileText.Close();

            var teams = results.Split("\n", StringSplitOptions.RemoveEmptyEntries).ToList();
            
            return teams;
        }
    }

    class CsvWriter
    {
        public void WriteTable(string fileName, List<string> table)
        {
            var writeText = new StreamWriter(fileName, false);

            var text = string.Join("\n", table);
            writeText.WriteLine(text);
            writeText.Close();
        }
    }

}
