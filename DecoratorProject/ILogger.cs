namespace DecoratorProject;

// step 1

// Component: رابط مشترک بین Loggerها
public interface ILogger
{
    void Log(string message);
}