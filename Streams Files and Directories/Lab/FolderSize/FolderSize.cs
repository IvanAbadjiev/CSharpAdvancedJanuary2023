namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {

            StreamWriter streamWriter = new StreamWriter(outputFilePath);
            using (streamWriter)
            {
                streamWriter.WriteLine(GetFolderSize(folderPath) / 1024 + " KB");

            }

        }

        public static decimal GetFolderSize(string path)
        {
            string[] filePaths = Directory.GetFiles(path);

            decimal size = 0;

            foreach (var filePath in filePaths)
            {
                FileInfo info = new FileInfo(filePath);
                size += info.Length;

            }

            foreach (var dirPaths in Directory.GetDirectories(path))
            {
                size += GetFolderSize(dirPaths);
            }
            return size;

        }
    }
}
