namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            int count = 0;
            List<string> outLines = new List<string>();
            foreach (var line in lines)
            {
                int letherCount = line.Count(char.IsLetter);
                int symbolCount = line.Count(char.IsPunctuation);
                count++;
                string moodLine = $"Line {count}: {line} ({letherCount})({symbolCount})";
                outLines.Add(moodLine);
            }

            File.WriteAllLines(outputFilePath, outLines);
        }
    }
}
