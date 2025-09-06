namespace DecoratorProject;

// step 3

// Base Decorator: کلاس پایه برای همه دکوراتورها
// این کلاس یک Logger دیگر را می‌گیرد و می‌تواند قبل/بعد از آن کار اضافی انجام دهد
public abstract class LoggerDecorator : ILogger
{
    protected ILogger _logger;

    protected LoggerDecorator(ILogger logger)
    {
        _logger = logger;
    }

    public virtual void Log(string message)
    {
        _logger.Log(message);
    }
}