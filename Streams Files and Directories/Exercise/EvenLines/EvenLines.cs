namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Security.Authentication.ExtendedProtection;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            string result = ProcessLines(inputFilePath);
        }

        public static string ProcessLines(string inputFilePath)
        {
            string output = string.Empty;
            char[] chars = { '-', ',', '.', '!', '?' };
            int count = 0;
            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                while (true)
                {
                    string line = streamReader.ReadLine();
                    if (line == null)
                        break;

                    line = Reverse(line);

                    foreach (char ch in line)
                    {
                        foreach (char ch2 in chars)
                        {
                            if (ch == ch2)
                            {
                                line = line.Replace(ch, '@');
                            }
                        }
                    }

                    if (count % 2 == 0)
                    {
                        output = line;
                        Console.WriteLine(line);
                    }
                    count++;
                }

            }
            return output;

        }
        public static string Reverse(string Input)
        {

            string[] s =
        Input.Split(' ');
            string reverse = "";
            for (int i = s.Length - 1;
                     i >= 0; i--)
            {
                reverse += s[i] + " ";
            }

            return (reverse.Substring(0,
                          reverse.Length - 1));
        }
    }
}
