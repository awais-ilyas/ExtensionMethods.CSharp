using CustomExtensions;
using System;

namespace ExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            "This is a demo".PrintToConsole();
            var upperCase = "THIS IS A UPPER CASE STRING CONVERTED TO TITLE CASE".ToTitleCase();
            Console.WriteLine(upperCase);

            ISimpleLogger logger = new SimpleLogger();

            logger.Log("Test Error", "Error");
            logger.LogError("This is an error");
            logger.LogWarning("This is a warning");
            Console.WriteLine("Goodbye");
        }
    }
}
