using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentation_Logic
{
    public class CreateFiles
    {
        public static void CreateTextFile()
        {
            string? content = ReadFile.ReadJsonFile().ToString();
            string filePath = @"C:\Users\USER\Desktop\C# Projects and Nuggets\DirectoryAndFileManipulation\DirAndFile_Data\MockData.txt";

            try
            {
                File.WriteAllText(filePath, content);
            }
            catch
            {
                Console.WriteLine("Error writing to file");
            }
        }
    }
}
