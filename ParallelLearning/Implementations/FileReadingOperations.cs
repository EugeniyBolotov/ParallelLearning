using ParallelLearning.Properties;

namespace ParallelLearning.Implementations
{
    internal class FileReadingOperations
    {
        public IEnumerable<Task<CountSpacesResult>> GetCountSpacesFromDirectorysFiles(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);

            Task<CountSpacesResult>[] tasks = new Task<CountSpacesResult>[files.Length];
            return files.Select(file => Task.Run(() => CountSpacesFromFile(file)));
        }


        public async Task<CountSpacesResult> CountSpacesFromFile(string filePath)
        {
            int spacesCount = 0;
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string content = reader.ReadToEnd();
                    spacesCount = content.Count(c => c == ' ');
                }
            }

            return new CountSpacesResult(Path.GetFileName(filePath), spacesCount);
        }
    }
}
