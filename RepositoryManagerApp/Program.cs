using RepositoryManagerLibrary;
using System;

namespace RepositoryManagerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var repositoryManager = new RepositoryManager();
            repositoryManager.Initialize();

            try
            {
                // Register items
                repositoryManager.Register("item1", "{\"key\": \"value\"}", 1); // JSON
                repositoryManager.Register("item2", "<item><key>value</key></item>", 2); // XML

                // Retrieve items
                string jsonContent = repositoryManager.Retrieve("item1");
                Console.WriteLine($"Item1 content (JSON): {jsonContent}");

                string xmlContent = repositoryManager.Retrieve("item2");
                Console.WriteLine($"Item2 content (XML): {xmlContent}");

                // Get item types
                int item1Type = repositoryManager.GetType("item1");
                Console.WriteLine($"Item1 type: {(item1Type == 1 ? "JSON" : "XML")}");

                int item2Type = repositoryManager.GetType("item2");
                Console.WriteLine($"Item2 type: {(item2Type == 1 ? "JSON" : "XML")}");

                // Deregister an item
                repositoryManager.Deregister("item1");
                Console.WriteLine("Item1 has been deregistered.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
