using ParallelLearning.Implementations;
using System.Diagnostics;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var directory = @"C:\Users\eugene\Desktop\ParallelismLearning";
        var fileReadingOperations = new FileReadingOperations();
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var tasks = fileReadingOperations.GetCountSpacesFromDirectorysFiles(directory);
        var tasksResults = await Task.WhenAll(tasks);

        stopWatch.Stop();

        foreach (var task in tasksResults) 
        {
            Console.WriteLine($"FileName: {task.FileName}; Spaces count: {task.SpacesCount}");
        }
        Console.WriteLine("Work time: " + stopWatch.Elapsed.Milliseconds.ToString() + " ms");
    }
}