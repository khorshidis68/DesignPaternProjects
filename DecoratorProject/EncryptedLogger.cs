namespace DecoratorProject;

// step 5

// Concrete Decorator: رمزنگاری پیام قبل از چاپ
public class EncryptedLogger : LoggerDecorator
{
    public EncryptedLogger(ILogger logger) : base(logger)
    {
    }

    public override void Log(string message)
    {
        string encrypted = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(message));
        base.Log(encrypted);
    }
}