using System;

namespace Task2_Tap
{
    class Lab2_Practice
    {
        static void Main(string[] args)
        {
            var inputFileName = "input.csv";

            var tableReader = new CsvReader();
            var inputTable = tableReader.ReadTable(inputFileName);

            var editTable = new TableEditor();
            var outputTable = editTable.ResultAdder(inputTable);

            var outputFileName = "output.csv";
            var tableWriter = new CsvWriter();
            tableWriter.WriteTable(outputFileName, outputTable);
        }
    }
}
