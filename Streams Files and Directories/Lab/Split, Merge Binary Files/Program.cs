﻿namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
//You are given an input binary file(e.g.example.png).Write a program to split it into two
//equal-sized files(e.g.part - 1.bin and part - 2.bin).When the input file size is an odd number,
//the first part should be 1 byte bigger than the second.
//After splitting the input file, join the obtained files into a new file(e.g.example -
//joined.png).The obtained result file should be the same as the initial input file.

            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream source = new FileStream(sourceFilePath, FileMode.Open))
            {
                using (FileStream part1 = new FileStream(partOneFilePath, FileMode.Create))
                {
                    int odd = source.Length / 2 == 1 ? 1 : 0;
                    byte[] buffer1 = new byte[source.Length/2 + odd];
                    source.Read(buffer1);
                    part1.Write(buffer1, 0, (int)buffer1.Length);
                }

                using (FileStream part2 = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    byte[] buffer2 = new byte[source.Length / 2];
                    source.Read(buffer2);
                    part2.Write(buffer2, 0, (int)buffer2.Length);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream joined = new FileStream(joinedFilePath, FileMode.Create))
            {
                using (FileStream part1 = new FileStream(partOneFilePath, FileMode.Open))
                {
                    byte[] buffer1 = new byte[part1.Length];
                    part1.Read(buffer1);
                    joined.Write(buffer1);
                }
                using (FileStream part2 = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    byte[] buffer2 = new byte[part2.Length];
                    part2.Read(buffer2);
                    joined.Write(buffer2);
                }
            }
        }
    }
}
