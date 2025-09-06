using DecoratorProject;

internal class Program
{
    private static void Main(string[] args)
    {
        // شی اصلی
        ILogger logger = new ConsoleLogger();

        // اضافه کردن تاریخ و زمان
        ILogger timestampLogger = new TimestampLogger(logger);
        timestampLogger.Log("افزودن لاگ");

        ILogger encryptedLogger = new EncryptedLogger(timestampLogger);
        encryptedLogger.Log("پیام محرمانه");
    }
}

// نکته:
// ConsoleLogger رفتار پایه دارد.
// TimestampLogger و EncryptedLogger قابلیت‌های جدیدی را بدون تغییر در کلاس اصلی اضافه می‌کنند.
// (می‌توان آن‌ها را روی هم سوار کرد (ترکیب کرد.