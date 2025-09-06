namespace DecoratorProject;

// step 4

// Concrete Decorator: اضافه کردن تاریخ و زمان به لاگ
public class TimestampLogger : LoggerDecorator
{
    public TimestampLogger(ILogger logger) : base(logger)
    {
    }

    public override void Log(string message)
    {
        base.Log($"[{DateTime.Now}] {message}");
    }
}