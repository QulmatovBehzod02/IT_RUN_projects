// See https://aka.ms/new-console-template for more information
using task_file_manager;


while (true)
{
    Console.WriteLine("Text:");

    using (var fileManager = new FileManager("store.txt"))
    {
        string text = Console.ReadLine();
        fileManager.WriteToFile(text);
    }

    using (StreamReader reader = new StreamReader("store.txt"))
    {
        string text = reader.ReadToEnd();
        Console.WriteLine(text);
    }
}

