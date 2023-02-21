namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var databasse = new Dictionary<string, int>();
            StreamReader streamReader = new StreamReader(wordsFilePath);
            using (streamReader)
            {
                string[] words = streamReader
                    .ReadToEnd()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                StreamReader stream = new StreamReader(textFilePath);
                using (stream)
                {
                    while (true)
                    {
                        string strings = stream.ReadLine();
                        if (strings == null)
                            break;

                        foreach (var word in words)
                        {
                            if (strings.ToLower().Contains(word))
                            {
                                if (!databasse.ContainsKey(word))
                                    databasse.Add(word, 0);

                                databasse[word]++;

                            }

                        }


                    }
                }

                StreamWriter streamWriter = new StreamWriter(outputFilePath);

                using (streamWriter)
                {
                    foreach (var item in databasse.OrderByDescending(entry => entry.Value))
                    {
                        streamWriter.WriteLine($"{item.Key} - {item.Value}");
                    }


                }

            }



        }
    }
}
