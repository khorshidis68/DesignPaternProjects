namespace DecoratorProject;

// step 2

// Concrete Component: پیاده‌سازی اصلی که فقط پیام را در کنسول چاپ می‌کن
public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}