using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2_Tap
{
    class CsvReader
    {
        public string[][] ReadTable(string fileName)
        {
            var fileText = new StreamReader(fileName);
            string results = fileText.ReadToEnd();
            fileText.Close();

            var lines = results.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            var lineSplitters = new string[2] { ";", ":" };
            var resultsTable = new string[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                resultsTable[i] = lines[i].Split(lineSplitters, StringSplitOptions.RemoveEmptyEntries);
            }

            return resultsTable;
        }
    }

    class CsvWriter
    {
        public void WriteTable(string fileName, string table)
        {
            var writeText = new StreamWriter(fileName, false);
            writeText.WriteLine(table);
            writeText.Close();
        }
    }

}
