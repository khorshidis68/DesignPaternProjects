using SingletonProject;

public class Program
{
    private static void Main(string[] args)
    {
        var singleton = Singleton.Instance;
        singleton.DoSomething();

        singleton.SetName("Test1");
        singleton.PrintName();

        singleton.SetName("Test2");
        singleton.PrintName();

        Console.WriteLine("Hello, World!");
    }
}