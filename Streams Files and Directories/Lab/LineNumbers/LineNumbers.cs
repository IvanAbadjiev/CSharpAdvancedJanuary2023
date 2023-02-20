namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            StreamReader streamReader = new StreamReader(inputFilePath);

            using (streamReader)
            {
                StreamWriter streamWriter = new StreamWriter(outputFilePath);
                using (streamWriter)
                {

                    string line = streamReader.ReadLine();
                    int row = 0;
                    while (line != null)
                    {
                        streamWriter.WriteLine($"{++row}. {line}");
                        line = streamReader.ReadLine();
                    }
                }
            }



        }
    }
}
