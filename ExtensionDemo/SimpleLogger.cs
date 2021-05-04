namespace ExtensionDemo
{
    // Take an exmaple of third-party logging provider
    public class SimpleLogger : ISimpleLogger
    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }

        public void Log(string message, string messageType)
        {
            Log($"{messageType}: {message}");
        }
    }



}
