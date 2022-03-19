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
            StreamWriter writeText = new StreamWriter(fileName, false);
            writeText.WriteLine(table);
            writeText.Close();
        }
    }

    static class FileWorker
    {
        public static string readFromFile(string name)
        {
            StreamReader sr = new StreamReader(name);
            string message = sr.ReadToEnd();
            sr.Close();

            return message;
        }

        public static string editText(string sourceText)
        {
            string[] lines = sourceText.Split("\n", StringSplitOptions.RemoveEmptyEntries);

            string[] splitters = new string[2] { ";", ":" };
            for (int i = 1; i < lines.Length; i++)
            {
                string[] results = lines[i].Split(splitters, StringSplitOptions.RemoveEmptyEntries);

                lines[i] = lines[i].Substring(0, lines[i].Length - 1) + $";{comparator(results)}";
            }

            return string.Join("\n", lines);
        }

        private static string comparator(string[] res)
        {
            int result = 0;

            for (int i = 1; i < res.Length - 1; i = i + 2)
            {
                if (int.Parse(res[i]) > int.Parse(res[i + 1]))
                {
                    result += 3;
                }
                else if (int.Parse(res[i]) == int.Parse(res[i + 1]))
                {
                    result += 1;
                }
            }
            
            return result.ToString();
        }

        public static void writeToFile(string name, string text)
        {
            StreamWriter writeText = new StreamWriter(name, false);
            writeText.WriteLine(text);
            writeText.Close();
        }
    }
}
