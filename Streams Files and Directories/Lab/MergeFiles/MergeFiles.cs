namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            StreamReader streamOne = new StreamReader(firstInputFilePath);
            StreamReader streamTwo = new StreamReader(secondInputFilePath);
            StreamWriter streamWriter = new StreamWriter(outputFilePath);
            using (streamOne)
            {
                using (streamTwo)
                {
                    using (streamWriter)
                    {
                        while (true)
                        {
                            string oneLine = streamOne.ReadLine();
                            string twoLine = streamTwo.ReadLine();

                            if (oneLine == null && twoLine == null)
                                break;


                            if (oneLine != null && twoLine != null)
                            {
                                streamWriter.WriteLine(oneLine);
                                streamWriter.WriteLine(twoLine);
                            }
                            else
                            {
                                if (oneLine != null)
                                {
                                    streamWriter.WriteLine(oneLine);
                                }

                                if (twoLine != null)
                                {
                                    streamWriter.WriteLine(twoLine);
                                }



                            }


                            //if (twoLine == null && oneLine != null)
                            //{
                            //    streamWriter.WriteLine(oneLine);
                            //}
                            //else if (oneLine == null && twoLine != null)
                            //{
                            //    streamWriter.WriteLine(twoLine);
                            //}
                            //else
                            //{
                            //    streamWriter.WriteLine(oneLine);
                            //    streamWriter.WriteLine(twoLine);
                            //}




                        }

                    }

                }

            }

        }
    }
}
