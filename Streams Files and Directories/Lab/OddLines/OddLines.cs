namespace OddLines
{
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader streamReader = new StreamReader(inputFilePath);

            using (streamReader)
            {

                StreamWriter streamWriter = new StreamWriter(outputFilePath);

                using (streamWriter)
                {
                    int row = 0;
                    while (true)
                    {
                        string input = streamReader.ReadLine();
                        if (input == null)
                            break;

                        if (row % 2 != 0)
                        {
                            streamWriter.WriteLine(input);

                        }
                        row++;



                    }
                }
            }





        }
    }
}
