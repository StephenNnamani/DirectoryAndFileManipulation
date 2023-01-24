using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Documentation_Logic
{
    public class ReadFile
    {
        public static StringBuilder ReadJsonFile()
        {
            var option = new JsonSerializerOptions
            {
                IncludeFields = true,
                WriteIndented = true
            };

            string readFile = File.ReadAllText(@"C:\Users\USER\Desktop\C# Projects and Nuggets\DirectoryAndFileManipulation\DirAndFile_Data\MockData.json");
            StringBuilder serializedFile = new();

            try
            {
                var serializedFile2 = JsonSerializer.Deserialize<UserModel>(File.ReadAllText(readFile), option);

                serializedFile.Append(serializedFile2.ToString());
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return serializedFile;
        }
    }
}
