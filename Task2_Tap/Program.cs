using System;

namespace Task2_Tap
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = FileWorker.readFromFile("file1.csv");
            FileWorker.writeToFile("resultFile.csv", FileWorker.editText(text));
        }
    }
}
